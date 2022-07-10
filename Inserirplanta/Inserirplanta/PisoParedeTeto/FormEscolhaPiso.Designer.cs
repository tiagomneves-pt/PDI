namespace CustomYou
{
    partial class FormEscolhaPiso
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
            this.lblPiso = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPisoLaminado = new System.Windows.Forms.Button();
            this.btnParquet = new System.Windows.Forms.Button();
            this.btnPedra = new System.Windows.Forms.Button();
            this.btnAlcatifa = new System.Windows.Forms.Button();
            this.btnAzulejo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Materiais";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPiso.ForeColor = System.Drawing.Color.DimGray;
            this.lblPiso.Location = new System.Drawing.Point(32, 64);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(36, 20);
            this.lblPiso.TabIndex = 2;
            this.lblPiso.Text = "Piso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de piso";
            // 
            // btnPisoLaminado
            // 
            this.btnPisoLaminado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPisoLaminado.BackgroundImage = global::CustomYou.Properties.Resources.PisoLaminadoMain;
            this.btnPisoLaminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPisoLaminado.Image = global::CustomYou.Properties.Resources.Madeira06;
            this.btnPisoLaminado.Location = new System.Drawing.Point(45, 148);
            this.btnPisoLaminado.Name = "btnPisoLaminado";
            this.btnPisoLaminado.Size = new System.Drawing.Size(110, 82);
            this.btnPisoLaminado.TabIndex = 4;
            this.btnPisoLaminado.Text = "Piso laminado";
            this.btnPisoLaminado.UseVisualStyleBackColor = false;
            this.btnPisoLaminado.Click += new System.EventHandler(this.btnPisoLaminado_Click);
            // 
            // btnParquet
            // 
            this.btnParquet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnParquet.Image = global::CustomYou.Properties.Resources.ParquetExot02;
            this.btnParquet.Location = new System.Drawing.Point(182, 148);
            this.btnParquet.Name = "btnParquet";
            this.btnParquet.Size = new System.Drawing.Size(110, 82);
            this.btnParquet.TabIndex = 5;
            this.btnParquet.Text = "Parquet";
            this.btnParquet.UseVisualStyleBackColor = true;
            this.btnParquet.Click += new System.EventHandler(this.btnParquet_Click);
            // 
            // btnPedra
            // 
            this.btnPedra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPedra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPedra.Image = global::CustomYou.Properties.Resources.Porcelana01;
            this.btnPedra.Location = new System.Drawing.Point(317, 148);
            this.btnPedra.Name = "btnPedra";
            this.btnPedra.Size = new System.Drawing.Size(110, 82);
            this.btnPedra.TabIndex = 6;
            this.btnPedra.Text = "Pedra";
            this.btnPedra.UseVisualStyleBackColor = true;
            this.btnPedra.Click += new System.EventHandler(this.btnPedra_Click);
            // 
            // btnAlcatifa
            // 
            this.btnAlcatifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAlcatifa.Image = global::CustomYou.Properties.Resources.Alcatifa05;
            this.btnAlcatifa.Location = new System.Drawing.Point(446, 148);
            this.btnAlcatifa.Name = "btnAlcatifa";
            this.btnAlcatifa.Size = new System.Drawing.Size(110, 82);
            this.btnAlcatifa.TabIndex = 7;
            this.btnAlcatifa.Text = "Alcatifa";
            this.btnAlcatifa.UseVisualStyleBackColor = true;
            this.btnAlcatifa.Click += new System.EventHandler(this.btnAlcatifa_Click);
            // 
            // btnAzulejo
            // 
            this.btnAzulejo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAzulejo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAzulejo.Image = global::CustomYou.Properties.Resources.Azulejo09;
            this.btnAzulejo.Location = new System.Drawing.Point(583, 148);
            this.btnAzulejo.Name = "btnAzulejo";
            this.btnAzulejo.Size = new System.Drawing.Size(110, 82);
            this.btnAzulejo.TabIndex = 8;
            this.btnAzulejo.Text = "Azulejo";
            this.btnAzulejo.UseVisualStyleBackColor = true;
            this.btnAzulejo.Click += new System.EventHandler(this.btnAzulejo_Click);
            // 
            // FormEscolhaPiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 340);
            this.Controls.Add(this.btnAzulejo);
            this.Controls.Add(this.btnAlcatifa);
            this.Controls.Add(this.btnPedra);
            this.Controls.Add(this.btnParquet);
            this.Controls.Add(this.btnPisoLaminado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.label1);
            this.Name = "FormEscolhaPiso";
            this.Text = "Lista de Materiais";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPisoLaminado;
        private System.Windows.Forms.Button btnParquet;
        private System.Windows.Forms.Button btnPedra;
        private System.Windows.Forms.Button btnAlcatifa;
        private System.Windows.Forms.Button btnAzulejo;
    }
}