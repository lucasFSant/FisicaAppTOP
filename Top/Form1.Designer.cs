namespace Top
{
    partial class Form1
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
            btVelocidadeMedia = new Button();
            btTorricelli = new Button();
            btMovimentoUniforme = new Button();
            btAceleracao = new Button();
            panelCalculo = new Panel();
            lblResultado = new Label();
            lblNomeResultado = new Label();
            btCalcular = new Button();
            numEntrada3 = new NumericUpDown();
            numEntrada2 = new NumericUpDown();
            numEntrada1 = new NumericUpDown();
            lblEntrada3 = new Label();
            lblEntrada2 = new Label();
            lblEntrada1 = new Label();
            panelCalculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numEntrada3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEntrada2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEntrada1).BeginInit();
            SuspendLayout();
            // 
            // btVelocidadeMedia
            // 
            btVelocidadeMedia.Location = new Point(78, 19);
            btVelocidadeMedia.Name = "btVelocidadeMedia";
            btVelocidadeMedia.Size = new Size(107, 38);
            btVelocidadeMedia.TabIndex = 0;
            btVelocidadeMedia.Text = "Velocidade Média";
            btVelocidadeMedia.UseVisualStyleBackColor = true;
            btVelocidadeMedia.Click += btVelocidadeMedia_Click;
            // 
            // btTorricelli
            // 
            btTorricelli.Location = new Point(605, 19);
            btTorricelli.Name = "btTorricelli";
            btTorricelli.Size = new Size(84, 38);
            btTorricelli.TabIndex = 1;
            btTorricelli.Text = "Torricelli";
            btTorricelli.UseVisualStyleBackColor = true;
            btTorricelli.Click += btTorricelli_Click;
            // 
            // btMovimentoUniforme
            // 
            btMovimentoUniforme.Location = new Point(436, 19);
            btMovimentoUniforme.Name = "btMovimentoUniforme";
            btMovimentoUniforme.Size = new Size(96, 38);
            btMovimentoUniforme.TabIndex = 2;
            btMovimentoUniforme.Text = "Movimento Uniforme";
            btMovimentoUniforme.UseVisualStyleBackColor = true;
            btMovimentoUniforme.Click += btMovimentoUniforme_Click;
            // 
            // btAceleracao
            // 
            btAceleracao.Location = new Point(256, 19);
            btAceleracao.Name = "btAceleracao";
            btAceleracao.Size = new Size(97, 38);
            btAceleracao.TabIndex = 3;
            btAceleracao.Text = "Aceleração";
            btAceleracao.UseVisualStyleBackColor = true;
            btAceleracao.Click += btAceleracao_Click;
            // 
            // panelCalculo
            // 
            panelCalculo.Controls.Add(lblResultado);
            panelCalculo.Controls.Add(lblNomeResultado);
            panelCalculo.Controls.Add(btCalcular);
            panelCalculo.Controls.Add(numEntrada3);
            panelCalculo.Controls.Add(numEntrada2);
            panelCalculo.Controls.Add(numEntrada1);
            panelCalculo.Controls.Add(lblEntrada3);
            panelCalculo.Controls.Add(lblEntrada2);
            panelCalculo.Controls.Add(lblEntrada1);
            panelCalculo.Location = new Point(71, 81);
            panelCalculo.Name = "panelCalculo";
            panelCalculo.Size = new Size(644, 346);
            panelCalculo.TabIndex = 4;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(271, 284);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(136, 25);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "Resultado aqui";
            // 
            // lblNomeResultado
            // 
            lblNomeResultado.AutoSize = true;
            lblNomeResultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeResultado.Location = new Point(58, 284);
            lblNomeResultado.Name = "lblNomeResultado";
            lblNomeResultado.Size = new Size(98, 25);
            lblNomeResultado.TabIndex = 7;
            lblNomeResultado.Text = "Resultado:";
            // 
            // btCalcular
            // 
            btCalcular.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btCalcular.Location = new Point(125, 186);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(157, 45);
            btCalcular.TabIndex = 6;
            btCalcular.Text = "Calcular";
            btCalcular.UseVisualStyleBackColor = true;
            btCalcular.Click += btCalcular_Click;
            // 
            // numEntrada3
            // 
            numEntrada3.DecimalPlaces = 2;
            numEntrada3.Location = new Point(225, 128);
            numEntrada3.Name = "numEntrada3";
            numEntrada3.Size = new Size(120, 23);
            numEntrada3.TabIndex = 5;
            // 
            // numEntrada2
            // 
            numEntrada2.DecimalPlaces = 2;
            numEntrada2.Location = new Point(225, 82);
            numEntrada2.Name = "numEntrada2";
            numEntrada2.Size = new Size(120, 23);
            numEntrada2.TabIndex = 4;
            // 
            // numEntrada1
            // 
            numEntrada1.DecimalPlaces = 2;
            numEntrada1.Location = new Point(225, 34);
            numEntrada1.Name = "numEntrada1";
            numEntrada1.Size = new Size(120, 23);
            numEntrada1.TabIndex = 3;
            // 
            // lblEntrada3
            // 
            lblEntrada3.AutoSize = true;
            lblEntrada3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEntrada3.Location = new Point(58, 128);
            lblEntrada3.Name = "lblEntrada3";
            lblEntrada3.Size = new Size(79, 21);
            lblEntrada3.TabIndex = 2;
            lblEntrada3.Text = "Entrada 3:";
            // 
            // lblEntrada2
            // 
            lblEntrada2.AutoSize = true;
            lblEntrada2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEntrada2.Location = new Point(58, 84);
            lblEntrada2.Name = "lblEntrada2";
            lblEntrada2.Size = new Size(79, 21);
            lblEntrada2.TabIndex = 1;
            lblEntrada2.Text = "Entrada 2:";
            // 
            // lblEntrada1
            // 
            lblEntrada1.AutoSize = true;
            lblEntrada1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEntrada1.Location = new Point(58, 34);
            lblEntrada1.Name = "lblEntrada1";
            lblEntrada1.Size = new Size(79, 21);
            lblEntrada1.TabIndex = 0;
            lblEntrada1.Text = "Entrada 1:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelCalculo);
            Controls.Add(btAceleracao);
            Controls.Add(btMovimentoUniforme);
            Controls.Add(btTorricelli);
            Controls.Add(btVelocidadeMedia);
            Name = "Form1";
            Text = "FísicaApp 2.0-TOP";
            panelCalculo.ResumeLayout(false);
            panelCalculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numEntrada3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEntrada2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEntrada1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btVelocidadeMedia;
        private Button btTorricelli;
        private Button btMovimentoUniforme;
        private Button btAceleracao;
        private Panel panelCalculo;
        private Label lblNomeResultado;
        private Button btCalcular;
        private NumericUpDown numEntrada3;
        private NumericUpDown numEntrada2;
        private NumericUpDown numEntrada1;
        private Label lblEntrada3;
        private Label lblEntrada2;
        private Label lblEntrada1;
        private Label lblResultado;
    }
}
