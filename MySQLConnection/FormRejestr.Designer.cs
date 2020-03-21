namespace MySQLConnection
{
    partial class FormRejestr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lable1 = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.lable3 = new System.Windows.Forms.Label();
            this.lable4 = new System.Windows.Forms.Label();
            this.lable5 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lable1.Location = new System.Drawing.Point(50, 42);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(43, 15);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "Login";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lable2.Location = new System.Drawing.Point(50, 73);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(44, 15);
            this.lable2.TabIndex = 1;
            this.lable2.Text = "Hasło";
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lable3.Location = new System.Drawing.Point(42, 104);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(52, 15);
            this.lable3.TabIndex = 2;
            this.lable3.Text = "E-mail";
            // 
            // lable4
            // 
            this.lable4.AutoSize = true;
            this.lable4.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lable4.Location = new System.Drawing.Point(57, 134);
            this.lable4.Name = "lable4";
            this.lable4.Size = new System.Drawing.Size(37, 15);
            this.lable4.TabIndex = 3;
            this.lable4.Text = "Imie";
            // 
            // lable5
            // 
            this.lable5.AutoSize = true;
            this.lable5.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lable5.Location = new System.Drawing.Point(26, 163);
            this.lable5.Name = "lable5";
            this.lable5.Size = new System.Drawing.Size(68, 15);
            this.lable5.TabIndex = 4;
            this.lable5.Text = "Nazwisko";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(120, 37);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(152, 20);
            this.login.TabIndex = 5;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(120, 71);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(152, 20);
            this.password.TabIndex = 6;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(120, 102);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(152, 20);
            this.email.TabIndex = 7;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(120, 132);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(152, 20);
            this.name.TabIndex = 8;
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(120, 161);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(152, 20);
            this.surname.TabIndex = 9;
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Submit.Location = new System.Drawing.Point(74, 204);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(171, 26);
            this.Submit.TabIndex = 10;
            this.Submit.Text = "Zajerestruj";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // FormRejestr
            // 
            this.ClientSize = new System.Drawing.Size(323, 265);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.email);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.lable5);
            this.Controls.Add(this.lable4);
            this.Controls.Add(this.lable3);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.lable1);
            this.Name = "FormRejestr";
            this.Text = "Rejestracja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label lable3;
        private System.Windows.Forms.Label lable4;
        private System.Windows.Forms.Label lable5;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Button Submit;
    }
}