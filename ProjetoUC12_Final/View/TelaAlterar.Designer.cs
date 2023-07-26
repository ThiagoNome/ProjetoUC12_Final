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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAlterar));
            textBoxCodigo = new TextBox();
            textBoxFaixa = new TextBox();
            label7 = new Label();
            textBoxData = new TextBox();
            label6 = new Label();
            label5 = new Label();
            Alterar = new Button();
            buscar = new Button();
            textBoxCategoria = new TextBox();
            textBoxDuracao = new TextBox();
            textBoxCod = new TextBox();
            textBoxNome = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(33, 100);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(100, 23);
            textBoxCodigo.TabIndex = 69;
            // 
            // textBoxFaixa
            // 
            textBoxFaixa.Location = new Point(33, 367);
            textBoxFaixa.Name = "textBoxFaixa";
            textBoxFaixa.Size = new Size(155, 23);
            textBoxFaixa.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(33, 344);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 67;
            label7.Text = "Faixa Etária";
            // 
            // textBoxData
            // 
            textBoxData.Location = new Point(33, 312);
            textBoxData.Name = "textBoxData";
            textBoxData.Size = new Size(278, 23);
            textBoxData.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(33, 289);
            label6.Name = "label6";
            label6.Size = new Size(153, 20);
            label6.TabIndex = 65;
            label6.Text = "Data de Lançamento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(33, 80);
            label5.Name = "label5";
            label5.Size = new Size(52, 17);
            label5.TabIndex = 64;
            label5.Text = "Código";
            // 
            // Alterar
            // 
            Alterar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Alterar.Location = new Point(53, 406);
            Alterar.Name = "Alterar";
            Alterar.Size = new Size(228, 48);
            Alterar.TabIndex = 7;
            Alterar.Text = "Alterar os Dados";
            Alterar.UseVisualStyleBackColor = true;
            Alterar.Click += Alterar_Click;
            // 
            // buscar
            // 
            buscar.FlatStyle = FlatStyle.Flat;
            buscar.Image = (Image)resources.GetObject("buscar.Image");
            buscar.Location = new Point(192, 50);
            buscar.Name = "buscar";
            buscar.Size = new Size(59, 29);
            buscar.TabIndex = 62;
            buscar.UseVisualStyleBackColor = true;
            buscar.Click += buscar_Click;
            // 
            // textBoxCategoria
            // 
            textBoxCategoria.Location = new Point(33, 257);
            textBoxCategoria.Name = "textBoxCategoria";
            textBoxCategoria.Size = new Size(278, 23);
            textBoxCategoria.TabIndex = 4;
            // 
            // textBoxDuracao
            // 
            textBoxDuracao.Location = new Point(33, 202);
            textBoxDuracao.Name = "textBoxDuracao";
            textBoxDuracao.Size = new Size(155, 23);
            textBoxDuracao.TabIndex = 3;
            // 
            // textBoxCod
            // 
            textBoxCod.Location = new Point(31, 54);
            textBoxCod.Name = "textBoxCod";
            textBoxCod.Size = new Size(155, 23);
            textBoxCod.TabIndex = 1;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(33, 148);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(229, 23);
            textBoxNome.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(33, 234);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 57;
            label4.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(33, 179);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 56;
            label3.Text = "Duração";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 128);
            label2.Name = "label2";
            label2.Size = new Size(103, 17);
            label2.TabIndex = 55;
            label2.Text = "Nome do Filme";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 6);
            label1.Name = "label1";
            label1.Size = new Size(312, 20);
            label1.TabIndex = 54;
            label1.Text = "Digite o Código do Filme que deseja alterar.";
            // 
            // TelaAlterar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 461);
            Controls.Add(textBoxCodigo);
            Controls.Add(textBoxFaixa);
            Controls.Add(label7);
            Controls.Add(textBoxData);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Alterar);
            Controls.Add(buscar);
            Controls.Add(textBoxCategoria);
            Controls.Add(textBoxDuracao);
            Controls.Add(textBoxCod);
            Controls.Add(textBoxNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaAlterar";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaAlterar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCodigo;
        private TextBox textBoxFaixa;
        private Label label7;
        private TextBox textBoxData;
        private Label label6;
        private Label label5;
        private Button Alterar;
        private Button buscar;
        private TextBox textBoxCategoria;
        private TextBox textBoxDuracao;
        private TextBox textBoxCod;
        private TextBox textBoxNome;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}