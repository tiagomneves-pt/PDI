namespace CustomYou
{
    partial class Registo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtmorada = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtpasswordconfirm = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(171, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(171, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Morada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(171, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(171, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(171, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirmar Password";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(431, 81);
            this.txtemail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(283, 27);
            this.txtemail.TabIndex = 5;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(431, 151);
            this.txtnome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(283, 27);
            this.txtnome.TabIndex = 6;
            // 
            // txtmorada
            // 
            this.txtmorada.Location = new System.Drawing.Point(431, 211);
            this.txtmorada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmorada.Name = "txtmorada";
            this.txtmorada.Size = new System.Drawing.Size(283, 27);
            this.txtmorada.TabIndex = 7;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(431, 273);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(283, 27);
            this.txtpassword.TabIndex = 8;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // txtpasswordconfirm
            // 
            this.txtpasswordconfirm.Location = new System.Drawing.Point(431, 348);
            this.txtpasswordconfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpasswordconfirm.Name = "txtpasswordconfirm";
            this.txtpasswordconfirm.Size = new System.Drawing.Size(283, 27);
            this.txtpasswordconfirm.TabIndex = 9;
            this.txtpasswordconfirm.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 461);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "Criar conta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Registo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtpasswordconfirm);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtmorada);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Registo";
            this.Text = "Registo";
            this.Load += new System.EventHandler(this.Registo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtmorada;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtpasswordconfirm;
        private System.Windows.Forms.Button button1;
    }
}