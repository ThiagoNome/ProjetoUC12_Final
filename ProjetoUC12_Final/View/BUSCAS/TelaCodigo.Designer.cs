namespace ProjetoUC12_Final.View.BUSCAS
{
    partial class TelaCodigo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCodigo));
            textBoxFaixa = new TextBox();
            label7 = new Label();
            textBoxData = new TextBox();
            label6 = new Label();
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
            // textBoxFaixa
            // 
            textBoxFaixa.Location = new Point(28, 321);
            textBoxFaixa.Name = "textBoxFaixa";
            textBoxFaixa.Size = new Size(155, 23);
            textBoxFaixa.TabIndex = 91;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(28, 298);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 100;
            label7.Text = "Faixa Etária";
            // 
            // textBoxData
            // 
            textBoxData.Location = new Point(28, 266);
            textBoxData.Name = "textBoxData";
            textBoxData.Size = new Size(278, 23);
            textBoxData.TabIndex = 90;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(28, 243);
            label6.Name = "label6";
            label6.Size = new Size(153, 20);
            label6.TabIndex = 99;
            label6.Text = "Data de Lançamento";
            // 
            // buscar
            // 
            buscar.FlatStyle = FlatStyle.Flat;
            buscar.Image = (Image)resources.GetObject("buscar.Image");
            buscar.Location = new Point(187, 43);
            buscar.Name = "buscar";
            buscar.Size = new Size(59, 29);
            buscar.TabIndex = 97;
            buscar.UseVisualStyleBackColor = true;
            buscar.Click += buscar_Click;
            // 
            // textBoxCategoria
            // 
            textBoxCategoria.Location = new Point(28, 211);
            textBoxCategoria.Name = "textBoxCategoria";
            textBoxCategoria.Size = new Size(278, 23);
            textBoxCategoria.TabIndex = 89;
            // 
            // textBoxDuracao
            // 
            textBoxDuracao.Location = new Point(28, 156);
            textBoxDuracao.Name = "textBoxDuracao";
            textBoxDuracao.Size = new Size(155, 23);
            textBoxDuracao.TabIndex = 88;
            // 
            // textBoxCod
            // 
            textBoxCod.Location = new Point(26, 47);
            textBoxCod.Name = "textBoxCod";
            textBoxCod.Size = new Size(155, 23);
            textBoxCod.TabIndex = 86;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(28, 102);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(229, 23);
            textBoxNome.TabIndex = 87;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(28, 188);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 96;
            label4.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 133);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 95;
            label3.Text = "Duração";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 82);
            label2.Name = "label2";
            label2.Size = new Size(103, 17);
            label2.TabIndex = 94;
            label2.Text = "Nome do Filme";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(48, 9);
            label1.Name = "label1";
            label1.Size = new Size(246, 20);
            label1.TabIndex = 93;
            label1.Text = "Digite o Código que deseja Buscar";
            // 
            // TelaCodigo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 355);
            Controls.Add(textBoxFaixa);
            Controls.Add(label7);
            Controls.Add(textBoxData);
            Controls.Add(label6);
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
            Name = "TelaCodigo";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaCodigo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFaixa;
        private Label label7;
        private TextBox textBoxData;
        private Label label6;
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