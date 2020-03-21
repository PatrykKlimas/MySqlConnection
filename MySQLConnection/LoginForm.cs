using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySQLConnection
{
    

    public partial class LoginForm : Form
    {
        private string slogin;
        private string spassword;
        MainForm f2 = null;
        FormRejestr fr = null;
        public LoginForm()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            LogIn();
        }
        private void LogIn()
        {
            slogin = textBox1.Text;
            spassword = textBox2.Text;

            string query = "Select * from uzytkownicy where Login=\"" + slogin + "\" and Haslo=\"" + spassword + "\"";

            if(slogin =="" || spassword =="")
            {
                MessageBox.Show("Wpisz login i haslo");
                return;
            }

            string MySQLConnection = "datasource=127.0.0.1;port=3306;username=root;password=;database=gralogiczna";

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnection);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            
            try
            {

                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                if (myReader.HasRows)
                {
                    
                    myReader.Read();
                    MessageBox.Show("Witaj " + myReader.GetString(2) + "!");

                    if (myReader.GetString(0) != "") {
                        f2  = new MainForm();
                        f2.SetName(myReader.GetString(2));
                        f2.SetNaziwsko(myReader.GetString(3));
                        f2.SetEmail(myReader.GetString(4));
                        f2.SetForm1(this);
                        f2.ChangeLables();
                        f2.Show();
                        this.Hide();
                    }   
                }
                else
                {
                    MessageBox.Show("Niepoprawny login lub haslo!");
                }
                
            }catch(Exception e)
            {
                MessageBox.Show("Problem z polaczeniem: " + e.Message);
            }
        }
        private void Form1_Shown(Object sender, EventArgs e)
        {
            f2 = null;
            fr = null;
        }
        public void SetPassword( string pass="")
        {
            this.spassword = pass;
            textBox2.Text =pass;
        }
        public void SetLogin(string login = "")
        {
            this.slogin = login;
            textBox1.Text = login;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fr = new FormRejestr();
            fr.SetForm1(this);
            fr.Show();
            this.Hide();
        }
    }
}
