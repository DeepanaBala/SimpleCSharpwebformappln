using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleCSharpwebformappln
{
    public class Singleton
    {

       

            private static Singleton instance;

            private Singleton()
            {

            }

            public static Singleton GetSingleton()
            {

                if (instance == null) instance = new Singleton();
                else
            {
                Console.WriteLine("Error");
            }
                return instance;

            }

        
    }
}