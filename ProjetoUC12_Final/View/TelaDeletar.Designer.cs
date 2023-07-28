namespace ProjetoUC12_Final.View
{
    partial class TelaDeletar
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
            Deletar = new Button();
            Pesquisar = new Button();
            label7 = new Label();
            txbFaixaEtaria = new TextBox();
            txbDatadeLancamento = new TextBox();
            txbCategoria = new TextBox();
            txbDuracao = new TextBox();
            txbCodigo = new TextBox();
            txbFilme = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // Deletar
            // 
            Deletar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Deletar.Location = new Point(47, 420);
            Deletar.Name = "Deletar";
            Deletar.Size = new Size(175, 48);
            Deletar.TabIndex = 29;
            Deletar.Text = "Deletar Filme";
            Deletar.UseVisualStyleBackColor = true;
            Deletar.Click += Deletar_Click;
            // 
            // Pesquisar
            // 
            Pesquisar.Location = new Point(195, 82);
            Pesquisar.Name = "Pesquisar";
            Pesquisar.Size = new Size(84, 37);
            Pesquisar.TabIndex = 28;
            Pesquisar.Text = "Pesquisar";
            Pesquisar.UseVisualStyleBackColor = true;
            Pesquisar.Click += Pesquisar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(30, 356);
            label7.Name = "label7";
            label7.Size = new Size(98, 21);
            label7.TabIndex = 27;
            label7.Text = "Faixa Étaria";
            // 
            // txbFaixaEtaria
            // 
            txbFaixaEtaria.Location = new Point(30, 380);
            txbFaixaEtaria.Name = "txbFaixaEtaria";
            txbFaixaEtaria.Size = new Size(219, 23);
            txbFaixaEtaria.TabIndex = 26;
            // 
            // txbDatadeLancamento
            // 
            txbDatadeLancamento.Location = new Point(32, 322);
            txbDatadeLancamento.Name = "txbDatadeLancamento";
            txbDatadeLancamento.Size = new Size(159, 23);
            txbDatadeLancamento.TabIndex = 24;
            // 
            // txbCategoria
            // 
            txbCategoria.Location = new Point(32, 269);
            txbCategoria.Name = "txbCategoria";
            txbCategoria.Size = new Size(159, 23);
            txbCategoria.TabIndex = 22;
            // 
            // txbDuracao
            // 
            txbDuracao.Location = new Point(32, 215);
            txbDuracao.Name = "txbDuracao";
            txbDuracao.Size = new Size(159, 23);
            txbDuracao.TabIndex = 20;
            // 
            // txbCodigo
            // 
            txbCodigo.Location = new Point(30, 90);
            txbCodigo.Name = "txbCodigo";
            txbCodigo.Size = new Size(159, 23);
            txbCodigo.TabIndex = 16;
            // 
            // txbFilme
            // 
            txbFilme.Location = new Point(30, 160);
            txbFilme.Name = "txbFilme";
            txbFilme.Size = new Size(219, 23);
            txbFilme.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(35, 66);
            label6.Name = "label6";
            label6.Size = new Size(65, 21);
            label6.TabIndex = 25;
            label6.Text = "Código";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(30, 295);
            label5.Name = "label5";
            label5.Size = new Size(167, 21);
            label5.TabIndex = 23;
            label5.Text = "Data de Lançamento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(32, 191);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 21;
            label4.Text = "Duração";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 245);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 19;
            label3.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 136);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 17;
            label2.Text = "Filme";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(2, 25);
            label1.Name = "label1";
            label1.Size = new Size(318, 32);
            label1.TabIndex = 15;
            label1.Text = "Digite o código do filme que deseja deletar";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // TelaDeletar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 480);
            Controls.Add(Deletar);
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
            Name = "TelaDeletar";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Deletar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Deletar;
        private Button Pesquisar;
        private Label label7;
        private TextBox txbFaixaEtaria;
        private TextBox txbDatadeLancamento;
        private TextBox txbCategoria;
        private TextBox txbDuracao;
        private TextBox txbCodigo;
        private TextBox txbFilme;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}