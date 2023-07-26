namespace ProjetoUC12_Final.View.BUSCAS
{
    partial class TelaNome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaNome));
            textBoxFaixa = new TextBox();
            label7 = new Label();
            textBoxData = new TextBox();
            label6 = new Label();
            buscar = new Button();
            textBoxCategoria = new TextBox();
            textBoxDuracao = new TextBox();
            textBoxNomeBusca = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxFaixa
            // 
            textBoxFaixa.Location = new Point(28, 270);
            textBoxFaixa.Name = "textBoxFaixa";
            textBoxFaixa.Size = new Size(155, 23);
            textBoxFaixa.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(28, 247);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 100;
            label7.Text = "Faixa Etária";
            // 
            // textBoxData
            // 
            textBoxData.Location = new Point(28, 215);
            textBoxData.Name = "textBoxData";
            textBoxData.Size = new Size(278, 23);
            textBoxData.TabIndex = 5;
            textBoxData.TextChanged += textBoxData_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(28, 192);
            label6.Name = "label6";
            label6.Size = new Size(153, 20);
            label6.TabIndex = 99;
            label6.Text = "Data de Lançamento";
            // 
            // buscar
            // 
            buscar.FlatStyle = FlatStyle.Flat;
            buscar.Image = (Image)resources.GetObject("buscar.Image");
            buscar.Location = new Point(198, 52);
            buscar.Name = "buscar";
            buscar.Size = new Size(59, 29);
            buscar.TabIndex = 97;
            buscar.UseVisualStyleBackColor = true;
            buscar.Click += buscar_Click;
            // 
            // textBoxCategoria
            // 
            textBoxCategoria.Location = new Point(28, 160);
            textBoxCategoria.Name = "textBoxCategoria";
            textBoxCategoria.Size = new Size(278, 23);
            textBoxCategoria.TabIndex = 4;
            // 
            // textBoxDuracao
            // 
            textBoxDuracao.Location = new Point(28, 105);
            textBoxDuracao.Name = "textBoxDuracao";
            textBoxDuracao.Size = new Size(155, 23);
            textBoxDuracao.TabIndex = 3;
            // 
            // textBoxNomeBusca
            // 
            textBoxNomeBusca.Location = new Point(37, 56);
            textBoxNomeBusca.Name = "textBoxNomeBusca";
            textBoxNomeBusca.Size = new Size(155, 23);
            textBoxNomeBusca.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(28, 137);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 96;
            label4.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 82);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 95;
            label3.Text = "Duração";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 8);
            label1.Name = "label1";
            label1.Size = new Size(305, 20);
            label1.TabIndex = 93;
            label1.Text = "Digite o Nome do filme que deseja Buscar.";
            // 
            // TelaNome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 304);
            Controls.Add(textBoxFaixa);
            Controls.Add(label7);
            Controls.Add(textBoxData);
            Controls.Add(label6);
            Controls.Add(buscar);
            Controls.Add(textBoxCategoria);
            Controls.Add(textBoxDuracao);
            Controls.Add(textBoxNomeBusca);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaNome";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaNome";
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
        private Button buscar;
        private TextBox textBoxCategoria;
        private TextBox textBoxDuracao;
        private TextBox textBoxCod;
        private TextBox textBoxNomeBusca;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}