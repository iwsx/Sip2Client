namespace Sip2Service.Model
{
    //public class Sip2Info
    //{
    //    /// <summary>
    //    /// sip2服务器地址
    //    /// </summary>
    //    public string Sip2Host { get; set; }
    //    /// <summary>
    //    /// sip2用户名
    //    /// </summary>
    //    public string UserName { get; set; }
    //    /// <summary>
    //    /// sip2密码
    //    /// </summary>
    //    public string Password { get; set; }
    //}

    public class Sip2Model
    {
        public int id { get; set; }
        public string Sip2Name { get; set; }
        public string IP { get; set; }
        public string Port { get; set; }
        public string AO { get; set; }
        public string AP { get; set; }
        public string Charset { get; set; }
        public string Uid { get; set; }
        public string Pwd { get; set; }
        public string VP { get; set; }
        public string LocationCode { get; set; }
        public string ReaderCode { get; set; }
        public string PIN { get; set; }
        public string BookCode { get; set; }
    }
}
