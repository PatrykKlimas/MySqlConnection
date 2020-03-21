using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLConnection
{
    public partial class MainForm : Form
    {

        private string sname;
        private string sSurname;
        private string semail;
        private LoginForm f1;
        public MainForm()
        {
            InitializeComponent();
        }
        public void SetName(string sname)
        {
            this.sname = sname;
        }
        public void SetNaziwsko(string sSurname)
        {
            this.sSurname = sSurname;
        }
        public void SetEmail(string semail)
        {
            this.semail = semail;
        }
        public void SetForm1(LoginForm f1)
        {
            this.f1 = f1;
        }
        public void ChangeLables()
        {
            Imie.Text = sname;
            Nazwisko.Text = sSurname;
            email.Text = semail;
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do zobaczenia " + sname + "!");
            f1.SetPassword();
            LoginPanelOpen();
        }
        private void Form2_Close(Object sender, EventArgs e)
        {
            LoginPanelOpen();
        }
        private void LoginPanelOpen()
        {
            f1.Show();
            this.Hide();
        }
    }
}
