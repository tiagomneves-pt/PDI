
namespace CustomYou
{
    partial class Entrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrar));
            this.btnLogin = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.registo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(623, 508);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(123, 43);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(511, 56);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(311, 327);
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // email
            // 
            this.email.ForeColor = System.Drawing.Color.Silver;
            this.email.Location = new System.Drawing.Point(511, 429);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(333, 27);
            this.email.TabIndex = 2;
            this.email.Text = "email";
            this.email.MouseClick += new System.Windows.Forms.MouseEventHandler(this.email_MouseClick);
            // 
            // password
            // 
            this.password.ForeColor = System.Drawing.Color.Silver;
            this.password.Location = new System.Drawing.Point(511, 472);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(333, 27);
            this.password.TabIndex = 3;
            this.password.Text = "password";
            this.password.UseSystemPasswordChar = true;
            this.password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.password_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(511, 592);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ainda não tem conta? ";
            // 
            // registo
            // 
            this.registo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.registo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.registo.Location = new System.Drawing.Point(707, 584);
            this.registo.Name = "registo";
            this.registo.Size = new System.Drawing.Size(137, 35);
            this.registo.TabIndex = 5;
            this.registo.Text = "Criar conta";
            this.registo.UseVisualStyleBackColor = false;
            this.registo.Click += new System.EventHandler(this.registo_Click);
            // 
            // Entrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 659);
            this.Controls.Add(this.registo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnLogin);
            this.Name = "Entrar";
            this.Text = "Entrar";
            this.Load += new System.EventHandler(this.Entrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registo;
    }
}