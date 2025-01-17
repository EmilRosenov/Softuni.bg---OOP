﻿
namespace _04.LoggerExtensionPart3.Appenders
{
    using System;
    using Layouts;
    using ReportLevels;

    public abstract class Appender : IAppender
    {
        protected Appender(ILayout layout)
        {
            this.Layout = layout;
        }

        public ILayout Layout { get; }

        public int AppendedMessages { get; protected set; }

        public ReportLevel ReportLevel { get; set; }

        public abstract void Append(
            DateTime dateTime,
            ReportLevel reportLevel,
            string message);

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.ReportLevel}, Messages appended: {this.AppendedMessages}";
        }

    }
}
