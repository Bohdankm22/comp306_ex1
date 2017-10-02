using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GoogleCloudSamples
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        private void GetUser()
        {
            String userName = TextBox1.Text;
            String userLastName = TextBox2.Text;
            bool found = false;

            MySqlConnection sqlConnection1 = new MySqlConnection(DBGateway());
            MySqlCommand cmd = new MySqlCommand();
            sqlConnection1.Open();

            cmd.CommandText = "SELECT * FROM User WHERE userFirstName = '" + userName + "' and userLastName = '" + userLastName + "';";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            string userCity;
            string userPostalCode;
            string userPhoneNumber;
            string userProvince;
            bool userChosePizza;
            bool userChoseCola;
            bool userChoseBeer;
            bool userChosePasta;
            bool userChoseSalad;
            bool userChoseRavioli;
            bool userChoseDelivery;
            string userComment;
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {

                while (reader.Read())
                {
                    userCity = reader.GetString("userCity");
                    userPostalCode = reader.GetString("userPostalCode");
                    userPhoneNumber = reader.GetString("userProneNumber");
                    userProvince = reader.GetString("userProvince");
                    userChosePizza = reader.GetBoolean("userChosePizza");
                    userChoseCola = reader.GetBoolean("userChoseCola");
                    userChoseBeer = reader.GetBoolean("userChoseBeer");
                    userChosePasta = reader.GetBoolean("userChosePasta");
                    userChoseSalad = reader.GetBoolean("userChoseSalad");
                    userChoseRavioli = reader.GetBoolean("userChoseRavioli");
                    userChoseDelivery = reader.GetBoolean("userChoseDelivery");
                    userComment = reader.GetString("userComment");
                    found = true;
                }
            }
  

            sqlConnection1.Close();

            if (!found)
            {
                Type cstype = this.GetType();

                // Get a ClientScriptManager reference from the Page class.
                ClientScriptManager cs = Page.ClientScript;

                // Check to see if the startup script is already registered.
                if (!cs.IsStartupScriptRegistered(cstype, "PopupScript"))
                {
                    String cstext = "alert('User not found!');";
                    cs.RegisterStartupScript(cstype, "PopupScript", cstext, true);
                }
            } else
            {

            }
        }

        public String DBGateway()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["GoogleCloudMySqlServer"].ConnectionString;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            GetUser();
        }
    }
}