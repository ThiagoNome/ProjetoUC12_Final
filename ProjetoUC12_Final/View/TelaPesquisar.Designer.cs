namespace ProjetoUC12_Final.View
{
    partial class TelaPesquisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPesquisar));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBoxFaixa = new TextBox();
            label7 = new Label();
            textBoxData = new TextBox();
            label1 = new Label();
            textBoxCod = new TextBox();
            textBoxCategoria = new TextBox();
            textBoxDuracao = new TextBox();
            textBoxNome = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            tabPage2 = new TabPage();
            btnNome = new Button();
            textBoxNomeFilme = new TextBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            pecas = new DataGridViewTextBoxColumn();
            Duração = new DataGridViewTextBoxColumn();
            categoria = new DataGridViewTextBoxColumn();
            dataLancamento = new DataGridViewTextBoxColumn();
            faixaetaria = new DataGridViewTextBoxColumn();
            label5 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 78);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(616, 349);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBoxFaixa);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(textBoxData);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBoxCod);
            tabPage1.Controls.Add(textBoxCategoria);
            tabPage1.Controls.Add(textBoxDuracao);
            tabPage1.Controls.Add(textBoxNome);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(608, 321);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Por Código";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxFaixa
            // 
            textBoxFaixa.Location = new Point(23, 290);
            textBoxFaixa.Name = "textBoxFaixa";
            textBoxFaixa.Size = new Size(155, 23);
            textBoxFaixa.TabIndex = 105;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(23, 267);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 107;
            label7.Text = "Faixa Etária";
            // 
            // textBoxData
            // 
            textBoxData.Location = new Point(23, 235);
            textBoxData.Name = "textBoxData";
            textBoxData.Size = new Size(278, 23);
            textBoxData.TabIndex = 104;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 212);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 106;
            label1.Text = "Data de Lançamento";
            // 
            // textBoxCod
            // 
            textBoxCod.Location = new Point(23, 15);
            textBoxCod.Name = "textBoxCod";
            textBoxCod.Size = new Size(155, 23);
            textBoxCod.TabIndex = 103;
            // 
            // textBoxCategoria
            // 
            textBoxCategoria.Location = new Point(23, 182);
            textBoxCategoria.Name = "textBoxCategoria";
            textBoxCategoria.Size = new Size(278, 23);
            textBoxCategoria.TabIndex = 99;
            // 
            // textBoxDuracao
            // 
            textBoxDuracao.Location = new Point(23, 127);
            textBoxDuracao.Name = "textBoxDuracao";
            textBoxDuracao.Size = new Size(155, 23);
            textBoxDuracao.TabIndex = 98;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(23, 73);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(229, 23);
            textBoxNome.TabIndex = 97;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(23, 159);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 102;
            label4.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(23, 104);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 101;
            label3.Text = "Duração";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 53);
            label2.Name = "label2";
            label2.Size = new Size(103, 17);
            label2.TabIndex = 100;
            label2.Text = "Nome do Filme";
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(194, 8);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnNome);
            tabPage2.Controls.Add(textBoxNomeFilme);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(608, 321);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Por Nome";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnNome
            // 
            btnNome.Image = (Image)resources.GetObject("btnNome.Image");
            btnNome.Location = new Point(327, 17);
            btnNome.Name = "btnNome";
            btnNome.Size = new Size(75, 34);
            btnNome.TabIndex = 11;
            btnNome.UseVisualStyleBackColor = true;
            btnNome.Click += btnNome_Click;
            // 
            // textBoxNomeFilme
            // 
            textBoxNomeFilme.Location = new Point(156, 23);
            textBoxNomeFilme.Name = "textBoxNomeFilme";
            textBoxNomeFilme.Size = new Size(155, 23);
            textBoxNomeFilme.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(36, 26);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 9;
            label6.Text = "Digite o Nome";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codigo, pecas, Duração, categoria, dataLancamento, faixaetaria });
            dataGridView1.Location = new Point(6, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(595, 255);
            dataGridView1.TabIndex = 0;
            // 
            // codigo
            // 
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            codigo.Width = 50;
            // 
            // pecas
            // 
            pecas.HeaderText = "Filme";
            pecas.Name = "pecas";
            pecas.ReadOnly = true;
            // 
            // Duração
            // 
            Duração.HeaderText = "Duração";
            Duração.Name = "Duração";
            Duração.ReadOnly = true;
            // 
            // categoria
            // 
            categoria.HeaderText = "Categoria";
            categoria.Name = "categoria";
            categoria.ReadOnly = true;
            // 
            // dataLancamento
            // 
            dataLancamento.HeaderText = "Data de lançamento";
            dataLancamento.Name = "dataLancamento";
            dataLancamento.ReadOnly = true;
            // 
            // faixaetaria
            // 
            faixaetaria.HeaderText = "Faixa Etária";
            faixaetaria.Name = "faixaetaria";
            faixaetaria.ReadOnly = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(166, 9);
            label5.Name = "label5";
            label5.Size = new Size(279, 25);
            label5.TabIndex = 2;
            label5.Text = "Setor de Pesquisas de Filmes";
            // 
            // TelaPesquisar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 432);
            Controls.Add(label5);
            Controls.Add(tabControl1);
            Name = "TelaPesquisar";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Setor de Pesquisas";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button1;
        private TabPage tabPage2;
        private Button btnNome;
        private TextBox textBoxNomeFilme;
        private Label label6;
        private DataGridView dataGridView1;
        private TextBox textBoxCod;
        private TextBox textBoxCategoria;
        private TextBox textBoxDuracao;
        private TextBox textBoxNome;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxFaixa;
        private Label label7;
        private TextBox textBoxData;
        private Label label1;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn pecas;
        private DataGridViewTextBoxColumn Duração;
        private DataGridViewTextBoxColumn categoria;
        private DataGridViewTextBoxColumn dataLancamento;
        private DataGridViewTextBoxColumn faixaetaria;
        private Label label5;
    }
}