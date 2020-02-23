using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Drawing;
using System.IO;
using System.Threading;

namespace Sip2Service.SIP2
{
    public static class Extensions
    {
        public static DateTime LastReceiveTime;

        public static void WriteToStream(this TcpClient clientSocket, string message)
        {
            NetworkStream serverStream = clientSocket.GetStream();
            byte[] outStream = Encoding.UTF8.GetBytes(message);
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
        }

        public static string ReadFromStream(this TcpClient clientSocket, string charset)
        {
            var encoding = Encoding.UTF8;
            try
            {
                if (!string.IsNullOrEmpty(charset))
                    encoding = Encoding.GetEncoding(charset);
            }
            catch (Exception ex)
            {
            }
            Thread.Sleep(10 * 1000);
            var networkStream = clientSocket.GetStream();
            if (networkStream.CanRead)
            {
                // Buffer to store the response bytes.
                byte[] readBuffer = new byte[clientSocket.ReceiveBufferSize];
                string fullServerReply = string.Empty;
                try
                {
                    using (var writer = new MemoryStream())
                    {
                        //do
                        //{
                        //    int numberOfBytesRead = networkStream.Read(readBuffer, 0, readBuffer.Length);
                        //    if (numberOfBytesRead <= 0)
                        //    {
                        //        break;
                        //    }
                        //    writer.Write(readBuffer, 0, numberOfBytesRead);
                        //} while (networkStream.DataAvailable);
                        //fullServerReply = encoding.GetString(writer.ToArray());

                        while (networkStream.DataAvailable)
                        {
                            int numberOfBytesRead = networkStream.Read(readBuffer, 0, readBuffer.Length);
                            if (numberOfBytesRead <= 0)
                            {
                                break;
                            }
                            writer.Write(readBuffer, 0, numberOfBytesRead);
                        }
                        fullServerReply = encoding.GetString(writer.ToArray());
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
                return fullServerReply;
            }
            return "";
        }

        public static string ReadFromStream2(this TcpClient clientSocket, string charset)
        {
            var encoding = Encoding.UTF8;
            try
            {
                if (!string.IsNullOrEmpty(charset))
                    encoding = Encoding.GetEncoding(charset);
            }
            catch (Exception ex)
            {
            }
            var networkStream = clientSocket.GetStream();
            if (networkStream.CanRead)
            {
                // Buffer to store the response bytes.
                byte[] readBuffer = new byte[clientSocket.ReceiveBufferSize];
                string fullServerReply = null;
                using (var writer = new MemoryStream())
                {
                    if (networkStream.DataAvailable)
                    {
                        int numberOfBytesRead = networkStream.Read(readBuffer, 0, readBuffer.Length);
                        //if (numberOfBytesRead <= 0)
                        //{
                        //    break;
                        //}
                        if (numberOfBytesRead > 0)
                        {
                            writer.Write(readBuffer, 0, numberOfBytesRead);
                            fullServerReply = encoding.GetString(writer.ToArray());
                        }
                    }
                    else
                    {
                        fullServerReply = "返回的数据不可读！";
                    }
                    return fullServerReply;
                }
            }
            return "";
        }

        public static string ToSipString(this DateTime dt)
        {
            return dt.ToString("yyyyMMdd    HHmmss");
        }

        public static string ToY_N(this bool b)
        {
            return b ? "Y" : "N";
        }
    }
}
