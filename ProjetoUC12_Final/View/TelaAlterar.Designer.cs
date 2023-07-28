namespace ProjetoUC12_Final.View
{
    partial class TelaAlterar
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txbFilme = new TextBox();
            txbCodigo = new TextBox();
            txbDuracao = new TextBox();
            txbCategoria = new TextBox();
            txbDatadeLancamento = new TextBox();
            txbFaixaEtaria = new TextBox();
            label7 = new Label();
            Pesquisar = new Button();
            Alterar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(304, 19);
            label1.TabIndex = 0;
            label1.Text = "Digite o código do filme que deseja alterar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(51, 142);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 1;
            label2.Text = "Filme";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(53, 251);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 2;
            label3.Text = "Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(53, 197);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 3;
            label4.Text = "Duração";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(51, 301);
            label5.Name = "label5";
            label5.Size = new Size(167, 21);
            label5.TabIndex = 4;
            label5.Text = "Data de Lançamento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(51, 59);
            label6.Name = "label6";
            label6.Size = new Size(65, 21);
            label6.TabIndex = 5;
            label6.Text = "Código";
            // 
            // txbFilme
            // 
            txbFilme.Location = new Point(51, 166);
            txbFilme.Name = "txbFilme";
            txbFilme.Size = new Size(219, 23);
            txbFilme.TabIndex = 2;
            // 
            // txbCodigo
            // 
            txbCodigo.Location = new Point(51, 83);
            txbCodigo.Name = "txbCodigo";
            txbCodigo.Size = new Size(159, 23);
            txbCodigo.TabIndex = 1;
            // 
            // txbDuracao
            // 
            txbDuracao.Location = new Point(53, 221);
            txbDuracao.Name = "txbDuracao";
            txbDuracao.Size = new Size(159, 23);
            txbDuracao.TabIndex = 3;
            // 
            // txbCategoria
            // 
            txbCategoria.Location = new Point(53, 275);
            txbCategoria.Name = "txbCategoria";
            txbCategoria.Size = new Size(159, 23);
            txbCategoria.TabIndex = 4;
            // 
            // txbDatadeLancamento
            // 
            txbDatadeLancamento.Location = new Point(53, 328);
            txbDatadeLancamento.Name = "txbDatadeLancamento";
            txbDatadeLancamento.Size = new Size(159, 23);
            txbDatadeLancamento.TabIndex = 5;
            // 
            // txbFaixaEtaria
            // 
            txbFaixaEtaria.Location = new Point(51, 386);
            txbFaixaEtaria.Name = "txbFaixaEtaria";
            txbFaixaEtaria.Size = new Size(219, 23);
            txbFaixaEtaria.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(51, 362);
            label7.Name = "label7";
            label7.Size = new Size(98, 21);
            label7.TabIndex = 12;
            label7.Text = "Faixa Étaria";
            // 
            // Pesquisar
            // 
            Pesquisar.Location = new Point(216, 75);
            Pesquisar.Name = "Pesquisar";
            Pesquisar.Size = new Size(83, 37);
            Pesquisar.TabIndex = 13;
            Pesquisar.Text = "Pesquisar";
            Pesquisar.UseVisualStyleBackColor = true;
            Pesquisar.Click += Pesquisar_Click;
            // 
            // Alterar
            // 
            Alterar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Alterar.Location = new Point(51, 425);
            Alterar.Name = "Alterar";
            Alterar.Size = new Size(214, 48);
            Alterar.TabIndex = 14;
            Alterar.Text = "Alterar Filme";
            Alterar.UseVisualStyleBackColor = true;
            Alterar.Click += Alterar_Click;
            // 
            // TelaAlterar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 485);
            Controls.Add(Alterar);
            Controls.Add(Pesquisar);
            Controls.Add(label7);
            Controls.Add(txbFaixaEtaria);
            Controls.Add(txbDatadeLancamento);
            Controls.Add(txbCategoria);
            Controls.Add(txbDuracao);
            Controls.Add(txbCodigo);
            Controls.Add(txbFilme);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaAlterar";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alterar Filme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txbFilme;
        private TextBox txbCodigo;
        private TextBox txbDuracao;
        private TextBox txbCategoria;
        private TextBox txbDatadeLancamento;
        private TextBox txbFaixaEtaria;
        private Label label7;
        private Button Pesquisar;
        private Button Alterar;
    }
}