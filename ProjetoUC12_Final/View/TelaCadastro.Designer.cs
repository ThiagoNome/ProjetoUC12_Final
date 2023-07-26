namespace ProjetoUC12_Final.View
{
    partial class TelaCadastro
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
            textBoxFaixa = new TextBox();
            label7 = new Label();
            textBoxData = new TextBox();
            label6 = new Label();
            Cadastrar = new Button();
            textBoxCategoria = new TextBox();
            textBoxDuracao = new TextBox();
            textBoxFilme = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxFaixa
            // 
            textBoxFaixa.Location = new Point(33, 298);
            textBoxFaixa.Name = "textBoxFaixa";
            textBoxFaixa.Size = new Size(155, 23);
            textBoxFaixa.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(33, 275);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 67;
            label7.Text = "Faixa Etária";
            // 
            // textBoxData
            // 
            textBoxData.Location = new Point(33, 243);
            textBoxData.Name = "textBoxData";
            textBoxData.Size = new Size(278, 23);
            textBoxData.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(33, 220);
            label6.Name = "label6";
            label6.Size = new Size(153, 20);
            label6.TabIndex = 65;
            label6.Text = "Data de Lançamento";
            // 
            // Cadastrar
            // 
            Cadastrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Cadastrar.Location = new Point(53, 337);
            Cadastrar.Name = "Cadastrar";
            Cadastrar.Size = new Size(228, 48);
            Cadastrar.TabIndex = 6;
            Cadastrar.Text = "Cadastrar";
            Cadastrar.UseVisualStyleBackColor = true;
            Cadastrar.Click += Cadastrar_Click;
            // 
            // textBoxCategoria
            // 
            textBoxCategoria.Location = new Point(33, 188);
            textBoxCategoria.Name = "textBoxCategoria";
            textBoxCategoria.Size = new Size(278, 23);
            textBoxCategoria.TabIndex = 3;
            // 
            // textBoxDuracao
            // 
            textBoxDuracao.Location = new Point(33, 133);
            textBoxDuracao.Name = "textBoxDuracao";
            textBoxDuracao.Size = new Size(155, 23);
            textBoxDuracao.TabIndex = 2;
            // 
            // textBoxFilme
            // 
            textBoxFilme.Location = new Point(33, 79);
            textBoxFilme.Name = "textBoxFilme";
            textBoxFilme.Size = new Size(229, 23);
            textBoxFilme.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(33, 165);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 57;
            label4.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(33, 110);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 56;
            label3.Text = "Duração";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 59);
            label2.Name = "label2";
            label2.Size = new Size(103, 17);
            label2.TabIndex = 55;
            label2.Text = "Nome do Filme";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(72, 9);
            label1.Name = "label1";
            label1.Size = new Size(176, 32);
            label1.TabIndex = 54;
            label1.Text = "Digite o Filme";
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 396);
            Controls.Add(textBoxFaixa);
            Controls.Add(label7);
            Controls.Add(textBoxData);
            Controls.Add(label6);
            Controls.Add(Cadastrar);
            Controls.Add(textBoxCategoria);
            Controls.Add(textBoxDuracao);
            Controls.Add(textBoxFilme);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            MaximizeBox = false;
            Name = "TelaCadastro";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFaixa;
        private Label label7;
        private TextBox textBoxData;
        private Label label6;
        private Button Cadastrar;
        private TextBox textBoxCategoria;
        private TextBox textBoxDuracao;
        private TextBox textBoxFilme;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}