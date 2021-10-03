using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleCSharpwebformappln
{
    public  class  Class4: Class3
    {

        SealedClass seal = new SealedClass();
        public int GetParentclassvariable()
        {
            int y;
            y = n;
            b = 7;
            //year = 0; readonly fields can be used in the class constructor
            return b;
            //n = 0; Compile time error as this is a constant member
        }
        public override string gg()
        {
            return "Yes";
        }
        //public override string HiddenMethod()
        //{
        //    return "Yes";
        //}
        // we cannot override a method with New Keyword
    }
}