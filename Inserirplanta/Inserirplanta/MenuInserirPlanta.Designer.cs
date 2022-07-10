
namespace Inserirplanta
{
    partial class MenuInserirPlanta
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInserirPlanta));
            this.addplanta = new System.Windows.Forms.Button();
            this.btnAnalisar = new System.Windows.Forms.Button();
            this.areatotal = new System.Windows.Forms.Label();
            this.numdivisoes = new System.Windows.Forms.Label();
            this.areapdivisao = new System.Windows.Forms.Label();
            this.orcamentobase = new System.Windows.Forms.Label();
            this.btncustomizacao = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxAreaPDivisao = new System.Windows.Forms.RichTextBox();
            this.lblResDivisoesDetetadas = new System.Windows.Forms.Label();
            this.lblresAreaTotal = new System.Windows.Forms.Label();
            this.txtOrcBase = new System.Windows.Forms.TextBox();
            this.planta = new System.Windows.Forms.PictureBox();
            this.nomeconstrucao = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numAltura = new System.Windows.Forms.NumericUpDown();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.lblUtilizador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planta)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAltura)).BeginInit();
            this.SuspendLayout();
            // 
            // addplanta
            // 
            this.addplanta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addplanta.AutoSize = true;
            this.addplanta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addplanta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addplanta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addplanta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addplanta.Location = new System.Drawing.Point(105, 950);
            this.addplanta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addplanta.Name = "addplanta";
            this.addplanta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addplanta.Size = new System.Drawing.Size(205, 75);
            this.addplanta.TabIndex = 0;
            this.addplanta.Text = "Adicionar Planta";
            this.addplanta.UseVisualStyleBackColor = true;
            this.addplanta.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAnalisar
            // 
            this.btnAnalisar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnalisar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnalisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAnalisar.Location = new System.Drawing.Point(767, 950);
            this.btnAnalisar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnalisar.MinimumSize = new System.Drawing.Size(205, 75);
            this.btnAnalisar.Name = "btnAnalisar";
            this.btnAnalisar.Size = new System.Drawing.Size(205, 75);
            this.btnAnalisar.TabIndex = 4;
            this.btnAnalisar.Text = "Analisar";
            this.btnAnalisar.UseVisualStyleBackColor = true;
            this.btnAnalisar.Click += new System.EventHandler(this.bntAnalisar);
            // 
            // areatotal
            // 
            this.areatotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.areatotal.AutoSize = true;
            this.areatotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.areatotal.ForeColor = System.Drawing.SystemColors.Desktop;
            this.areatotal.Location = new System.Drawing.Point(32, 81);
            this.areatotal.Name = "areatotal";
            this.areatotal.Size = new System.Drawing.Size(139, 37);
            this.areatotal.TabIndex = 7;
            this.areatotal.Text = "Área total:";
            // 
            // numdivisoes
            // 
            this.numdivisoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numdivisoes.AutoSize = true;
            this.numdivisoes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numdivisoes.ForeColor = System.Drawing.SystemColors.Desktop;
            this.numdivisoes.Location = new System.Drawing.Point(32, 197);
            this.numdivisoes.Name = "numdivisoes";
            this.numdivisoes.Size = new System.Drawing.Size(245, 37);
            this.numdivisoes.TabIndex = 8;
            this.numdivisoes.Text = "Divisões detetadas:";
            // 
            // areapdivisao
            // 
            this.areapdivisao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.areapdivisao.AutoSize = true;
            this.areapdivisao.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.areapdivisao.ForeColor = System.Drawing.SystemColors.Desktop;
            this.areapdivisao.Location = new System.Drawing.Point(32, 272);
            this.areapdivisao.Name = "areapdivisao";
            this.areapdivisao.Size = new System.Drawing.Size(172, 37);
            this.areapdivisao.TabIndex = 9;
            this.areapdivisao.Text = "Área/divisão:";
            // 
            // orcamentobase
            // 
            this.orcamentobase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orcamentobase.AutoSize = true;
            this.orcamentobase.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orcamentobase.ForeColor = System.Drawing.SystemColors.InfoText;
            this.orcamentobase.Location = new System.Drawing.Point(1108, 851);
            this.orcamentobase.Name = "orcamentobase";
            this.orcamentobase.Size = new System.Drawing.Size(418, 38);
            this.orcamentobase.TabIndex = 10;
            this.orcamentobase.Text = "Estimativa de orçamento base:";
            // 
            // btncustomizacao
            // 
            this.btncustomizacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncustomizacao.BackColor = System.Drawing.SystemColors.Control;
            this.btncustomizacao.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncustomizacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btncustomizacao.Location = new System.Drawing.Point(1431, 950);
            this.btncustomizacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncustomizacao.Name = "btncustomizacao";
            this.btncustomizacao.Size = new System.Drawing.Size(208, 75);
            this.btncustomizacao.TabIndex = 12;
            this.btncustomizacao.Text = "Custom YOU ";
            this.btncustomizacao.UseVisualStyleBackColor = false;
            this.btncustomizacao.Click += new System.EventHandler(this.btncustomizacao_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.txtBoxAreaPDivisao);
            this.panel1.Controls.Add(this.lblResDivisoesDetetadas);
            this.panel1.Controls.Add(this.lblresAreaTotal);
            this.panel1.Controls.Add(this.areatotal);
            this.panel1.Controls.Add(this.numdivisoes);
            this.panel1.Controls.Add(this.areapdivisao);
            this.panel1.Location = new System.Drawing.Point(1108, 99);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 730);
            this.panel1.TabIndex = 13;
            // 
            // txtBoxAreaPDivisao
            // 
            this.txtBoxAreaPDivisao.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxAreaPDivisao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxAreaPDivisao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxAreaPDivisao.Location = new System.Drawing.Point(210, 278);
            this.txtBoxAreaPDivisao.Name = "txtBoxAreaPDivisao";
            this.txtBoxAreaPDivisao.Size = new System.Drawing.Size(275, 376);
            this.txtBoxAreaPDivisao.TabIndex = 16;
            this.txtBoxAreaPDivisao.Text = "";
            this.txtBoxAreaPDivisao.TextChanged += new System.EventHandler(this.txtBoxAreaPDivisao_TextChanged);
            // 
            // lblResDivisoesDetetadas
            // 
            this.lblResDivisoesDetetadas.AutoSize = true;
            this.lblResDivisoesDetetadas.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResDivisoesDetetadas.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblResDivisoesDetetadas.Location = new System.Drawing.Point(282, 204);
            this.lblResDivisoesDetetadas.Name = "lblResDivisoesDetetadas";
            this.lblResDivisoesDetetadas.Size = new System.Drawing.Size(156, 31);
            this.lblResDivisoesDetetadas.TabIndex = 14;
            this.lblResDivisoesDetetadas.Text = "asdfsadfsdfsa";
            this.lblResDivisoesDetetadas.Visible = false;
            // 
            // lblresAreaTotal
            // 
            this.lblresAreaTotal.AutoSize = true;
            this.lblresAreaTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblresAreaTotal.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblresAreaTotal.Location = new System.Drawing.Point(177, 87);
            this.lblresAreaTotal.Name = "lblresAreaTotal";
            this.lblresAreaTotal.Size = new System.Drawing.Size(130, 28);
            this.lblresAreaTotal.TabIndex = 13;
            this.lblresAreaTotal.Text = "asgdfdhethe";
            this.lblresAreaTotal.Visible = false;
            // 
            // txtOrcBase
            // 
            this.txtOrcBase.BackColor = System.Drawing.SystemColors.Control;
            this.txtOrcBase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrcBase.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtOrcBase.Location = new System.Drawing.Point(1534, 862);
            this.txtOrcBase.Name = "txtOrcBase";
            this.txtOrcBase.ReadOnly = true;
            this.txtOrcBase.Size = new System.Drawing.Size(257, 24);
            this.txtOrcBase.TabIndex = 17;
            this.txtOrcBase.TextChanged += new System.EventHandler(this.txtOrcBase_TextChanged);
            // 
            // planta
            // 
            this.planta.AccessibleName = "";
            this.planta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.planta.BackColor = System.Drawing.Color.Transparent;
            this.planta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.planta.Image = ((System.Drawing.Image)(resources.GetObject("planta.Image")));
            this.planta.Location = new System.Drawing.Point(68, 264);
            this.planta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.planta.Name = "planta";
            this.planta.Size = new System.Drawing.Size(900, 504);
            this.planta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.planta.TabIndex = 1;
            this.planta.TabStop = false;
            this.planta.Click += new System.EventHandler(this.planta_Click);
            // 
            // nomeconstrucao
            // 
            this.nomeconstrucao.BackColor = System.Drawing.SystemColors.Control;
            this.nomeconstrucao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomeconstrucao.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.nomeconstrucao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nomeconstrucao.Location = new System.Drawing.Point(50, 13);
            this.nomeconstrucao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nomeconstrucao.Name = "nomeconstrucao";
            this.nomeconstrucao.PlaceholderText = "Insira o nome da Construção...";
            this.nomeconstrucao.Size = new System.Drawing.Size(733, 62);
            this.nomeconstrucao.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.numAltura);
            this.panel2.Controls.Add(this.txtAltura);
            this.panel2.Controls.Add(this.txtMorada);
            this.panel2.Controls.Add(this.nomeconstrucao);
            this.panel2.Controls.Add(this.planta);
            this.panel2.Location = new System.Drawing.Point(37, 169);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1038, 810);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // numAltura
            // 
            this.numAltura.DecimalPlaces = 1;
            this.numAltura.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numAltura.Location = new System.Drawing.Point(336, 136);
            this.numAltura.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            65536});
            this.numAltura.Name = "numAltura";
            this.numAltura.Size = new System.Drawing.Size(83, 27);
            this.numAltura.TabIndex = 9;
            this.numAltura.Value = new decimal(new int[] {
            20,
            0,
            0,
            65536});
            // 
            // txtAltura
            // 
            this.txtAltura.BackColor = System.Drawing.SystemColors.Control;
            this.txtAltura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAltura.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAltura.Location = new System.Drawing.Point(50, 134);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.PlaceholderText = "Insira a altura da obra em metros";
            this.txtAltura.ReadOnly = true;
            this.txtAltura.Size = new System.Drawing.Size(610, 24);
            this.txtAltura.TabIndex = 8;
            // 
            // txtMorada
            // 
            this.txtMorada.BackColor = System.Drawing.SystemColors.Control;
            this.txtMorada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMorada.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMorada.Location = new System.Drawing.Point(50, 83);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.PlaceholderText = "Insira a morada";
            this.txtMorada.Size = new System.Drawing.Size(610, 31);
            this.txtMorada.TabIndex = 7;
            // 
            // lblUtilizador
            // 
            this.lblUtilizador.AutoSize = true;
            this.lblUtilizador.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUtilizador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblUtilizador.Location = new System.Drawing.Point(152, 60);
            this.lblUtilizador.Name = "lblUtilizador";
            this.lblUtilizador.Size = new System.Drawing.Size(290, 81);
            this.lblUtilizador.TabIndex = 15;
            this.lblUtilizador.Text = "Utilizador";
            this.lblUtilizador.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(37, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 81);
            this.label1.TabIndex = 16;
            this.label1.Text = "Olá";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(1785, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 37);
            this.button1.TabIndex = 17;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MenuInserirPlanta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.txtOrcBase);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUtilizador);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncustomizacao);
            this.Controls.Add(this.btnAnalisar);
            this.Controls.Add(this.orcamentobase);
            this.Controls.Add(this.addplanta);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MenuInserirPlanta";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Inserir Planta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planta)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAltura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addplanta;
        private System.Windows.Forms.Button btnAnalisar;
        private System.Windows.Forms.Label areatotal;
        private System.Windows.Forms.Label numdivisoes;
        private System.Windows.Forms.Label areapdivisao;
        private System.Windows.Forms.Label orcamentobase;
        private System.Windows.Forms.Button btncustomizacao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblresAreaTotal;
        private System.Windows.Forms.Label lblResDivisoesDetetadas;
        private System.Windows.Forms.RichTextBox txtBoxAreaPDivisao;
        private System.Windows.Forms.PictureBox planta;
        private System.Windows.Forms.TextBox nomeconstrucao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUtilizador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAreaDivisao;
        private System.Windows.Forms.TextBox txtOrcBase;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NumericUpDown numAltura;
    }
}

