namespace ProjetoEstatistica
{
    partial class frmEstatistica
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
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.txtN4 = new System.Windows.Forms.TextBox();
            this.txtN5 = new System.Windows.Forms.TextBox();
            this.txtN6 = new System.Windows.Forms.TextBox();
            this.txtN7 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.rdMedia = new System.Windows.Forms.RadioButton();
            this.rdDesvPadrao = new System.Windows.Forms.RadioButton();
            this.rdMediana = new System.Windows.Forms.RadioButton();
            this.rdPriQuartil = new System.Windows.Forms.RadioButton();
            this.rdTerQuartil = new System.Windows.Forms.RadioButton();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtDesvioPadrao = new System.Windows.Forms.TextBox();
            this.txtMediana = new System.Windows.Forms.TextBox();
            this.txtPriQuartil = new System.Windows.Forms.TextBox();
            this.txtTerQuartil = new System.Windows.Forms.TextBox();
            this.txtModa = new System.Windows.Forms.TextBox();
            this.rdModa = new System.Windows.Forms.RadioButton();
            this.rdSegQuartil = new System.Windows.Forms.RadioButton();
            this.txtSegQuartil = new System.Windows.Forms.TextBox();
            this.txtSimetria = new System.Windows.Forms.TextBox();
            this.rdSimetria = new System.Windows.Forms.RadioButton();
            this.numProbabilidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProbabilidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProbabilidade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(124, 35);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(70, 20);
            this.txtN1.TabIndex = 0;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(200, 35);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(70, 20);
            this.txtN2.TabIndex = 1;
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(276, 35);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(70, 20);
            this.txtN3.TabIndex = 2;
            // 
            // txtN4
            // 
            this.txtN4.Location = new System.Drawing.Point(352, 35);
            this.txtN4.Name = "txtN4";
            this.txtN4.Size = new System.Drawing.Size(70, 20);
            this.txtN4.TabIndex = 3;
            // 
            // txtN5
            // 
            this.txtN5.Location = new System.Drawing.Point(164, 61);
            this.txtN5.Name = "txtN5";
            this.txtN5.Size = new System.Drawing.Size(70, 20);
            this.txtN5.TabIndex = 4;
            // 
            // txtN6
            // 
            this.txtN6.Location = new System.Drawing.Point(240, 61);
            this.txtN6.Name = "txtN6";
            this.txtN6.Size = new System.Drawing.Size(70, 20);
            this.txtN6.TabIndex = 5;
            // 
            // txtN7
            // 
            this.txtN7.Location = new System.Drawing.Point(316, 61);
            this.txtN7.Name = "txtN7";
            this.txtN7.Size = new System.Drawing.Size(70, 20);
            this.txtN7.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(195, 111);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(276, 111);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // rdMedia
            // 
            this.rdMedia.AutoSize = true;
            this.rdMedia.Location = new System.Drawing.Point(12, 175);
            this.rdMedia.Name = "rdMedia";
            this.rdMedia.Size = new System.Drawing.Size(54, 17);
            this.rdMedia.TabIndex = 13;
            this.rdMedia.TabStop = true;
            this.rdMedia.Text = "Média";
            this.rdMedia.UseVisualStyleBackColor = true;
            // 
            // rdDesvPadrao
            // 
            this.rdDesvPadrao.AutoSize = true;
            this.rdDesvPadrao.Location = new System.Drawing.Point(12, 272);
            this.rdDesvPadrao.Name = "rdDesvPadrao";
            this.rdDesvPadrao.Size = new System.Drawing.Size(95, 17);
            this.rdDesvPadrao.TabIndex = 15;
            this.rdDesvPadrao.TabStop = true;
            this.rdDesvPadrao.Text = "Desvio Padrão";
            this.rdDesvPadrao.UseVisualStyleBackColor = true;
            // 
            // rdMediana
            // 
            this.rdMediana.AutoSize = true;
            this.rdMediana.Location = new System.Drawing.Point(12, 207);
            this.rdMediana.Name = "rdMediana";
            this.rdMediana.Size = new System.Drawing.Size(66, 17);
            this.rdMediana.TabIndex = 20;
            this.rdMediana.TabStop = true;
            this.rdMediana.Text = "Mediana";
            this.rdMediana.UseVisualStyleBackColor = true;
            // 
            // rdPriQuartil
            // 
            this.rdPriQuartil.AutoSize = true;
            this.rdPriQuartil.Location = new System.Drawing.Point(466, 170);
            this.rdPriQuartil.Name = "rdPriQuartil";
            this.rdPriQuartil.Size = new System.Drawing.Size(68, 17);
            this.rdPriQuartil.TabIndex = 24;
            this.rdPriQuartil.TabStop = true;
            this.rdPriQuartil.Text = "1º Quartil";
            this.rdPriQuartil.UseVisualStyleBackColor = true;
            // 
            // rdTerQuartil
            // 
            this.rdTerQuartil.AutoSize = true;
            this.rdTerQuartil.Location = new System.Drawing.Point(466, 239);
            this.rdTerQuartil.Name = "rdTerQuartil";
            this.rdTerQuartil.Size = new System.Drawing.Size(68, 17);
            this.rdTerQuartil.TabIndex = 26;
            this.rdTerQuartil.TabStop = true;
            this.rdTerQuartil.Text = "3º Quartil";
            this.rdTerQuartil.UseVisualStyleBackColor = true;
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(124, 170);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(100, 20);
            this.txtMedia.TabIndex = 31;
            // 
            // txtDesvioPadrao
            // 
            this.txtDesvioPadrao.Location = new System.Drawing.Point(124, 271);
            this.txtDesvioPadrao.Name = "txtDesvioPadrao";
            this.txtDesvioPadrao.Size = new System.Drawing.Size(100, 20);
            this.txtDesvioPadrao.TabIndex = 33;
            // 
            // txtMediana
            // 
            this.txtMediana.Location = new System.Drawing.Point(124, 204);
            this.txtMediana.Name = "txtMediana";
            this.txtMediana.Size = new System.Drawing.Size(100, 20);
            this.txtMediana.TabIndex = 38;
            // 
            // txtPriQuartil
            // 
            this.txtPriQuartil.Location = new System.Drawing.Point(322, 170);
            this.txtPriQuartil.Name = "txtPriQuartil";
            this.txtPriQuartil.Size = new System.Drawing.Size(100, 20);
            this.txtPriQuartil.TabIndex = 42;
            // 
            // txtTerQuartil
            // 
            this.txtTerQuartil.Location = new System.Drawing.Point(322, 236);
            this.txtTerQuartil.Name = "txtTerQuartil";
            this.txtTerQuartil.Size = new System.Drawing.Size(100, 20);
            this.txtTerQuartil.TabIndex = 44;
            // 
            // txtModa
            // 
            this.txtModa.Location = new System.Drawing.Point(124, 236);
            this.txtModa.Name = "txtModa";
            this.txtModa.Size = new System.Drawing.Size(100, 20);
            this.txtModa.TabIndex = 45;
            // 
            // rdModa
            // 
            this.rdModa.AutoSize = true;
            this.rdModa.Location = new System.Drawing.Point(12, 239);
            this.rdModa.Name = "rdModa";
            this.rdModa.Size = new System.Drawing.Size(52, 17);
            this.rdModa.TabIndex = 46;
            this.rdModa.TabStop = true;
            this.rdModa.Text = "Moda";
            this.rdModa.UseVisualStyleBackColor = true;
            // 
            // rdSegQuartil
            // 
            this.rdSegQuartil.AutoSize = true;
            this.rdSegQuartil.Location = new System.Drawing.Point(466, 205);
            this.rdSegQuartil.Name = "rdSegQuartil";
            this.rdSegQuartil.Size = new System.Drawing.Size(68, 17);
            this.rdSegQuartil.TabIndex = 47;
            this.rdSegQuartil.TabStop = true;
            this.rdSegQuartil.Text = "2º Quartil";
            this.rdSegQuartil.UseVisualStyleBackColor = true;
            // 
            // txtSegQuartil
            // 
            this.txtSegQuartil.Location = new System.Drawing.Point(322, 204);
            this.txtSegQuartil.Name = "txtSegQuartil";
            this.txtSegQuartil.Size = new System.Drawing.Size(100, 20);
            this.txtSegQuartil.TabIndex = 48;
            // 
            // txtSimetria
            // 
            this.txtSimetria.Location = new System.Drawing.Point(322, 271);
            this.txtSimetria.Name = "txtSimetria";
            this.txtSimetria.Size = new System.Drawing.Size(100, 20);
            this.txtSimetria.TabIndex = 49;
            // 
            // rdSimetria
            // 
            this.rdSimetria.AutoSize = true;
            this.rdSimetria.Location = new System.Drawing.Point(466, 272);
            this.rdSimetria.Name = "rdSimetria";
            this.rdSimetria.Size = new System.Drawing.Size(62, 17);
            this.rdSimetria.TabIndex = 50;
            this.rdSimetria.TabStop = true;
            this.rdSimetria.Text = "Simetria";
            this.rdSimetria.UseVisualStyleBackColor = true;
            // 
            // numProbabilidade
            // 
            this.numProbabilidade.Location = new System.Drawing.Point(247, 316);
            this.numProbabilidade.Name = "numProbabilidade";
            this.numProbabilidade.Size = new System.Drawing.Size(88, 20);
            this.numProbabilidade.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Probabilidade:";
            // 
            // txtProbabilidade
            // 
            this.txtProbabilidade.Location = new System.Drawing.Point(247, 387);
            this.txtProbabilidade.Name = "txtProbabilidade";
            this.txtProbabilidade.Size = new System.Drawing.Size(88, 20);
            this.txtProbabilidade.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Digite um valor:";
            // 
            // btnProbabilidade
            // 
            this.btnProbabilidade.Location = new System.Drawing.Point(200, 358);
            this.btnProbabilidade.Name = "btnProbabilidade";
            this.btnProbabilidade.Size = new System.Drawing.Size(81, 23);
            this.btnProbabilidade.TabIndex = 56;
            this.btnProbabilidade.Text = "Probabilidade";
            this.btnProbabilidade.UseVisualStyleBackColor = true;
            this.btnProbabilidade.Click += new System.EventHandler(this.btnProbabilidade_Click);
            // 
            // frmEstatistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 419);
            this.Controls.Add(this.btnProbabilidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProbabilidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numProbabilidade);
            this.Controls.Add(this.rdSimetria);
            this.Controls.Add(this.txtSimetria);
            this.Controls.Add(this.txtSegQuartil);
            this.Controls.Add(this.rdSegQuartil);
            this.Controls.Add(this.rdModa);
            this.Controls.Add(this.txtModa);
            this.Controls.Add(this.txtTerQuartil);
            this.Controls.Add(this.txtPriQuartil);
            this.Controls.Add(this.txtMediana);
            this.Controls.Add(this.txtDesvioPadrao);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.rdTerQuartil);
            this.Controls.Add(this.rdPriQuartil);
            this.Controls.Add(this.rdMediana);
            this.Controls.Add(this.rdDesvPadrao);
            this.Controls.Add(this.rdMedia);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtN7);
            this.Controls.Add(this.txtN6);
            this.Controls.Add(this.txtN5);
            this.Controls.Add(this.txtN4);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Name = "frmEstatistica";
            this.Text = "Projeto de Estatística ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.TextBox txtN4;
        private System.Windows.Forms.TextBox txtN5;
        private System.Windows.Forms.TextBox txtN6;
        private System.Windows.Forms.TextBox txtN7;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.RadioButton rdMedia;
        private System.Windows.Forms.RadioButton rdDesvPadrao;
        private System.Windows.Forms.RadioButton rdMediana;
        private System.Windows.Forms.RadioButton rdPriQuartil;
        private System.Windows.Forms.RadioButton rdTerQuartil;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.TextBox txtDesvioPadrao;
        private System.Windows.Forms.TextBox txtMediana;
        private System.Windows.Forms.TextBox txtPriQuartil;
        private System.Windows.Forms.TextBox txtTerQuartil;
        private System.Windows.Forms.TextBox txtModa;
        private System.Windows.Forms.RadioButton rdModa;
        private System.Windows.Forms.RadioButton rdSegQuartil;
        private System.Windows.Forms.TextBox txtSegQuartil;
        private System.Windows.Forms.TextBox txtSimetria;
        private System.Windows.Forms.RadioButton rdSimetria;
        private System.Windows.Forms.TextBox numProbabilidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProbabilidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProbabilidade;
    }
}

