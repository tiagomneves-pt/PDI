namespace CustomYou
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.orçamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBemvindo = new System.Windows.Forms.Label();
            this.lblPendentes = new System.Windows.Forms.Label();
            this.btnAdicionarPlanta = new System.Windows.Forms.Button();
            this.picPlanta = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnProgresso = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.uti = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlanta)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orçamentosToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 28);
            // 
            // orçamentosToolStripMenuItem
            // 
            this.orçamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listasToolStripMenuItem});
            this.orçamentosToolStripMenuItem.Name = "orçamentosToolStripMenuItem";
            this.orçamentosToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.orçamentosToolStripMenuItem.Text = "Orçamentos";
            // 
            // listasToolStripMenuItem
            // 
            this.listasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçõesToolStripMenuItem});
            this.listasToolStripMenuItem.Name = "listasToolStripMenuItem";
            this.listasToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.listasToolStripMenuItem.Text = "Listas";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // lblBemvindo
            // 
            this.lblBemvindo.AutoSize = true;
            this.lblBemvindo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBemvindo.ForeColor = System.Drawing.Color.Silver;
            this.lblBemvindo.Location = new System.Drawing.Point(42, 56);
            this.lblBemvindo.Name = "lblBemvindo";
            this.lblBemvindo.Size = new System.Drawing.Size(230, 108);
            this.lblBemvindo.TabIndex = 2;
            this.lblBemvindo.Text = "Bem-vindo\r\n\r\n";
            this.lblBemvindo.Click += new System.EventHandler(this.lblBemvindo_Click);
            // 
            // lblPendentes
            // 
            this.lblPendentes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPendentes.AutoSize = true;
            this.lblPendentes.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPendentes.Location = new System.Drawing.Point(42, 164);
            this.lblPendentes.Name = "lblPendentes";
            this.lblPendentes.Size = new System.Drawing.Size(261, 31);
            this.lblPendentes.TabIndex = 4;
            this.lblPendentes.Text = "Orçamentos pendentes";
            // 
            // btnAdicionarPlanta
            // 
            this.btnAdicionarPlanta.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdicionarPlanta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdicionarPlanta.Location = new System.Drawing.Point(95, 560);
            this.btnAdicionarPlanta.Name = "btnAdicionarPlanta";
            this.btnAdicionarPlanta.Size = new System.Drawing.Size(166, 45);
            this.btnAdicionarPlanta.TabIndex = 8;
            this.btnAdicionarPlanta.Text = "Adicionar obra";
            this.btnAdicionarPlanta.UseVisualStyleBackColor = true;
            this.btnAdicionarPlanta.Click += new System.EventHandler(this.BtnAdicionarObra_Click);
            // 
            // picPlanta
            // 
            this.picPlanta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPlanta.Location = new System.Drawing.Point(560, 164);
            this.picPlanta.Name = "picPlanta";
            this.picPlanta.Size = new System.Drawing.Size(482, 332);
            this.picPlanta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlanta.TabIndex = 9;
            this.picPlanta.TabStop = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnEditar.Location = new System.Drawing.Point(668, 560);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(113, 45);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnProgresso
            // 
            this.btnProgresso.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnProgresso.Location = new System.Drawing.Point(787, 560);
            this.btnProgresso.Name = "btnProgresso";
            this.btnProgresso.Size = new System.Drawing.Size(126, 45);
            this.btnProgresso.TabIndex = 11;
            this.btnProgresso.Text = "Progreso";
            this.btnProgresso.UseVisualStyleBackColor = false;
            this.btnProgresso.Click += new System.EventHandler(this.btnProgresso_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 37;
            this.listBox1.Location = new System.Drawing.Point(42, 230);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(314, 222);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // uti
            // 
            this.uti.AutoSize = true;
            this.uti.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.uti.Location = new System.Drawing.Point(278, 56);
            this.uti.Name = "uti";
            this.uti.Size = new System.Drawing.Size(202, 54);
            this.uti.TabIndex = 13;
            this.uti.Text = "utilizador";
            this.uti.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(964, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 635);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uti);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnProgresso);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.picPlanta);
            this.Controls.Add(this.btnAdicionarPlanta);
            this.Controls.Add(this.lblPendentes);
            this.Controls.Add(this.lblBemvindo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "CustomYou";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPlanta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem orçamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.Label lblBemvindo;
        private System.Windows.Forms.Label lblPendentes;
        private System.Windows.Forms.Button btnAdicionarPlanta;
        private System.Windows.Forms.Button btnProgresso;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.PictureBox picPlanta;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label uti;
        private System.Windows.Forms.Button button1;
    }
}