using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Web.Script.Serialization;
using Microsoft.Ajax.Utilities;
using System.Collections;
using System.Net.Mail;
using Newtonsoft.Json.Linq;

namespace WebApplication2
{
    public partial class web_form : System.Web.UI.Page
    {
        protected System.Web.UI.HtmlControls.HtmlInputFile File1;
        protected System.Web.UI.HtmlControls.HtmlInputButton Submit1;
        protected static int ID = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                /*SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AgaaNagaConnectionString"].ConnectionString);
                conn.Open();
                string checkuser = "select count(*) from AgaaNaga";
                SqlCommand cmd = new SqlCommand(checkuser, conn);
                int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                if (temp == 1)
                {
                    Response.Write("Student Already Exist");
                }
                conn.Close();*/
                /*where NAME = '" + name.Text + "'*/

            }
            
        }
        public void ClickOn(object s, EventArgs e1)
        {
            string Gender = "";
            if (Gender1.Checked)
            {
                Gender = Gender1.Text;
            }
            else
            {
                Gender = Gender2.Text;
            }
            /*try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AgaaNagaConnectionString"].ConnectionString);
                conn.Open();
                string InsertQuery = "insert into [AgaaNaga].[dbo].[Table] (NAME,DEPARTMENT,GENDER) values (@name,@dept,@gender)";
                SqlCommand cmd = new SqlCommand(InsertQuery, conn);
                //cmd.Parameters.AddWithValue("@id", Convert.ToInt32(web_form.ID));
                //web_form.ID++;
                cmd.Parameters.AddWithValue("@name", name.Text);
                cmd.Parameters.AddWithValue("@dept", Dept.Text);
                cmd.Parameters.AddWithValue("@gender", Gender);
                cmd.ExecuteNonQuery();
                Response.Write("Mudinchu Vela");
                conn.Close();
                
            } catch (Exception e) {
                Response.Write(e.Message);    
            }*/

            /*
                        using (var x = new WebContext())
                        {
                            var data = x.Forms;
                            String y = "";
                            int q = 0;
                            foreach(var item in data)
                            {
                                y+= "Hie " + item.Name + "(" + item.Gender + ")" + " of " + item.Department + " Department.\n";
                                q++;
                            }
                            showAns.Text = Convert.ToString(q);
                            Response.Write("Mudinchu Vela");
                        }*/

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["AgaaNagaConnectionString"].ConnectionString))
                {
                    connection.Open();
                    // Connection successful
                    Response.Write("Mudinchu Vela");
                }
            }
            catch (Exception ex)
            {
                // Connection failed
                Response.Write("Nakku\nreason: " + ex.Message);
            }
        }
        public async void GetJoke(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://icanhazdadjoke.com/slack");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var x = await response.Content.ReadAsStringAsync();
            
            JObject jsonObject = JObject.Parse(x);

            // Access the "text" value in the first object of the "attachments" array
            string textValue = jsonObject["attachments"][0]["text"].ToString();

            // Print the "text" value
            Response.Write(textValue);
        }
        
    }

}