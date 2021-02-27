
namespace View
{
    partial class frmPessoaCafe
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
            this.btnDesativar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbPessoa = new System.Windows.Forms.ComboBox();
            this.lblPessoa = new System.Windows.Forms.Label();
            this.cbEspaco = new System.Windows.Forms.ComboBox();
            this.lblEspaco = new System.Windows.Forms.Label();
            this.dgvPessoaEspaco = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoaEspaco)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDesativar
            // 
            this.btnDesativar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesativar.Location = new System.Drawing.Point(169, 134);
            this.btnDesativar.Name = "btnDesativar";
            this.btnDesativar.Size = new System.Drawing.Size(90, 30);
            this.btnDesativar.TabIndex = 6;
            this.btnDesativar.Text = "Desativar";
            this.btnDesativar.UseVisualStyleBackColor = true;
            this.btnDesativar.Click += new System.EventHandler(this.btnDesativar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(100, 134);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(63, 30);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cbPessoa
            // 
            this.cbPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPessoa.FormattingEnabled = true;
            this.cbPessoa.Location = new System.Drawing.Point(5, 94);
            this.cbPessoa.Name = "cbPessoa";
            this.cbPessoa.Size = new System.Drawing.Size(254, 28);
            this.cbPessoa.TabIndex = 4;
            // 
            // lblPessoa
            // 
            this.lblPessoa.AutoSize = true;
            this.lblPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPessoa.Location = new System.Drawing.Point(4, 71);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(62, 20);
            this.lblPessoa.TabIndex = 3;
            this.lblPessoa.Text = "Pessoa";
            // 
            // cbEspaco
            // 
            this.cbEspaco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEspaco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEspaco.FormattingEnabled = true;
            this.cbEspaco.Location = new System.Drawing.Point(5, 40);
            this.cbEspaco.Name = "cbEspaco";
            this.cbEspaco.Size = new System.Drawing.Size(254, 28);
            this.cbEspaco.TabIndex = 2;
            // 
            // lblEspaco
            // 
            this.lblEspaco.AutoSize = true;
            this.lblEspaco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspaco.Location = new System.Drawing.Point(1, 17);
            this.lblEspaco.Name = "lblEspaco";
            this.lblEspaco.Size = new System.Drawing.Size(63, 20);
            this.lblEspaco.TabIndex = 1;
            this.lblEspaco.Text = "Espaço";
            // 
            // dgvPessoaEspaco
            // 
            this.dgvPessoaEspaco.AllowUserToAddRows = false;
            this.dgvPessoaEspaco.AllowUserToDeleteRows = false;
            this.dgvPessoaEspaco.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPessoaEspaco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoaEspaco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4});
            this.dgvPessoaEspaco.Location = new System.Drawing.Point(5, 170);
            this.dgvPessoaEspaco.Name = "dgvPessoaEspaco";
            this.dgvPessoaEspaco.ReadOnly = true;
            this.dgvPessoaEspaco.RowHeadersVisible = false;
            this.dgvPessoaEspaco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPessoaEspaco.Size = new System.Drawing.Size(254, 150);
            this.dgvPessoaEspaco.TabIndex = 7;
            this.dgvPessoaEspaco.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPessoaEspaco_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Espaço";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Pessoa";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(-3, -3);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "0";
            this.lblId.Visible = false;
            // 
            // frmPessoaCafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 323);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnDesativar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbPessoa);
            this.Controls.Add(this.lblPessoa);
            this.Controls.Add(this.cbEspaco);
            this.Controls.Add(this.lblEspaco);
            this.Controls.Add(this.dgvPessoaEspaco);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPessoaCafe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pessoas por Espaço";
            this.Load += new System.EventHandler(this.frmPessoaCafe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoaEspaco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDesativar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbPessoa;
        private System.Windows.Forms.Label lblPessoa;
        private System.Windows.Forms.ComboBox cbEspaco;
        private System.Windows.Forms.Label lblEspaco;
        private System.Windows.Forms.DataGridView dgvPessoaEspaco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblId;
    }
}