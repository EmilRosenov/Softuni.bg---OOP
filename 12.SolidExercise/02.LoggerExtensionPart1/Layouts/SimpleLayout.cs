﻿namespace _02.LoggerExtensionPart1.Layouts
{
    public class SimpleLayout : Layout
    {
        private const string SimpleLayoutFormat = "{0} - {1} - {2}";
        public SimpleLayout() 
             : base(SimpleLayoutFormat)
        {
        }
    }
}
