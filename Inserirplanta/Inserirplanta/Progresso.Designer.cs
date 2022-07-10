namespace CustomYou
{
    partial class FormProgresso
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
            this.lblNomeObra = new System.Windows.Forms.Label();
            this.progressoDivisao = new System.Windows.Forms.ProgressBar();
            this.listDivisoes = new System.Windows.Forms.ListBox();
            this.progressoObra = new System.Windows.Forms.ProgressBar();
            this.planta_progresso = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.planta_progresso)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeObra
            // 
            this.lblNomeObra.AutoSize = true;
            this.lblNomeObra.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblNomeObra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNomeObra.Location = new System.Drawing.Point(31, 48);
            this.lblNomeObra.Name = "lblNomeObra";
            this.lblNomeObra.Size = new System.Drawing.Size(272, 45);
            this.lblNomeObra.TabIndex = 0;
            this.lblNomeObra.Text = "[Nome da Obra]";
            this.lblNomeObra.Click += new System.EventHandler(this.lblNomeObra_Click);
            // 
            // progressoDivisao
            // 
            this.progressoDivisao.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.progressoDivisao.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressoDivisao.Location = new System.Drawing.Point(352, 404);
            this.progressoDivisao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressoDivisao.Maximum = 3;
            this.progressoDivisao.Name = "progressoDivisao";
            this.progressoDivisao.Size = new System.Drawing.Size(498, 31);
            this.progressoDivisao.TabIndex = 8;
            this.progressoDivisao.Click += new System.EventHandler(this.progressoDivisao_Click);
            // 
            // listDivisoes
            // 
            this.listDivisoes.BackColor = System.Drawing.SystemColors.Control;
            this.listDivisoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listDivisoes.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.listDivisoes.FormattingEnabled = true;
            this.listDivisoes.ItemHeight = 25;
            this.listDivisoes.Location = new System.Drawing.Point(31, 144);
            this.listDivisoes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listDivisoes.Name = "listDivisoes";
            this.listDivisoes.Size = new System.Drawing.Size(227, 325);
            this.listDivisoes.TabIndex = 9;
            this.listDivisoes.SelectedIndexChanged += new System.EventHandler(this.listDivisoes_SelectedIndexChanged);
            // 
            // progressoObra
            // 
            this.progressoObra.ForeColor = System.Drawing.Color.Goldenrod;
            this.progressoObra.Location = new System.Drawing.Point(352, 456);
            this.progressoObra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressoObra.Name = "progressoObra";
            this.progressoObra.Size = new System.Drawing.Size(498, 31);
            this.progressoObra.TabIndex = 10;
            this.progressoObra.Click += new System.EventHandler(this.progressoObra_Click);
            // 
            // planta_progresso
            // 
            this.planta_progresso.Location = new System.Drawing.Point(352, 96);
            this.planta_progresso.Name = "planta_progresso";
            this.planta_progresso.Size = new System.Drawing.Size(498, 272);
            this.planta_progresso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.planta_progresso.TabIndex = 11;
            this.planta_progresso.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(179, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Progresso da divisão";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(179, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Progresso da obra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(518, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 14;
            // 
            // FormProgresso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 527);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.planta_progresso);
            this.Controls.Add(this.progressoObra);
            this.Controls.Add(this.listDivisoes);
            this.Controls.Add(this.progressoDivisao);
            this.Controls.Add(this.lblNomeObra);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormProgresso";
            this.Text = "Progresso da Obra";
            this.Load += new System.EventHandler(this.FormProgresso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.planta_progresso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeObra;
        private System.Windows.Forms.ProgressBar progressoDivisao;
        private System.Windows.Forms.ListBox listDivisoes;
        private System.Windows.Forms.ProgressBar progressoObra;
        private System.Windows.Forms.PictureBox planta_progresso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}