using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace SimpleCSharpwebformappln
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> ts = new List<string> { "Go", "fgf", "ind" };
            List<int> i = new List<int> { 1, 1, 4, 5, 6, 4 };
            int dup = 1;
            
            List<ClassA> CustomerData = new List<ClassA>() { new ClassA() { StudentID = 1, StudentName = "123" } };
            string Convertsd = Convert.ToString(dup);
            string Converts = dup.ToString();
            //
            foreach (string z in ts)
            {
                bool isnumeric = int.TryParse(z, out int b);
                //string b = typeof(a);
                if (!isnumeric)
                {
                    Response.Write(z);
                }
            }
            //partial class
            ClassA obj = new ClassA();
            // int g = obj.a;
            string a = ts.Contains("Go").ToString();
            List<int> Top5 = new List<int>(i.Where(p => p > 5).Take(5).ToList());
            //Select
            // List<int> Select5 =  i.Select(x => x == 8);
            //IEnumerable<DataRow> = i.DataTable.AsEnumerable()
            //First
            int First = i.First(x => i.Contains(1));
            //throwing error since 0 is not in the list
            //int Firstnotinlist = i.First(x => i.Contains(0));

            int FirstorDefaultlist = i.FirstOrDefault(x => i.Contains(0));
            //Orderby
            List<ClassA> Orerby = CustomerData.OrderBy(x => x.StudentID).ToList();
            //
            int FirstorDefault = i.FirstOrDefault(x => x == 2);

            IEnumerable<ClassA> testienum = CustomerData.Where(p => p.StudentID == 1);

            /*
             * 
             * 
             * 
             * */
            string Sentencewithdates = "The UN was established on 24-10-1945";
            string newstring = "";
            for (int ia = 0; ia < Sentencewithdates.Length; ia++)
            { 
                if (char.IsDigit(Sentencewithdates[ia]))
                {
                    newstring +=  Sentencewithdates[ia];
                }
                // if we found - then clear the str2
                if (Sentencewithdates[ia] == '-')
                {
                    newstring = "";
                }

            }
            if (newstring.Length > 1)
            {
                for (int dis = 0; dis <= newstring.Length; dis++)
                {
                    if (newstring.Length == 4)
                    {
                        string year = newstring;
                        Response.Write(year);
                    }
                    //if(newstring.Contains("-"))
                    //    {
                    //        newstring.Replace("-", " ");
                    //    }
                    //}

                }
            }
            Class4 cls4 = new Class4();
            cls4.gg();
            //Singleton
            Singleton.GetSingleton();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}