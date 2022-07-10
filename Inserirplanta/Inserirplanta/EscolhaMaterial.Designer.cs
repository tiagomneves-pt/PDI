namespace CustomYou
{
    partial class FormEscolhaMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEscolhaMaterial));
            this.lblNomeObra = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDivisao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOrcamentoTotal = new System.Windows.Forms.Label();
            this.btnPiso = new System.Windows.Forms.Button();
            this.btnParedes = new System.Windows.Forms.Button();
            this.btnTeto = new System.Windows.Forms.Button();
            this.lblMetrosQuadrados = new System.Windows.Forms.Label();
            this.lblCustoPiso = new System.Windows.Forms.Label();
            this.lblCustoParedes = new System.Windows.Forms.Label();
            this.lblCustoTeto = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.orcDiv = new System.Windows.Forms.Label();
            this.guardar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeObra
            // 
            this.lblNomeObra.AutoSize = true;
            this.lblNomeObra.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblNomeObra.Location = new System.Drawing.Point(56, 103);
            this.lblNomeObra.Name = "lblNomeObra";
            this.lblNomeObra.Size = new System.Drawing.Size(224, 38);
            this.lblNomeObra.TabIndex = 0;
            this.lblNomeObra.Text = "[Nome da Obra]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(521, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 59);
            this.label2.TabIndex = 1;
            this.label2.Text = "Custom YOU!";
            // 
            // cbDivisao
            // 
            this.cbDivisao.BackColor = System.Drawing.SystemColors.Control;
            this.cbDivisao.ForeColor = System.Drawing.Color.DimGray;
            this.cbDivisao.FormattingEnabled = true;
            this.cbDivisao.Location = new System.Drawing.Point(521, 195);
            this.cbDivisao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDivisao.Name = "cbDivisao";
            this.cbDivisao.Size = new System.Drawing.Size(177, 28);
            this.cbDivisao.TabIndex = 2;
            this.cbDivisao.Text = "Selecione a divisão";
            this.cbDivisao.SelectedIndexChanged += new System.EventHandler(this.cbDivisao_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(521, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 50);
            this.label3.TabIndex = 4;
            this.label3.Text = "Materiais";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 195);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 355);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(56, 614);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Orçamento total:";
            // 
            // lblOrcamentoTotal
            // 
            this.lblOrcamentoTotal.AutoSize = true;
            this.lblOrcamentoTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrcamentoTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOrcamentoTotal.Location = new System.Drawing.Point(219, 611);
            this.lblOrcamentoTotal.Name = "lblOrcamentoTotal";
            this.lblOrcamentoTotal.Size = new System.Drawing.Size(71, 28);
            this.lblOrcamentoTotal.TabIndex = 7;
            this.lblOrcamentoTotal.Text = "0.00 €";
            this.lblOrcamentoTotal.Click += new System.EventHandler(this.lblOrcamentoTotal_Click);
            // 
            // btnPiso
            // 
            this.btnPiso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPiso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPiso.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPiso.Location = new System.Drawing.Point(563, 404);
            this.btnPiso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPiso.Name = "btnPiso";
            this.btnPiso.Size = new System.Drawing.Size(115, 109);
            this.btnPiso.TabIndex = 8;
            this.btnPiso.Text = "Piso";
            this.btnPiso.UseVisualStyleBackColor = true;
            this.btnPiso.Click += new System.EventHandler(this.btnPiso_Click);
            // 
            // btnParedes
            // 
            this.btnParedes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnParedes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnParedes.Location = new System.Drawing.Point(702, 404);
            this.btnParedes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnParedes.Name = "btnParedes";
            this.btnParedes.Size = new System.Drawing.Size(115, 109);
            this.btnParedes.TabIndex = 9;
            this.btnParedes.Text = "Paredes";
            this.btnParedes.UseVisualStyleBackColor = true;
            this.btnParedes.Click += new System.EventHandler(this.btnParedes_Click);
            // 
            // btnTeto
            // 
            this.btnTeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTeto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTeto.Location = new System.Drawing.Point(842, 404);
            this.btnTeto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTeto.Name = "btnTeto";
            this.btnTeto.Size = new System.Drawing.Size(115, 109);
            this.btnTeto.TabIndex = 10;
            this.btnTeto.Text = "Teto";
            this.btnTeto.UseVisualStyleBackColor = true;
            this.btnTeto.Click += new System.EventHandler(this.btnTeto_Click);
            // 
            // lblMetrosQuadrados
            // 
            this.lblMetrosQuadrados.AutoSize = true;
            this.lblMetrosQuadrados.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetrosQuadrados.Location = new System.Drawing.Point(731, 203);
            this.lblMetrosQuadrados.Name = "lblMetrosQuadrados";
            this.lblMetrosQuadrados.Size = new System.Drawing.Size(57, 20);
            this.lblMetrosQuadrados.TabIndex = 11;
            this.lblMetrosQuadrados.Text = "--------";
            // 
            // lblCustoPiso
            // 
            this.lblCustoPiso.AutoSize = true;
            this.lblCustoPiso.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCustoPiso.Location = new System.Drawing.Point(596, 517);
            this.lblCustoPiso.Name = "lblCustoPiso";
            this.lblCustoPiso.Size = new System.Drawing.Size(45, 20);
            this.lblCustoPiso.TabIndex = 12;
            this.lblCustoPiso.Text = "0,00€";
            this.lblCustoPiso.TextChanged += new System.EventHandler(this.lblCustoPiso_TextChanged);
            // 
            // lblCustoParedes
            // 
            this.lblCustoParedes.AutoSize = true;
            this.lblCustoParedes.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCustoParedes.Location = new System.Drawing.Point(739, 517);
            this.lblCustoParedes.Name = "lblCustoParedes";
            this.lblCustoParedes.Size = new System.Drawing.Size(45, 20);
            this.lblCustoParedes.TabIndex = 13;
            this.lblCustoParedes.Text = "0,00€";
            this.lblCustoParedes.TextChanged += new System.EventHandler(this.lblCustoParedes_TextChanged);
            // 
            // lblCustoTeto
            // 
            this.lblCustoTeto.AutoSize = true;
            this.lblCustoTeto.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCustoTeto.Location = new System.Drawing.Point(885, 517);
            this.lblCustoTeto.Name = "lblCustoTeto";
            this.lblCustoTeto.Size = new System.Drawing.Size(45, 20);
            this.lblCustoTeto.TabIndex = 14;
            this.lblCustoTeto.Text = "0,00€";
            this.lblCustoTeto.TextChanged += new System.EventHandler(this.lblCustoTeto_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(863, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 38);
            this.button2.TabIndex = 16;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // orcDiv
            // 
            this.orcDiv.AutoSize = true;
            this.orcDiv.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.orcDiv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orcDiv.Location = new System.Drawing.Point(657, 237);
            this.orcDiv.Name = "orcDiv";
            this.orcDiv.Size = new System.Drawing.Size(66, 23);
            this.orcDiv.TabIndex = 17;
            this.orcDiv.Text = "--------";
            // 
            // guardar
            // 
            this.guardar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guardar.Location = new System.Drawing.Point(842, 614);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(115, 29);
            this.guardar.TabIndex = 18;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(521, 289);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Insira o nome da divisão";
            this.textBox1.Size = new System.Drawing.Size(326, 27);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(521, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Valor da divisão:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(739, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "€";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(805, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "m²";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // FormEscolhaMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 679);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.orcDiv);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblCustoTeto);
            this.Controls.Add(this.lblCustoParedes);
            this.Controls.Add(this.lblCustoPiso);
            this.Controls.Add(this.lblMetrosQuadrados);
            this.Controls.Add(this.btnTeto);
            this.Controls.Add(this.btnParedes);
            this.Controls.Add(this.btnPiso);
            this.Controls.Add(this.lblOrcamentoTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDivisao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNomeObra);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormEscolhaMaterial";
            this.Text = "EscolhaMaterial";
            this.Load += new System.EventHandler(this.FormEscolhaMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeObra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDivisao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOrcamentoTotal;
        private System.Windows.Forms.Button btnPiso;
        private System.Windows.Forms.Button btnParedes;
        private System.Windows.Forms.Button btnTeto;
        private System.Windows.Forms.Label lblMetrosQuadrados;
        private System.Windows.Forms.Label lblCustoPiso;
        private System.Windows.Forms.Label lblCustoParedes;
        private System.Windows.Forms.Label lblCustoTeto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label orcDiv;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}