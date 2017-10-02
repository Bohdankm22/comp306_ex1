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
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
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

            string userCity = null;
            string userPostalCode = null;
            string userPhoneNumber = null;
            string userProvince = null;
            bool userChosePizza = false;
            bool userChoseCola = false;
            bool userChoseBeer = false;
            bool userChosePasta = false;
            bool userChoseSalad = false;
            bool userChoseRavioli = false;
            bool userChoseDelivery = false;
            string userComment = null;
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
            }
            else
            {
                CheckBoxList1.Items[0].Selected = userChosePizza;
                CheckBoxList1.Items[1].Selected = userChoseCola;
                CheckBoxList1.Items[2].Selected = userChoseBeer;
                CheckBoxList1.Items[3].Selected = userChosePasta;
                CheckBoxList1.Items[4].Selected = userChoseSalad;
                CheckBoxList1.Items[5].Selected = userChoseRavioli;

                DropDownList1.SelectedValue = userProvince;

                if (userChoseDelivery)
                {
                    RadioButton1.Checked = true;
                }
                else
                {
                    RadioButton2.Checked = true;
                }
                if (userCity != null)
                {
                    TextBox3.Text = userCity;
                }
                if (userPostalCode != null)
                {
                    TextBox4.Text = userPostalCode;
                }
                if (userPhoneNumber != null)
                {
                    TextBox5.Text = userPhoneNumber;
                }
                if (userComment != null)
                {
                    TextBox6.Text = userComment;
                }

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

        protected void Button1_Click(object sender, EventArgs e)
        {
            SaveUser();
        }

        private void SaveUser()
        {
            if (CheckUserExist(TextBox1.Text, TextBox2.Text))
            {
                Type cstype = this.GetType();

                // Get a ClientScriptManager reference from the Page class.
                ClientScriptManager cs = Page.ClientScript;

                // Check to see if the startup script is already registered.
                if (!cs.IsStartupScriptRegistered(cstype, "PopupScript"))
                {
                    String cstext = "alert('User could not be stored as already exists!');";
                    cs.RegisterStartupScript(cstype, "PopupScript", cstext, true);
                }
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(DBGateway()))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"INSERT INTO User(userFirstName, userLastName, userCity, userPostalCode, userProneNumber, userProvince, " +
                        "userChosePizza, userChoseCola, userChoseBeer, userChosePasta, userChoseSalad, userChoseRavioli, userChoseDelivery, userComment) " +
                        " VALUES(@fn,@ln,@city, @postCode, @phNumb, @prov, @pizza, @cola, @beer, @pasta, @salad, @ravi, @delivery, @comment)";

                    cmd.Parameters.AddWithValue("@fn", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@ln", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@city", TextBox3.Text);
                    cmd.Parameters.AddWithValue("@postCode", TextBox4.Text);
                    cmd.Parameters.AddWithValue("@phNumb", TextBox5.Text);
                    cmd.Parameters.AddWithValue("@prov", DropDownList1.SelectedValue);
                    cmd.Parameters.AddWithValue("@pizza", CheckBoxList1.Items[0].Selected);
                    cmd.Parameters.AddWithValue("@cola", CheckBoxList1.Items[1].Selected);
                    cmd.Parameters.AddWithValue("@beer", CheckBoxList1.Items[2].Selected);
                    cmd.Parameters.AddWithValue("@pasta", CheckBoxList1.Items[3].Selected);
                    cmd.Parameters.AddWithValue("@salad", CheckBoxList1.Items[4].Selected);
                    cmd.Parameters.AddWithValue("@ravi", CheckBoxList1.Items[5].Selected);
                    if (RadioButton1.Checked)
                    {
                        cmd.Parameters.AddWithValue("@delivery", true);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@delivery", false);
                    }

                    cmd.Parameters.AddWithValue("@comment", TextBox6.Text);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (SqlException e)
                    {

                    }
                    ClearFields();
                    

                }
            }
        }

        private void ClearFields()
        {
            TextBox1.Text = TextBox2.Text = TextBox3.Text = TextBox4.Text = TextBox5.Text = TextBox6.Text = "";
            for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                CheckBoxList1.Items[i].Selected = false;
            }
            DropDownList1.SelectedValue = "Ontario";
        }

        private bool CheckUserExist(String userName, String userLastName)
        {
            bool found = false;
            MySqlConnection sqlConnection1 = new MySqlConnection(DBGateway());
            MySqlCommand cmd = new MySqlCommand();
            sqlConnection1.Open();

            cmd.CommandText = "SELECT * FROM User WHERE userFirstName = '" + userName + "' and userLastName = '" + userLastName + "';";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {

                while (reader.Read())
                {
                    found = true;
                }
            }
            sqlConnection1.Close();

            return found;
        }
    }
}