using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySQLConnection
{
    public partial class FormRejestr : Form
    {
        private const string MySQLConnection = "datasource=127.0.0.1;port=3306;username=root;password=;database=gralogiczna";
        private LoginForm f1;

        public FormRejestr()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string slogin = login.Text;
            string spassword = password.Text;
            string semail = email.Text;
            string sname = name.Text;
            string ssurname = surname.Text;
            string query;

            if (slogin == "" || spassword == "" || semail == "" || sname == "" || ssurname == "")
            {
                MessageBox.Show("Musisz wypelnic wszystkie pola");
                return;
            }else if (!bEmailCorrection(semail))
            {
                MessageBox.Show("Podales nipoprawny adres e-mial!");
                return;
            }

            MySqlDataReader myReader;
            myReader = null;

            try
            {
                query = "Select * from uzytkownicy where login = \"" + slogin + "\"";

                myReaderexecute(ref myReader, query);

                if (myReader.HasRows)
                {
                    MessageBox.Show("Login " + slogin + " juz istnieje.");
                    myReaderClose(ref myReader);
                    return;
                }

                query = "Select * from uzytkownicy where Email = \"" + semail + "\"";

                myReaderexecute(ref myReader, query);

                if (myReader.HasRows)
                {
                    MessageBox.Show("E-mail " + email + " istnieje juz w naszej bazie.");
                    myReaderClose(ref myReader);
                    return;
                }

                query = "Insert into uzytkownicy(Login, Haslo, Imie, Nazwisko, Email) values (\"" + slogin + "\", \"" + spassword + "\", \"" + sname + "\", \"" + ssurname + "\", \"" + semail + "\")";

                myReaderexecute(ref myReader, query);

                MessageBox.Show("Gratulujemy zalożenia konta!");
                f1.SetLogin(slogin);
                f1.SetPassword(spassword);

                LoginPanelOpen();
            }
            catch (Exception er)
            {
                MessageBox.Show("Query error: " + er.Message);
            }
        }
        private void myReaderexecute(ref MySqlDataReader myReader, string squery)
        {
            

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnection);

            MySqlCommand commandDatabase;

            commandDatabase = new MySqlCommand(squery, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            databaseConnection.Open();

            myReader = commandDatabase.ExecuteReader();

            commandDatabase = null;

        }
        private void myReaderClose(ref MySqlDataReader myReader)
        {
            myReader.Close();
            myReader = null;
        }
        public void SetForm1(LoginForm f1)
        {
            this.f1 = f1;
        }
        private void FormRejestr_Close(Object sender, EventArgs e)
        {
            LoginPanelOpen();
        }
        private void LoginPanelOpen()
        {
            f1.Show();
            this.Hide();
        }
        private bool bEmailCorrection(string semail)
        {
            Regex r = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
             return r.IsMatch(semail);
        }
    }
    
}
