using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleCSharpwebformappln
{
    public class OverrideClass 
    {
        public readonly int year =8;
        public const int n = 6;
        public int b = 9;
        public OverrideClass()
        {
            //year = g;
            year = 9;
        }
        public virtual string gg()
        {
            return "Yes";
        }
        public new string HiddenMethod()
        {
            return "Yes";
        }

    }
}