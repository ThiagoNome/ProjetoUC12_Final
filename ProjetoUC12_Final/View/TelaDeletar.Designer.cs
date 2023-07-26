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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDeletar));
            textBoxCodigo = new TextBox();
            textBoxFaixa = new TextBox();
            label7 = new Label();
            textBoxData = new TextBox();
            label6 = new Label();
            label5 = new Label();
            Deletar = new Button();
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
            textBoxCodigo.Location = new Point(32, 100);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(100, 23);
            textBoxCodigo.TabIndex = 85;
            // 
            // textBoxFaixa
            // 
            textBoxFaixa.Location = new Point(32, 367);
            textBoxFaixa.Name = "textBoxFaixa";
            textBoxFaixa.Size = new Size(155, 23);
            textBoxFaixa.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(32, 344);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 83;
            label7.Text = "Faixa Etária";
            // 
            // textBoxData
            // 
            textBoxData.Location = new Point(32, 312);
            textBoxData.Name = "textBoxData";
            textBoxData.Size = new Size(278, 23);
            textBoxData.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(32, 289);
            label6.Name = "label6";
            label6.Size = new Size(153, 20);
            label6.TabIndex = 81;
            label6.Text = "Data de Lançamento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(32, 80);
            label5.Name = "label5";
            label5.Size = new Size(52, 17);
            label5.TabIndex = 80;
            label5.Text = "Código";
            // 
            // Deletar
            // 
            Deletar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Deletar.Location = new Point(52, 406);
            Deletar.Name = "Deletar";
            Deletar.Size = new Size(228, 48);
            Deletar.TabIndex = 7;
            Deletar.Text = "Deletar Filme";
            Deletar.UseVisualStyleBackColor = true;
            Deletar.Click += Deletar_Click;
            // 
            // buscar
            // 
            buscar.FlatStyle = FlatStyle.Flat;
            buscar.Image = (Image)resources.GetObject("buscar.Image");
            buscar.Location = new Point(193, 38);
            buscar.Name = "buscar";
            buscar.Size = new Size(59, 29);
            buscar.TabIndex = 78;
            buscar.UseVisualStyleBackColor = true;
            buscar.Click += buscar_Click;
            // 
            // textBoxCategoria
            // 
            textBoxCategoria.Location = new Point(32, 257);
            textBoxCategoria.Name = "textBoxCategoria";
            textBoxCategoria.Size = new Size(278, 23);
            textBoxCategoria.TabIndex = 4;
            // 
            // textBoxDuracao
            // 
            textBoxDuracao.Location = new Point(32, 202);
            textBoxDuracao.Name = "textBoxDuracao";
            textBoxDuracao.Size = new Size(155, 23);
            textBoxDuracao.TabIndex = 3;
            // 
            // textBoxCod
            // 
            textBoxCod.Location = new Point(32, 42);
            textBoxCod.Name = "textBoxCod";
            textBoxCod.Size = new Size(155, 23);
            textBoxCod.TabIndex = 1;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(32, 148);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(229, 23);
            textBoxNome.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(32, 234);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 73;
            label4.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 179);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 72;
            label3.Text = "Duração";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(32, 128);
            label2.Name = "label2";
            label2.Size = new Size(103, 17);
            label2.TabIndex = 71;
            label2.Text = "Nome do Filme";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 6);
            label1.Name = "label1";
            label1.Size = new Size(317, 20);
            label1.TabIndex = 70;
            label1.Text = "Digite o Código do Filme que deseja Deletar.";
            // 
            // TelaDeletar
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
            Controls.Add(Deletar);
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
            Name = "TelaDeletar";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaDeletar";
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
        private Button Deletar;
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