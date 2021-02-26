
namespace View
{
    partial class frmConsultaPessoaEvento
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
            this.cbPessoa = new System.Windows.Forms.ComboBox();
            this.lblBusca = new System.Windows.Forms.Label();
            this.dgvPessoaEvento = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoaEvento)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPessoa
            // 
            this.cbPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPessoa.FormattingEnabled = true;
            this.cbPessoa.Location = new System.Drawing.Point(10, 32);
            this.cbPessoa.Name = "cbPessoa";
            this.cbPessoa.Size = new System.Drawing.Size(325, 28);
            this.cbPessoa.TabIndex = 0;
            this.cbPessoa.SelectedIndexChanged += new System.EventHandler(this.cbEvento_SelectedIndexChanged);
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusca.Location = new System.Drawing.Point(6, 9);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(143, 20);
            this.lblBusca.TabIndex = 1;
            this.lblBusca.Text = "Buscar por Pessoa";
            // 
            // dgvPessoaEvento
            // 
            this.dgvPessoaEvento.AllowUserToAddRows = false;
            this.dgvPessoaEvento.AllowUserToDeleteRows = false;
            this.dgvPessoaEvento.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPessoaEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoaEvento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvPessoaEvento.Location = new System.Drawing.Point(10, 66);
            this.dgvPessoaEvento.Name = "dgvPessoaEvento";
            this.dgvPessoaEvento.ReadOnly = true;
            this.dgvPessoaEvento.RowHeadersVisible = false;
            this.dgvPessoaEvento.Size = new System.Drawing.Size(480, 150);
            this.dgvPessoaEvento.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Códigp";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Pessoa";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "1° Etapa";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "2° Etapa";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // frmConsultaPessoaEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 221);
            this.Controls.Add(this.dgvPessoaEvento);
            this.Controls.Add(this.lblBusca);
            this.Controls.Add(this.cbPessoa);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaPessoaEvento";
            this.Text = "Consulta de Pessoas p/ Evento";
            this.Load += new System.EventHandler(this.frmConsultaPessoaEvento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoaEvento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPessoa;
        private System.Windows.Forms.Label lblBusca;
        private System.Windows.Forms.DataGridView dgvPessoaEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}