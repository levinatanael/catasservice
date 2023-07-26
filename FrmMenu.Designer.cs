namespace CatAsService
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuBuscaGatos = new System.Windows.Forms.MenuStrip();
            this.buscarRacasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuBuscaGatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBuscaGatos
            // 
            this.menuBuscaGatos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarRacasMenuItem});
            this.menuBuscaGatos.Location = new System.Drawing.Point(0, 0);
            this.menuBuscaGatos.Name = "menuBuscaGatos";
            this.menuBuscaGatos.Size = new System.Drawing.Size(606, 24);
            this.menuBuscaGatos.TabIndex = 1;
            this.menuBuscaGatos.Text = "menuStrip1";
            // 
            // buscarRacasMenuItem
            // 
            this.buscarRacasMenuItem.Name = "buscarRacasMenuItem";
            this.buscarRacasMenuItem.Size = new System.Drawing.Size(87, 20);
            this.buscarRacasMenuItem.Text = "Buscar &Raças";
            this.buscarRacasMenuItem.Click += new System.EventHandler(this.BuscarRacasMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CatAsService.Properties.Resources.cats;
            this.pictureBox1.Location = new System.Drawing.Point(174, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 270);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Miau!";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuBuscaGatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBuscaGatos;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre gatos - Versão 0.0.1";
            this.menuBuscaGatos.ResumeLayout(false);
            this.menuBuscaGatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuBuscaGatos;
        private System.Windows.Forms.ToolStripMenuItem buscarRacasMenuItem;
    }
}

