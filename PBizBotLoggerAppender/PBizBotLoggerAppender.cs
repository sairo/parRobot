﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using log4net.Core;

namespace PBizBotLoggerAppender
{
    public delegate void Log(string text);

    public class PBizBotLoggerAppender : log4net.Appender.AppenderSkeleton
    {
        private Log log;

        public Log Log
        {
            get { return log; }
            set { log = value; }
        }

        public PBizBotLoggerAppender()
        {
            log = EmptyLog;
        }

        private void EmptyLog(string text) { }

        protected override void Append(LoggingEvent loggingEvent)
        {
            if (log != null)
                log(RenderLoggingEvent(loggingEvent));
        }
    }
}
