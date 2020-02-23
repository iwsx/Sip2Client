### 3M图书馆Sip2标准测试小工具

------

#### 1. 简介

这是本人自己开发的一款基于3M图书馆Sip2协议的测试小工具，为了解决工作遇到的测试问题，市面上找不到好用的软件，那就自己开发一个吧。

本软件使用C#，winform框架开发，sqlite保存数据。

这是成品的样子：

![成品](http://image.saiwoniu.com/20200223100727.png)

#### 2.功能介绍

1）选项：

- 可以配置保存工作用到的Sip2连接详情【包括ip，端口，AO，AP，读者证号，图书条码等】
- 选择Sip2服务器：用于选择之前保存的Sip2服务器配置

![选项](http://image.saiwoniu.com/20200223095600.png)

2）配置Sip2Info，如下：

![配置Sip2Info](http://image.saiwoniu.com/20200223095615.png)

3）选择Sip2服务器，如下：

![选择Sip2服务器](http://image.saiwoniu.com/20200223095727.png)

#### 3.使用步骤

1）连接服务器

填写IP，端口，AO，管理员账号，密码等来进行登录，还可以设置字符集

![](http://image.saiwoniu.com/20200223101700.png)

2）查询读者信息

![查询读者信息](http://image.saiwoniu.com/20200223095208.png)

3）查询图书信息

![查询图书信息](http://image.saiwoniu.com/20200223095251.png)

4）借书

![借书](http://image.saiwoniu.com/20200223095318.png)

5）还书

![还书](http://image.saiwoniu.com/20200223095332.png)

6）清空日志

![清空日志](http://image.saiwoniu.com/20200223100654.png)