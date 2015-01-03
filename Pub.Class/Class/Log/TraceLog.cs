//------------------------------------------------------------
// All Rights Reserved , Copyright (C) 2006 , LiveXY , Ltd. 
//------------------------------------------------------------

using System;
using System.Text;
using System.Web;
using System.IO;
using System.Collections;
using System.Threading;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Diagnostics;

namespace Pub.Class {
    /// <summary>
    /// ��־������
    /// 
    /// �޸ļ�¼
    ///     2006.05.03 �汾��1.0 livexy ��������
    /// 
    /// </summary>
    public class TraceLog: ILog {
        /// <summary>
        /// д��־
        /// </summary>
        /// <param name="msg">��Ϣ</param>
        /// <param name="encoding">����</param>
        /// <returns>true/false</returns>
        public bool Write(string msg, Encoding encoding = null) {
            Trace.WriteLine("[{0}] - {1}".FormatWith(DateTime.Now.ToDateTimeFFF(), msg));
            return true;
        }
    }
}