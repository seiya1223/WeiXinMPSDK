﻿/*----------------------------------------------------------------
    Copyright (C) 2017 Senparc
    
    文件名：RequestMessageBase.cs
    文件功能描述：接收到请求的消息基类
    
    
    创建标识：Senparc - 20170106
    
----------------------------------------------------------------*/

namespace Senparc.Weixin.WxOpen.Entities
{
    public interface IRequestMessageBase : Weixin.Entities.IRequestMessageBase
    {
        RequestMsgType MsgType { get; }
        string Encrypt { get; set; }
        long MsgId { get; set; }
    }

    /// <summary>
    /// 接收到请求的消息
    /// </summary>
    public class RequestMessageBase : Weixin.Entities.RequestMessageBase, IRequestMessageBase
    {
        public virtual RequestMsgType MsgType
        {
            get { return RequestMsgType.Text; }
        }

        public string Encrypt { get; set; }

        public RequestMessageBase()
        {

        }

        //public override RequestMsgType MsgType
        //{
        //    get { return RequestMsgType.Text; }
        //}

        public long MsgId { get; set; }
    }
}
