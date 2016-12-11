using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.net_web_app
{
    public partial class WebTemp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Marks_calculation var = new Marks_calculation();
            if(var.Calc(Convert.ToInt32(TextBox1.Text),TextBox2.Text)>=4)
            {
                Label6.Text = "При условии своевременной сдачи всех предметов вы выйдите на стипендию.\n Ваш средний балл по экзаменам -" + Convert.ToString(Math.Round(var.Calc(Convert.ToInt32(TextBox1.Text), TextBox2.Text),2));
            }
            else Label6.Text = "К сожалению, ваших баллов не хватает для того, чтобы выйти на стипендию. \nВаш средний балл -" + Convert.ToString(Math.Round(var.Calc(Convert.ToInt32(TextBox1.Text), TextBox2.Text), 2));
        }
    }
}