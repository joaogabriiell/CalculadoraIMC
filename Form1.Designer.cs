using System;

namespace UC12___Aula_I___Calculadora_simples
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTITULO = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.btnCALC = new System.Windows.Forms.Button();
            this.lblRESULTADO = new System.Windows.Forms.Label();
            this.lblimcresul = new System.Windows.Forms.Label();
            this.lblClassificacao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTITULO
            // 
            this.lblTITULO.AutoSize = true;
            this.lblTITULO.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTITULO.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTITULO.Location = new System.Drawing.Point(76, 25);
            this.lblTITULO.Name = "lblTITULO";
            this.lblTITULO.Size = new System.Drawing.Size(189, 21);
            this.lblTITULO.TabIndex = 0;
            this.lblTITULO.Text = "Calculadora seu IMC";
            this.lblTITULO.Click += new System.EventHandler(this.lblTITULO_Click);
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(91, 110);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(145, 20);
            this.txtN1.TabIndex = 1;
            this.txtN1.Text = "Peso:";
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(91, 206);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(145, 20);
            this.txtN2.TabIndex = 2;
            this.txtN2.Text = "Altura";
            // 
            // btnCALC
            // 
            this.btnCALC.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCALC.Font = new System.Drawing.Font("Swis721 WGL4 BT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCALC.Location = new System.Drawing.Point(122, 263);
            this.btnCALC.Name = "btnCALC";
            this.btnCALC.Size = new System.Drawing.Size(76, 37);
            this.btnCALC.TabIndex = 3;
            this.btnCALC.Text = "Calcular";
            this.btnCALC.UseVisualStyleBackColor = false;
            this.btnCALC.Click += new System.EventHandler(this.btnCALC_Click);
            // 
            // lblRESULTADO
            // 
            this.lblRESULTADO.AutoSize = true;
            this.lblRESULTADO.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRESULTADO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRESULTADO.Location = new System.Drawing.Point(86, 371);
            this.lblRESULTADO.Name = "lblRESULTADO";
            this.lblRESULTADO.Size = new System.Drawing.Size(68, 25);
            this.lblRESULTADO.TabIndex = 5;
            this.lblRESULTADO.Text = "IMC =";
            // 
            // lblimcresul
            // 
            this.lblimcresul.AutoSize = true;
            this.lblimcresul.Location = new System.Drawing.Point(91, 456);
            this.lblimcresul.Name = "lblimcresul";
            this.lblimcresul.Size = new System.Drawing.Size(0, 13);
            this.lblimcresul.TabIndex = 6;
            // 
            // lblClassificacao
            // 
            this.lblClassificacao.Location = new System.Drawing.Point(53, 449);
            this.lblClassificacao.Name = "lblClassificacao";
            this.lblClassificacao.Size = new System.Drawing.Size(212, 20);
            this.lblClassificacao.TabIndex = 7;
            this.lblClassificacao.Text = "Classificação segundo seu IMC.";
            this.lblClassificacao.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(328, 494);
            this.Controls.Add(this.lblClassificacao);
            this.Controls.Add(this.lblimcresul);
            this.Controls.Add(this.lblRESULTADO);
            this.Controls.Add(this.btnCALC);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.lblTITULO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULADORA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblTITULO;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Button btnCALC;
        private System.Windows.Forms.Label lblRESULTADO;
        private System.Windows.Forms.Label lblimcresul;
        private System.Windows.Forms.TextBox lblClassificacao;
    }
}

