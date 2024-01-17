namespace My_Garage
{
    partial class Form2
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
            this.anne = new System.Windows.Forms.TextBox();
            this.marque = new System.Windows.Forms.TextBox();
            this.couleur = new System.Windows.Forms.TextBox();
            this.Immatriculation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ajoutV = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // anne
            // 
            this.anne.Location = new System.Drawing.Point(302, 22);
            this.anne.MaximumSize = new System.Drawing.Size(500, 200);
            this.anne.Name = "anne";
            this.anne.Size = new System.Drawing.Size(200, 22);
            this.anne.TabIndex = 0;
            // 
            // marque
            // 
            this.marque.Location = new System.Drawing.Point(302, 173);
            this.marque.MaximumSize = new System.Drawing.Size(500, 200);
            this.marque.Name = "marque";
            this.marque.Size = new System.Drawing.Size(200, 22);
            this.marque.TabIndex = 1;
            // 
            // couleur
            // 
            this.couleur.Location = new System.Drawing.Point(302, 121);
            this.couleur.MaximumSize = new System.Drawing.Size(500, 200);
            this.couleur.Name = "couleur";
            this.couleur.Size = new System.Drawing.Size(200, 22);
            this.couleur.TabIndex = 2;
            // 
            // Immatriculation
            // 
            this.Immatriculation.Location = new System.Drawing.Point(302, 69);
            this.Immatriculation.MaximumSize = new System.Drawing.Size(500, 200);
            this.Immatriculation.Name = "Immatriculation";
            this.Immatriculation.Size = new System.Drawing.Size(200, 22);
            this.Immatriculation.TabIndex = 3;
            this.Immatriculation.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(0, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 65);
            this.label1.TabIndex = 4;
            // 
            // ajoutV
            // 
            this.ajoutV.Location = new System.Drawing.Point(383, 278);
            this.ajoutV.Name = "ajoutV";
            this.ajoutV.Size = new System.Drawing.Size(119, 29);
            this.ajoutV.TabIndex = 5;
            this.ajoutV.Text = "Ajouter";
            this.ajoutV.UseVisualStyleBackColor = true;
            this.ajoutV.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Immatriculation :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Marque :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Couleur :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "type :";
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(302, 218);
            this.type.MaximumSize = new System.Drawing.Size(500, 200);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(200, 22);
            this.type.TabIndex = 11;
            this.type.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Anne :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 332);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ajoutV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Immatriculation);
            this.Controls.Add(this.couleur);
            this.Controls.Add(this.marque);
            this.Controls.Add(this.anne);
            this.Name = "Form2";
            this.Text = "Nouvelle_voiture";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox anne;
        public System.Windows.Forms.TextBox marque;
        public System.Windows.Forms.TextBox couleur;
        public System.Windows.Forms.TextBox Immatriculation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ajoutV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Label label7;
    }
}