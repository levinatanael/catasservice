namespace CatAsService
{
    partial class FrmBuscarRacas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarRacas));
            this.lblNomeRaca = new System.Windows.Forms.Label();
            this.gpbSelecionaRaca = new System.Windows.Forms.GroupBox();
            this.btnBuscarInformacoes = new System.Windows.Forms.Button();
            this.cboRacas = new System.Windows.Forms.ComboBox();
            this.dpbInfoRaca = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtMediaIdade = new System.Windows.Forms.TextBox();
            this.txtPaisOrigem = new System.Windows.Forms.TextBox();
            this.txtTemperamento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFavoritarRaca = new System.Windows.Forms.Button();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.btnMudarImagem = new System.Windows.Forms.Button();
            this.pcbImagem = new System.Windows.Forms.PictureBox();
            this.timerInicializacao = new System.Windows.Forms.Timer(this.components);
            this.gpbSelecionaRaca.SuspendLayout();
            this.dpbInfoRaca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeRaca
            // 
            this.lblNomeRaca.AutoSize = true;
            this.lblNomeRaca.Location = new System.Drawing.Point(17, 30);
            this.lblNomeRaca.Name = "lblNomeRaca";
            this.lblNomeRaca.Size = new System.Drawing.Size(77, 13);
            this.lblNomeRaca.TabIndex = 0;
            this.lblNomeRaca.Text = "Nome da raça:";
            // 
            // gpbSelecionaRaca
            // 
            this.gpbSelecionaRaca.Controls.Add(this.btnBuscarInformacoes);
            this.gpbSelecionaRaca.Controls.Add(this.cboRacas);
            this.gpbSelecionaRaca.Controls.Add(this.lblNomeRaca);
            this.gpbSelecionaRaca.Location = new System.Drawing.Point(12, 12);
            this.gpbSelecionaRaca.Name = "gpbSelecionaRaca";
            this.gpbSelecionaRaca.Size = new System.Drawing.Size(582, 66);
            this.gpbSelecionaRaca.TabIndex = 1;
            this.gpbSelecionaRaca.TabStop = false;
            this.gpbSelecionaRaca.Text = "Selecione uma raça:";
            // 
            // btnBuscarInformacoes
            // 
            this.btnBuscarInformacoes.Enabled = false;
            this.btnBuscarInformacoes.Location = new System.Drawing.Point(408, 25);
            this.btnBuscarInformacoes.Name = "btnBuscarInformacoes";
            this.btnBuscarInformacoes.Size = new System.Drawing.Size(153, 23);
            this.btnBuscarInformacoes.TabIndex = 2;
            this.btnBuscarInformacoes.Tag = "Clique aqui para carregar as informações";
            this.btnBuscarInformacoes.Text = "Buscar informações";
            this.btnBuscarInformacoes.UseVisualStyleBackColor = true;
            this.btnBuscarInformacoes.Click += new System.EventHandler(this.BtnBuscarInformacoes_Click);
            // 
            // cboRacas
            // 
            this.cboRacas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRacas.Enabled = false;
            this.cboRacas.FormattingEnabled = true;
            this.cboRacas.Location = new System.Drawing.Point(100, 27);
            this.cboRacas.Name = "cboRacas";
            this.cboRacas.Size = new System.Drawing.Size(302, 21);
            this.cboRacas.TabIndex = 1;
            // 
            // dpbInfoRaca
            // 
            this.dpbInfoRaca.Controls.Add(this.btnMudarImagem);
            this.dpbInfoRaca.Controls.Add(this.label5);
            this.dpbInfoRaca.Controls.Add(this.pcbImagem);
            this.dpbInfoRaca.Controls.Add(this.txtDescricao);
            this.dpbInfoRaca.Controls.Add(this.txtMediaIdade);
            this.dpbInfoRaca.Controls.Add(this.txtPaisOrigem);
            this.dpbInfoRaca.Controls.Add(this.txtTemperamento);
            this.dpbInfoRaca.Controls.Add(this.label4);
            this.dpbInfoRaca.Controls.Add(this.label3);
            this.dpbInfoRaca.Controls.Add(this.label2);
            this.dpbInfoRaca.Controls.Add(this.label1);
            this.dpbInfoRaca.Location = new System.Drawing.Point(12, 84);
            this.dpbInfoRaca.Name = "dpbInfoRaca";
            this.dpbInfoRaca.Size = new System.Drawing.Size(582, 498);
            this.dpbInfoRaca.TabIndex = 2;
            this.dpbInfoRaca.TabStop = false;
            this.dpbInfoRaca.Text = "Informações da Raça";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Imagem:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(112, 112);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricao.Size = new System.Drawing.Size(449, 84);
            this.txtDescricao.TabIndex = 7;
            // 
            // txtMediaIdade
            // 
            this.txtMediaIdade.Location = new System.Drawing.Point(112, 86);
            this.txtMediaIdade.Name = "txtMediaIdade";
            this.txtMediaIdade.ReadOnly = true;
            this.txtMediaIdade.Size = new System.Drawing.Size(449, 20);
            this.txtMediaIdade.TabIndex = 6;
            // 
            // txtPaisOrigem
            // 
            this.txtPaisOrigem.Location = new System.Drawing.Point(112, 60);
            this.txtPaisOrigem.Name = "txtPaisOrigem";
            this.txtPaisOrigem.ReadOnly = true;
            this.txtPaisOrigem.Size = new System.Drawing.Size(449, 20);
            this.txtPaisOrigem.TabIndex = 5;
            // 
            // txtTemperamento
            // 
            this.txtTemperamento.Location = new System.Drawing.Point(112, 34);
            this.txtTemperamento.Name = "txtTemperamento";
            this.txtTemperamento.ReadOnly = true;
            this.txtTemperamento.Size = new System.Drawing.Size(449, 20);
            this.txtTemperamento.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Média de Idade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "País de Origem:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperamento:";
            // 
            // btnFavoritarRaca
            // 
            this.btnFavoritarRaca.Location = new System.Drawing.Point(344, 594);
            this.btnFavoritarRaca.Name = "btnFavoritarRaca";
            this.btnFavoritarRaca.Size = new System.Drawing.Size(122, 23);
            this.btnFavoritarRaca.TabIndex = 3;
            this.btnFavoritarRaca.Text = "Favoritar &raça [beta]";
            this.btnFavoritarRaca.UseVisualStyleBackColor = true;
            this.btnFavoritarRaca.Visible = false;
            // 
            // btnConcluir
            // 
            this.btnConcluir.Location = new System.Drawing.Point(472, 594);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(122, 23);
            this.btnConcluir.TabIndex = 4;
            this.btnConcluir.Text = "&Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // btnMudarImagem
            // 
            this.btnMudarImagem.Enabled = false;
            this.btnMudarImagem.Image = global::CatAsService.Properties.Resources.reloa;
            this.btnMudarImagem.Location = new System.Drawing.Point(47, 218);
            this.btnMudarImagem.Name = "btnMudarImagem";
            this.btnMudarImagem.Size = new System.Drawing.Size(57, 57);
            this.btnMudarImagem.TabIndex = 10;
            this.btnMudarImagem.Tag = "Buscar nova imagem";
            this.btnMudarImagem.UseVisualStyleBackColor = true;
            this.btnMudarImagem.Click += new System.EventHandler(this.BtnMudarImagem_Click);
            // 
            // pcbImagem
            // 
            this.pcbImagem.Location = new System.Drawing.Point(112, 202);
            this.pcbImagem.Name = "pcbImagem";
            this.pcbImagem.Size = new System.Drawing.Size(449, 276);
            this.pcbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImagem.TabIndex = 8;
            this.pcbImagem.TabStop = false;
            this.pcbImagem.Tag = "Imagem do gatinho!";
            // 
            // timerInicializacao
            // 
            this.timerInicializacao.Interval = 300;
            this.timerInicializacao.Tick += new System.EventHandler(this.timerInicializacao_Tick);
            // 
            // FrmBuscarRacas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 629);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.btnFavoritarRaca);
            this.Controls.Add(this.dpbInfoRaca);
            this.Controls.Add(this.gpbSelecionaRaca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBuscarRacas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre gatos - Buscar Raças";
            this.Load += new System.EventHandler(this.FrmBuscarRacas_Load);
            this.gpbSelecionaRaca.ResumeLayout(false);
            this.gpbSelecionaRaca.PerformLayout();
            this.dpbInfoRaca.ResumeLayout(false);
            this.dpbInfoRaca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem buscarCategoriasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarRacasMenuItem;
        private System.Windows.Forms.Label lblNomeRaca;
        private System.Windows.Forms.GroupBox gpbSelecionaRaca;
        private System.Windows.Forms.Button btnBuscarInformacoes;
        private System.Windows.Forms.ComboBox cboRacas;
        private System.Windows.Forms.GroupBox dpbInfoRaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTemperamento;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtMediaIdade;
        private System.Windows.Forms.TextBox txtPaisOrigem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pcbImagem;
        private System.Windows.Forms.Button btnFavoritarRaca;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Button btnMudarImagem;
        private System.Windows.Forms.Timer timerInicializacao;
    }
}

