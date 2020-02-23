using Sip2Service.Model;
using System;
using System.Linq;
using System.Net.Sockets;

namespace Sip2Service.SIP2
{
    public class Sip2Helper : Sip2Common, IDisposable
    {
        private static string host = string.Empty;
        private static int port = 0;
        private static string username = string.Empty;
        private static string password = string.Empty;
        private sip2 sipclient;
        private static string AO = string.Empty;
        private static string AP = string.Empty;
        private static string VP = string.Empty;
        private static string locationCode = string.Empty;
        private static string charset = string.Empty;
        private bool disposed;
        //private //logger //logger = LogManager.GetCurrentClassLogger();
        private static string sendResult = string.Empty;

        public Sip2Helper(Sip2Model sip2Info)
        {
            host = sip2Info.IP;
            port = int.Parse(sip2Info.Port);
            AO = sip2Info.AO;
            AP = sip2Info.AP;
            VP = sip2Info.VP;
            locationCode = sip2Info.LocationCode;
            charset = sip2Info.Charset;
            username = sip2Info.Uid;
            password = sip2Info.Pwd;

            if (host != string.Empty && port != 0)
            {
                sipclient = new sip2(host, port, AO, AP, VP);
                sipclient.setCharset(charset);
                ConnentServer();
            }
        }

        ~Sip2Helper()
        {
            if (sipclient != null)
                sipclient.Close();
        }

        public bool IsConnected()
        {
            return sipclient.Connected();
        }

        public void ConnentServer()
        {
            try
            {
                if (sipclient.Connected() == false)
                {
                    sipclient.Connect();
                    if (sipclient.Connected() && !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                    {
                        if (Login(username, password) != ErrorCode.Success)
                        {
                            sendResult = "Sip2 Server 登录失败";
                            ////logger.Warn("Sip2 Server 登录失败");
                            sipclient.Close();
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                sendResult = exception.ToString();
                ////logger.Error("无法连接 Sip2 Server: " + exception.ToString());
                sipclient.Close();
            }
        }

        public string GetSendResult()
        {
            return sendResult;
        }

        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="pwd"></param>
        public int Login(string uid, string pwd)
        {
            if (sipclient == null || !sipclient.Connected())
                return ErrorCode.DisConnectedWithLibraryServer;

            int result = 0;

            try
            {
                SipTransaction st = sipclient.Login(uid, pwd, locationCode, VP);
                string msg = st.Response;
                if (msg.StartsWith(Sip2Common.LoginResponse))
                {
                    char ok = msg.ElementAt(2);
                    if (ok == '1')
                    {
                        result = ErrorCode.Success;
                    }
                    else
                    {
                        result = ErrorCode.LoginLibraryServerFailed;
                    }
                }
                else
                {
                    //logger.Debug("Response message: " + msg);
                    result = ErrorCode.InvalidMessage;
                }
            }
            catch (Exception exception)
            {
                //logger.Error(exception.ToString());
                result = ErrorCode.ServerException;
            }

            return result;
        }

        public string Login2(string uid, string pwd, string locationCode, string vp)
        {
            string result = "发送失败，请先连接Sip2服务器！";
            if (sipclient == null || !sipclient.Connected())
                return result;
            try
            {
                SipTransaction st = sipclient.Login(uid, pwd, locationCode, vp);
                result = st.Response;
            }
            catch (Exception exception)
            {
                //logger.Error(exception.ToString());
            }
            return result;
        }

        /// <summary>
        /// 登出
        /// </summary>
        /// <param name="readerBarcode"></param>
        /// <param name="PIN"></param>
        public int EndSession(string readerBarcode, string PIN = "")
        {
            if (sipclient == null || !sipclient.Connected())
                return ErrorCode.DisConnectedWithLibraryServer;

            int result;

            try
            {
                SipTransaction st = sipclient.EndSession(readerBarcode, PIN);
                string msg = st.Response;
                if (msg.StartsWith(Sip2Common.EndPatronSessionResponse) && msg.EndsWith(Sip2Common.EndOfMessage) &&
                    CheckMessage(msg))
                {
                    result = ErrorCode.Success;
                }
                else
                {
                    result = ErrorCode.InvalidMessage;
                }
            }
            catch (Exception exception)
            {
                //logger.Error(exception.ToString());
                result = ErrorCode.ServerException;
            }

            return result;
        }

        public string BookInfomation(string itemBarcode)
        {
            string result = "发送失败，请先连接Sip2服务器！";
            if (sipclient == null || !sipclient.Connected())
                return result;
            try
            {
                SipTransaction st = sipclient.ItemInformation(itemBarcode);
                result = st.Response;
            }
            catch (Exception exception)
            {
                //logger.Error(exception.ToString);
            }
            return result;
        }

        /// <summary>
        /// 借书
        /// </summary>
        /// <param name="readerBarcode">读者条码</param>
        /// <param name="bookBarcode">书籍条码</param>
        public int BookCheckOut(string readerBarcode, string bookBarcode, ref string message)
        {
            if (sipclient == null || !sipclient.Connected())
                return ErrorCode.DisConnectedWithLibraryServer;

            int result;

            try
            {
                SipTransaction st = sipclient.ItemCheckOut(readerBarcode, "", bookBarcode);
                string msg = st.Response;
                if (!msg.StartsWith(Sip2Common.CheckoutResponse) || !msg.EndsWith(Sip2Common.EndOfMessage) ||
                    !CheckMessage(msg))
                {
                    result = ErrorCode.InvalidMessage;
                }
                else
                {
                    result = ErrorCode.Failed;
                    string[] m = msg.Split('|');
                    foreach (string s in m)
                    {
                        switch (s.Substring(0, 2))
                        {
                            case ScreenMessage:
                                message = s.Substring(2);
                                break;
                            case CheckoutResponse:
                                if (s.Substring(2, 1) == "1")
                                {
                                    result = ErrorCode.Success;
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                //logger.Error(exception.ToString());
                result = ErrorCode.ServerException;
            }

            return result;
        }

        public string BookCheckOut(string readerBarcode, string PIN, string bookBarcode)
        {
            string result = "发送失败，请先连接Sip2服务器！";
            if (sipclient == null || !sipclient.Connected())
                return result;

            try
            {
                SipTransaction st = sipclient.ItemCheckOut(readerBarcode, PIN, bookBarcode);
                result = st.Response;
            }
            catch (Exception exception)
            {
                //logger.Error(exception.ToString());
            }
            return result;
        }

        /// <summary>
        /// 还书
        /// </summary>
        /// <param name="bookBarcode">书籍条码</param>
        public int BookCheckIn(string bookBarcode, ref string message, ref string readerCode)
        {
            if (sipclient == null || !sipclient.Connected())
                return ErrorCode.DisConnectedWithLibraryServer;

            int result;

            try
            {
                SipTransaction st = sipclient.ItemCheckIn(bookBarcode);
                string msg = st.Response;
                if (!msg.StartsWith(Sip2Common.CheckinResponse) || !msg.EndsWith(Sip2Common.EndOfMessage) ||
                    !CheckMessage(msg))
                {
                    result = ErrorCode.InvalidMessage;
                }
                else
                {
                    result = ErrorCode.Failed;
                    string[] m = msg.Split('|');
                    foreach (string s in m)
                    {
                        switch (s.Substring(0, 2))
                        {
                            case ScreenMessage:
                                message = s.Substring(2);
                                break;
                            case PatronIdentifier:
                                readerCode = s.Substring(2, s.Length - 2);
                                break;
                            case CheckinResponse:
                                if (s.Substring(2, 1) == "1")
                                {
                                    result = ErrorCode.Success;
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                //logger.Error(exception.ToString());
                result = ErrorCode.ServerException;
            }

            return result;
        }

        public string BookCheckIn(string bookBarcode)
        {
            string result = "发送失败，请先连接Sip2服务器！";
            if (sipclient == null || !sipclient.Connected())
                return result;
            try
            {
                SipTransaction st = sipclient.ItemCheckIn(bookBarcode);
                result = st.Response;               
            }
            catch (Exception exception)
            {
                //logger.Error(exception.ToString());
            }
            return result;
        }

        public string ReaderInformation(string readerBarcode, string readerPIN, string type)
        {
            string result = "发送失败，请先连接Sip2服务器！";
            if (sipclient == null || !sipclient.Connected())
                return result;

            try
            {
                SipTransaction st = sipclient.PatronInformation(readerBarcode, readerPIN, string.IsNullOrEmpty(type) ? "none" : type);
                result = st.Response;
            }
            catch (Exception exception)
            {
                //logger.Error(exception.ToString());
            }

            return result;
        }

        public int ReaderStatus(string readerBarcode, string readerPIN = "")
        {
            if (sipclient == null || !sipclient.Connected())
                return ErrorCode.DisConnectedWithLibraryServer;

            int result;

            try
            {
                SipTransaction st = sipclient.PatronStatus(readerBarcode, readerPIN);
                string msg = st.Response;
                if (msg.StartsWith(Sip2Common.PatronStatusResponse) && msg.EndsWith(Sip2Common.EndOfMessage) &&
                    CheckMessage(msg))
                {
                    result = ErrorCode.Success;
                }
                else
                {
                    result = ErrorCode.InvalidMessage;
                }
            }
            catch (Exception exception)
            {
                //logger.Error(exception.ToString);
                result = ErrorCode.ServerException;
            }

            return result;
        }

        public int Renew(string readerBarcode, string readerPIN, DateTime dueTime, string bookBarcode, ref string message)
        {
            if (sipclient == null || !sipclient.Connected())
                return ErrorCode.DisConnectedWithLibraryServer;

            int result;

            try
            {
                SipTransaction st = sipclient.Renew(readerBarcode, readerPIN, dueTime, bookBarcode);
                string msg = st.Response;
                if (!msg.StartsWith(Sip2Common.RenewResponse) || !msg.EndsWith(Sip2Common.EndOfMessage) ||
                    !CheckMessage(msg))
                {
                    result = ErrorCode.InvalidMessage;
                }
                else
                {
                    result = ErrorCode.Failed;
                    string[] m = msg.Split('|');
                    foreach (string s in m)
                    {
                        switch (s.Substring(0, 2))
                        {
                            case RenewResponse:
                                if (s.Substring(2, 1) == "1")
                                {
                                    result = ErrorCode.Success;
                                }
                                break;
                            case ScreenMessage:
                                message = s.Substring(2, s.Length - 2);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                //logger.Error(exception.ToString());
                result = ErrorCode.ServerException;
            }

            return result;
        }

        public int SendHello()
        {
            if (sipclient == null || !sipclient.Connected())
                return ErrorCode.DisConnectedWithLibraryServer;

            int result;

            try
            {
                SipTransaction st = sipclient.SendHello();
                string msg = st.Response;
                result = ErrorCode.Success;
            }
            catch (Exception exception)
            {
                if (exception.InnerException.GetType() == typeof(SocketException))
                {
                    //logger.Error("Send hello to library server failed.");
                    //logger.Error(exception.ToString());
                    sipclient.Close();
                }
                result = ErrorCode.ServerException;
            }

            return result;
        }

        public int MakeAnAppointment(string readerBarcode, string bookBarcode)
        {
            if (sipclient == null || !sipclient.Connected())
                return ErrorCode.DisConnectedWithLibraryServer;

            int result;

            try
            {
                SipTransaction st = sipclient.MakeAnAppointment(readerBarcode, bookBarcode);
                string msg = st.Response;
                if (msg.StartsWith(Sip2Common.RenewAllResponse) && msg.EndsWith(Sip2Common.EndOfMessage) &&
                    CheckMessage(msg))
                {
                    result = ErrorCode.Success;
                }
                else
                {
                    result = ErrorCode.InvalidMessage;
                }
            }
            catch (Exception exception)
            {
                //logger.Error(exception.ToString());
                result = ErrorCode.ServerException;
            }

            return result;
        }


        /// <summary>
        /// 暂无此功能，获取读者排行榜中读者的书籍信息
        /// </summary>
        /// <param name="patronBarcode"></param>
        /// <returns></returns>
        public int ItemOfPatron(string patronBarcode)
        {
            if (sipclient == null || !sipclient.Connected())
                return ErrorCode.DisConnectedWithLibraryServer;

            SipTransaction st = sipclient.ItemOfPatron(patronBarcode);
            string msg = st.Response;
            if (msg.StartsWith(Sip2Common.RenewAllResponse) && msg.EndsWith(Sip2Common.EndOfMessage) &&
                CheckMessage(msg))
            {
            }
            else
            {
                return ErrorCode.InvalidMessage;
            }

            return ErrorCode.Success;
        }

        #region 未使用的功能
        //public int RenewAll(string readerBarcode, string readerPIN, string feeAcknowledged = "")
        //{
        //    if (sipclient == null || !sipclient.Connected())
        //        return ErrorCode.DisConnectedWithLibraryServer;

        //    SipTransaction st = sipclient.RenewAll(readerBarcode, readerPIN, feeAcknowledged);
        //    string msg = st.Response;
        //    if (msg.StartsWith(Sip2Common.RenewAllResponse) && msg.EndsWith(Sip2Common.EndOfMessage) &&
        //        CheckMessage(msg))
        //    {
        //    }
        //    else
        //    {
        //        return ErrorCode.InvalidMessage;
        //    }

        //    return ErrorCode.Success;
        //}

        //public int FeePaid(int feeType, int paymentType, double feeAmount, string readerBarcode, string readerPIN = "")
        //{
        //    if (sipclient == null || !sipclient.Connected())
        //        return ErrorCode.DisConnectedWithLibraryServer;

        //    SipTransaction st = sipclient.FeePaid(feeType, paymentType, feeAmount, readerBarcode, readerPIN);
        //    string msg = st.Response;
        //    if (msg.StartsWith(Sip2Common.FeePaidResponse) && msg.EndsWith(Sip2Common.EndOfMessage) &&
        //        CheckMessage(msg))
        //    {
        //    }
        //    else
        //    {
        //        return ErrorCode.InvalidMessage;
        //    }

        //    return ErrorCode.Success;
        //}

        //public int NotificationUpdate(NoticeStatus status, DateTime deliveryDate, NoticeMedium medium, NotificationType noticeType, string readerBarcode, string bookBarcode)
        //{
        //    if (sipclient == null || !sipclient.Connected())
        //        return ErrorCode.DisConnectedWithLibraryServer;

        //    SipTransaction st = sipclient.NotificationUpdate(status, deliveryDate, medium, noticeType, readerBarcode, bookBarcode);
        //    string msg = st.Response;

        //    return ErrorCode.Success;
        //}
        #endregion

        /// <summary>
        /// 比较包序号及校验和
        /// </summary>
        /// <param name="msg"></param>
        /// <returns>true:成功,false:失败</returns>
        public bool CheckMessage(string msg)
        {
            string sum = msg.Substring(msg.LastIndexOf(Sip2Common.CheckSum) + 2, 4);
            string s = msg.Substring(0, msg.LastIndexOf(Sip2Common.CheckSum) + 2);
            if (sipclient._seq != int.Parse(msg.Substring(msg.LastIndexOf(Sip2Common.SequenceNumber) + 2, 1)))
            {
                //logger.Error("包序号不匹配");
                return false;
            }
            string _sum = CalculateChecksum(s);
            if (string.Compare(sum, _sum, true) != 0)
            {
                //logger.Warn("包校验和失败(" + sum + " in packet, " + _sum + " by calc)");
            }
            return true;
        }

        /// <summary>
        /// 校验和的计算公式
        /// </summary>
        /// <param name="msg"></param>
        /// <returns>核验和的结果</returns>
        static string CalculateChecksum(string msg)
        {
            int checksum = 0;

            foreach (char c in msg)
            {
                checksum += (int)c;
            }

            checksum *= -1;
            var hex = String.Format("{0:X2}", Convert.ToUInt64(Convert.ToString(checksum, 2), 2));
            return hex.Substring(hex.Length - 4);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (sipclient != null && sipclient.Connected())
                    {
                        sipclient.Close();
                    }
                }
            }
            disposed = true;
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
