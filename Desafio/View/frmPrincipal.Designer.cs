namespace View
{
    partial class frmPrincipal
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
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPessoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalaEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEspacoCafe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultaPessoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultaSalaEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultaEspacoCafe = new System.Windows.Forms.ToolStripMenuItem();
            this.msPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.msPrincipal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastro,
            this.tsmConsulta});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(524, 27);
            this.msPrincipal.TabIndex = 0;
            // 
            // tsmCadastro
            // 
            this.tsmCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPessoa,
            this.tsmSalaEvento,
            this.tsmEspacoCafe});
            this.tsmCadastro.Name = "tsmCadastro";
            this.tsmCadastro.Size = new System.Drawing.Size(77, 23);
            this.tsmCadastro.Text = "Cadastro";
            this.tsmCadastro.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // tsmPessoa
            // 
            this.tsmPessoa.Name = "tsmPessoa";
            this.tsmPessoa.Size = new System.Drawing.Size(180, 24);
            this.tsmPessoa.Text = "Pessoa";
            this.tsmPessoa.Click += new System.EventHandler(this.tsmPessoa_Click);
            // 
            // tsmSalaEvento
            // 
            this.tsmSalaEvento.Name = "tsmSalaEvento";
            this.tsmSalaEvento.Size = new System.Drawing.Size(180, 24);
            this.tsmSalaEvento.Text = "Sala Evento";
            this.tsmSalaEvento.Click += new System.EventHandler(this.tsmSalaEvento_Click);
            // 
            // tsmEspacoCafe
            // 
            this.tsmEspacoCafe.Name = "tsmEspacoCafe";
            this.tsmEspacoCafe.Size = new System.Drawing.Size(180, 24);
            this.tsmEspacoCafe.Text = "Espaço Café";
            this.tsmEspacoCafe.Click += new System.EventHandler(this.tsmEspacoCafe_Click);
            // 
            // tsmConsulta
            // 
            this.tsmConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmConsultaPessoa,
            this.tsmConsultaSalaEvento,
            this.tsmConsultaEspacoCafe});
            this.tsmConsulta.Name = "tsmConsulta";
            this.tsmConsulta.Size = new System.Drawing.Size(74, 23);
            this.tsmConsulta.Text = "Consulta";
            // 
            // tsmConsultaPessoa
            // 
            this.tsmConsultaPessoa.Name = "tsmConsultaPessoa";
            this.tsmConsultaPessoa.Size = new System.Drawing.Size(180, 24);
            this.tsmConsultaPessoa.Text = "Pessoa";
            this.tsmConsultaPessoa.Click += new System.EventHandler(this.tsmConsultaPessoa_Click);
            // 
            // tsmConsultaSalaEvento
            // 
            this.tsmConsultaSalaEvento.Name = "tsmConsultaSalaEvento";
            this.tsmConsultaSalaEvento.Size = new System.Drawing.Size(180, 24);
            this.tsmConsultaSalaEvento.Text = "Sala Evento";
            this.tsmConsultaSalaEvento.Click += new System.EventHandler(this.tsmConsultaSalaEvento_Click);
            // 
            // tsmConsultaEspacoCafe
            // 
            this.tsmConsultaEspacoCafe.Name = "tsmConsultaEspacoCafe";
            this.tsmConsultaEspacoCafe.Size = new System.Drawing.Size(180, 24);
            this.tsmConsultaEspacoCafe.Text = "Espaço Café";
            this.tsmConsultaEspacoCafe.Click += new System.EventHandler(this.tsmConsultaEspacoCafe_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 279);
            this.Controls.Add(this.msPrincipal);
            this.MainMenuStrip = this.msPrincipal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Tela Principal";
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastro;
        private System.Windows.Forms.ToolStripMenuItem tsmConsulta;
        private System.Windows.Forms.ToolStripMenuItem tsmPessoa;
        private System.Windows.Forms.ToolStripMenuItem tsmSalaEvento;
        private System.Windows.Forms.ToolStripMenuItem tsmEspacoCafe;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultaPessoa;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultaSalaEvento;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultaEspacoCafe;
    }
}

