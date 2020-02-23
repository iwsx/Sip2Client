using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sip2Service.Model
{
    public class ErrorCode
    {
        public const int Success = 0;
        public const int Failed = 10001;
        public const int InvalidMessage = 10003;
        public const int ServerException = 10017;
        public const int InvalidParameter = 10018;
        public const int RandomCodeRepeated = 10019;  //随机码重复
        public const int VerifyFailed = 10020;        //校验失败
        public const int DeviceUnregister = 10021;    //设备未注册
        public const int TokenExpired = 10022;        // token已过期
        public const int InvalidToken = 10023;        //token无效
        public const int RecordIsExisted = 10024;      //记录已存在
        public const int NotFoundToken = 10025;        //请求数据中未发现Token
        public const int UserNameNotExist = 10026;     //用户名不存在
        public const int UserNameIsExist = 10027;      //用户名已存在
        public const int PasswordIsWrong = 10028;      //密码错误
        public const int SecurityCodeIsWrong = 10029;   //动态验证码错误
        public const int NotFoundUId = 10030;        //请求数据中未发现UID
        public const int VerifyTokenFailed = 10031;   //校验Token失败，服务器端未获取到Token，可能由于用户未登录或者服务器端数据库故障导致
        public const int UserIDExist = 10032;   //用户名已存在
        public const int PhoneExist = 10033;   //手机号已存在
        public const int NicknameExist = 10034; //昵称已存在
        public const int EmailExist = 10035;   //邮箱地址已存在
        public const int PasswordIsEmpty = 10036;   //密码为空
        public const int RecordNotExist = 10037; //记录不存在
        public const int UserIsDeleted = 10038; //用户已被删除
        public const int FunctionNotImplemented = 10039; //功能尚未实现
        public const int BindBookOkButNotUpdate = 10040; //书籍绑定成功但是与图书馆数据同步未成功,可能导致数据信息不完整
        public const int UpdateBookFromLibraryFailed = 10041; //图书信息更新失败
        public const int CanNotGetPlainPassword = 10042; //无法获取有效的密码信息
        public const int ActiveMQServerException = 10043; //连接ActiveMQ服务器出现异常
        public const int UnsupportedMediaType = 10044;  //不支持的媒体类型
        public const int UnsupportedDeviceType = 10045;  //不支持的设备类型
        public const int DistrictDeficiency = 10046; //未找到该区域
        public const int ResourceNotExist = 10047;  //资源不存在
        public const int ResourceUnAudited = 10048;  //资源未审核
        public const int GetReaderInfoFailedFromSIP2Server = 10049;  //无法从SIP2服务器获取读者信息
        public const int DisconnectedWithSIP2Server = 10050;  //无法连接SIP2服务器
        public const int PreborrowCountReachedLimit = 10051;  //预借数量已达上限
        public const int BookHasBeenPreborrowed = 10052;  //该书已被预约
        public const int OverMaxSortNumeber = 10053; //序号超过当前分区数量
        public const int RepeatSortNumeber = 10054; //序号重复
        public const int ServiceIsRunning = 10055; //服务正在运行
        public const int StartServiceFailed = 10056; //启动服务失败
        public const int RenewFailed = 10057;//续借失败
        public const int AccountNoExist = 10058;//E卡通账户不存在
        public const int AccountUnused = 10059;//卡无效
        public const int UrlNoExist = 10060;//网络资源Url不存在
        public const int ScheduleNoExist = 10061;//计划任务不存在
        public const int MouldUsed = 10062;//该模板已被使用，无法增加或删除行,以及删除该模板
        public const int CourseOrderNoExist = 10063;//课表模板不存在
        public const int IsAdmin = 10064;//是管理员
        public const int IsReader = 10065;//是读者


        public const int DisConnectedWithLibraryServer = 20001;
        public const int LoginLibraryServerFailed = 20002;
    }
}
