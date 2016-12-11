using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Asp.net_web_app
{
    /// <summary>
    /// Сводное описание для Consumption_calc
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class Marks_calculation : System.Web.Services.WebService
    {

        [WebMethod]
        public double Calc(int Num_of_marks, string Marks)
        {
            int summ = 0;
            for(int i = 0;i<Num_of_marks;i++)
            {
                int j = 0;
                for(;j<Marks.Length;j++)
                {
                    if (Marks.ElementAt(j).Equals(' ')) break;
                }
                summ += Convert.ToInt32(Marks.Substring(0, j));
                if(j < Marks.Length)
                Marks = Marks.Substring(j + 1, Marks.Length - j - 1);
            }

            return (double)summ/Num_of_marks;
        }
      
    }
}
