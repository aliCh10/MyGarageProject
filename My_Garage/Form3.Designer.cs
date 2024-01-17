using System;
using System.Windows.Forms;

namespace My_Garage
{
    partial class Form3
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
            this.email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(147, 26);
            this.email.MaximumSize = new System.Drawing.Size(500, 200);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(200, 22);
            this.email.TabIndex = 1;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(147, 83);
            this.password.MaximumSize = new System.Drawing.Size(500, 200);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(200, 22);
            this.password.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.login.Location = new System.Drawing.Point(406, 222);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(146, 44);
            this.login.TabIndex = 10;
            this.login.Text = "Lgin";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 326);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void login_Click(object sender, EventArgs e)
        {
            {
                string enteredEmail = email.Text;
                string enteredPassword = password.Text;

                // Créez un utilisateur pour démonstration
                User demoUser = new User("test@example.com", "password123");

                // Vérifiez la connexion en utilisant la méthode de la classe User
                if (demoUser.Login(enteredEmail, enteredPassword))
                {
                    MessageBox.Show("Connexion réussie!");
                    Form1 form1 = new Form1();
                    form1.Show();

                    // Ajoutez ici le code pour rediriger l'utilisateur vers une autre page ou effectuer d'autres actions après la connexion réussie
                }
                else
                {
                    MessageBox.Show("Échec de la connexion. Vérifiez vos identifiants.");
                }
            }
        }

        #endregion

        public System.Windows.Forms.TextBox email;
        public System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button login;
    }
}