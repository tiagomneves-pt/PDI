namespace CustomYou
{
    partial class FormEscolhaParede
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
            this.lblParede = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTinta = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnAzulejo = new System.Windows.Forms.Button();
            this.btnMosaico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Materiais";
            // 
            // lblParede
            // 
            this.lblParede.AutoSize = true;
            this.lblParede.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblParede.ForeColor = System.Drawing.Color.DimGray;
            this.lblParede.Location = new System.Drawing.Point(37, 84);
            this.lblParede.Name = "lblParede";
            this.lblParede.Size = new System.Drawing.Size(78, 25);
            this.lblParede.TabIndex = 2;
            this.lblParede.Text = "Paredes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Materiais disponíveis";
            // 
            // btnTinta
            // 
            this.btnTinta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTinta.BackgroundImage = global::CustomYou.Properties.Resources.TintaDefault_tiny;
            this.btnTinta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTinta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTinta.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnTinta.Location = new System.Drawing.Point(51, 197);
            this.btnTinta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTinta.Name = "btnTinta";
            this.btnTinta.Size = new System.Drawing.Size(126, 109);
            this.btnTinta.TabIndex = 4;
            this.btnTinta.Text = "Tinta";
            this.btnTinta.UseVisualStyleBackColor = false;
            this.btnTinta.Click += new System.EventHandler(this.btnTinta_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.BackgroundImage = global::CustomYou.Properties.Resources.PapelParede;
            this.btnPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPapel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPapel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPapel.Location = new System.Drawing.Point(208, 197);
            this.btnPapel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(126, 109);
            this.btnPapel.TabIndex = 5;
            this.btnPapel.Text = "Papel de parede";
            this.btnPapel.UseVisualStyleBackColor = true;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // btnAzulejo
            // 
            this.btnAzulejo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAzulejo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAzulejo.Image = global::CustomYou.Properties.Resources.Azulejo09;
            this.btnAzulejo.Location = new System.Drawing.Point(377, 197);
            this.btnAzulejo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAzulejo.Name = "btnAzulejo";
            this.btnAzulejo.Size = new System.Drawing.Size(126, 109);
            this.btnAzulejo.TabIndex = 8;
            this.btnAzulejo.Text = "Azulejo";
            this.btnAzulejo.UseVisualStyleBackColor = true;
            this.btnAzulejo.Click += new System.EventHandler(this.btnAzulejo_Click);
            // 
            // btnMosaico
            // 
            this.btnMosaico.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMosaico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMosaico.Image = global::CustomYou.Properties.Resources.Mosaico051;
            this.btnMosaico.Location = new System.Drawing.Point(550, 197);
            this.btnMosaico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMosaico.Name = "btnMosaico";
            this.btnMosaico.Size = new System.Drawing.Size(126, 109);
            this.btnMosaico.TabIndex = 9;
            this.btnMosaico.Text = "Mosaico";
            this.btnMosaico.UseVisualStyleBackColor = true;
            this.btnMosaico.Click += new System.EventHandler(this.btnMosaico_Click);
            // 
            // FormEscolhaParede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 453);
            this.Controls.Add(this.btnMosaico);
            this.Controls.Add(this.btnAzulejo);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.btnTinta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblParede);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormEscolhaParede";
            this.Text = "Lista de Materiais";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblParede;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTinta;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnAzulejo;
        private System.Windows.Forms.Button btnMosaico;
    }
}