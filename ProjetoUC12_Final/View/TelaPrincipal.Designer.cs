namespace ProjetoUC12_Final.View
{
    partial class TelaPrincipal
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
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem1 = new ToolStripMenuItem();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            porCódigoToolStripMenuItem = new ToolStripMenuItem();
            porNomeToolStripMenuItem = new ToolStripMenuItem();
            porCategoriaToolStripMenuItem = new ToolStripMenuItem();
            alterarToolStripMenuItem = new ToolStripMenuItem();
            deletarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, cadastrarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem1, buscarToolStripMenuItem, alterarToolStripMenuItem, deletarToolStripMenuItem });
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(62, 20);
            cadastrarToolStripMenuItem.Text = "Produto";
            // 
            // cadastrarToolStripMenuItem1
            // 
            cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            cadastrarToolStripMenuItem1.Size = new Size(124, 22);
            cadastrarToolStripMenuItem1.Text = "Cadastrar";
            cadastrarToolStripMenuItem1.Click += cadastrarToolStripMenuItem1_Click;
            // 
            // buscarToolStripMenuItem
            // 
            buscarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { porCódigoToolStripMenuItem, porNomeToolStripMenuItem, porCategoriaToolStripMenuItem });
            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.Size = new Size(124, 22);
            buscarToolStripMenuItem.Text = "Buscar";
            // 
            // porCódigoToolStripMenuItem
            // 
            porCódigoToolStripMenuItem.Name = "porCódigoToolStripMenuItem";
            porCódigoToolStripMenuItem.Size = new Size(146, 22);
            porCódigoToolStripMenuItem.Text = "Por Código";
            porCódigoToolStripMenuItem.Click += porCódigoToolStripMenuItem_Click;
            // 
            // porNomeToolStripMenuItem
            // 
            porNomeToolStripMenuItem.Name = "porNomeToolStripMenuItem";
            porNomeToolStripMenuItem.Size = new Size(146, 22);
            porNomeToolStripMenuItem.Text = "Por Nome";
            porNomeToolStripMenuItem.Click += porNomeToolStripMenuItem_Click;
            // 
            // porCategoriaToolStripMenuItem
            // 
            porCategoriaToolStripMenuItem.Name = "porCategoriaToolStripMenuItem";
            porCategoriaToolStripMenuItem.Size = new Size(146, 22);
            porCategoriaToolStripMenuItem.Text = "Por Categoria";
            porCategoriaToolStripMenuItem.Click += porCategoriaToolStripMenuItem_Click;
            // 
            // alterarToolStripMenuItem
            // 
            alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            alterarToolStripMenuItem.Size = new Size(124, 22);
            alterarToolStripMenuItem.Text = "Alterar";
            alterarToolStripMenuItem.Click += alterarToolStripMenuItem_Click;
            // 
            // deletarToolStripMenuItem
            // 
            deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            deletarToolStripMenuItem.Size = new Size(124, 22);
            deletarToolStripMenuItem.Text = "Deletar";
            deletarToolStripMenuItem.Click += deletarToolStripMenuItem_Click;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaPrincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem1;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripMenuItem porCódigoToolStripMenuItem;
        private ToolStripMenuItem porNomeToolStripMenuItem;
        private ToolStripMenuItem porCategoriaToolStripMenuItem;
        private ToolStripMenuItem alterarToolStripMenuItem;
        private ToolStripMenuItem deletarToolStripMenuItem;
    }
}