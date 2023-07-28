namespace ProjetoUC12_Final.View
{
    partial class TelaCadastrar
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
            Cadastrar = new Button();
            label7 = new Label();
            txbFaixaEtaria = new TextBox();
            txbDatadeLancamento = new TextBox();
            txbCategoria = new TextBox();
            txbDuracao = new TextBox();
            txbFilme = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // Cadastrar
            // 
            Cadastrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Cadastrar.Location = new Point(23, 335);
            Cadastrar.Name = "Cadastrar";
            Cadastrar.Size = new Size(214, 48);
            Cadastrar.TabIndex = 44;
            Cadastrar.Text = "Cadastrar Filme";
            Cadastrar.UseVisualStyleBackColor = true;
            Cadastrar.Click += Cadastrar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(28, 267);
            label7.Name = "label7";
            label7.Size = new Size(98, 21);
            label7.TabIndex = 42;
            label7.Text = "Faixa Étaria";
            // 
            // txbFaixaEtaria
            // 
            txbFaixaEtaria.Location = new Point(28, 291);
            txbFaixaEtaria.Name = "txbFaixaEtaria";
            txbFaixaEtaria.Size = new Size(219, 23);
            txbFaixaEtaria.TabIndex = 41;
            // 
            // txbDatadeLancamento
            // 
            txbDatadeLancamento.Location = new Point(30, 233);
            txbDatadeLancamento.Name = "txbDatadeLancamento";
            txbDatadeLancamento.Size = new Size(159, 23);
            txbDatadeLancamento.TabIndex = 39;
            // 
            // txbCategoria
            // 
            txbCategoria.Location = new Point(30, 180);
            txbCategoria.Name = "txbCategoria";
            txbCategoria.Size = new Size(159, 23);
            txbCategoria.TabIndex = 37;
            // 
            // txbDuracao
            // 
            txbDuracao.Location = new Point(30, 126);
            txbDuracao.Name = "txbDuracao";
            txbDuracao.Size = new Size(159, 23);
            txbDuracao.TabIndex = 35;
            // 
            // txbFilme
            // 
            txbFilme.Location = new Point(28, 71);
            txbFilme.Name = "txbFilme";
            txbFilme.Size = new Size(219, 23);
            txbFilme.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(28, 206);
            label5.Name = "label5";
            label5.Size = new Size(167, 21);
            label5.TabIndex = 38;
            label5.Text = "Data de Lançamento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(30, 102);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 36;
            label4.Text = "Duração";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(30, 156);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 34;
            label3.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 47);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 32;
            label2.Text = "Filme";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(251, 25);
            label1.TabIndex = 30;
            label1.Text = "Cadastrar Filme";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // TelaCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 396);
            Controls.Add(Cadastrar);
            Controls.Add(label7);
            Controls.Add(txbFaixaEtaria);
            Controls.Add(txbDatadeLancamento);
            Controls.Add(txbCategoria);
            Controls.Add(txbDuracao);
            Controls.Add(txbFilme);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaCadastrar";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Filme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cadastrar;
        private Label label7;
        private TextBox txbFaixaEtaria;
        private TextBox txbDatadeLancamento;
        private TextBox txbCategoria;
        private TextBox txbDuracao;
        private TextBox txbFilme;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}