
namespace View
{
    partial class frmSalaEvento
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
            this.lblId = new System.Windows.Forms.Label();
            this.dgvSalaEvento = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLotacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblLotacao = new System.Windows.Forms.Label();
            this.nudLotacao = new System.Windows.Forms.NumericUpDown();
            this.btnDesativar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaEvento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLotacao)).BeginInit();
            this.SuspendLayout();
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
            // dgvSalaEvento
            // 
            this.dgvSalaEvento.AllowUserToAddRows = false;
            this.dgvSalaEvento.AllowUserToDeleteRows = false;
            this.dgvSalaEvento.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSalaEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalaEvento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNome,
            this.ColumnLotacao});
            this.dgvSalaEvento.Location = new System.Drawing.Point(6, 129);
            this.dgvSalaEvento.Name = "dgvSalaEvento";
            this.dgvSalaEvento.ReadOnly = true;
            this.dgvSalaEvento.RowHeadersVisible = false;
            this.dgvSalaEvento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalaEvento.Size = new System.Drawing.Size(280, 150);
            this.dgvSalaEvento.TabIndex = 1;
            this.dgvSalaEvento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalaEvento_CellDoubleClick);
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "Código";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Width = 50;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnLotacao
            // 
            this.ColumnLotacao.HeaderText = "Lotação Máxima";
            this.ColumnLotacao.Name = "ColumnLotacao";
            this.ColumnLotacao.ReadOnly = true;
            this.ColumnLotacao.Width = 125;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(2, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(6, 48);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(147, 26);
            this.txtNome.TabIndex = 3;
            // 
            // lblLotacao
            // 
            this.lblLotacao.AutoSize = true;
            this.lblLotacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLotacao.Location = new System.Drawing.Point(161, 25);
            this.lblLotacao.Name = "lblLotacao";
            this.lblLotacao.Size = new System.Drawing.Size(125, 20);
            this.lblLotacao.TabIndex = 4;
            this.lblLotacao.Text = "Lotação Máxima";
            // 
            // nudLotacao
            // 
            this.nudLotacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLotacao.Location = new System.Drawing.Point(165, 48);
            this.nudLotacao.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudLotacao.Name = "nudLotacao";
            this.nudLotacao.Size = new System.Drawing.Size(121, 26);
            this.nudLotacao.TabIndex = 5;
            // 
            // btnDesativar
            // 
            this.btnDesativar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesativar.Location = new System.Drawing.Point(195, 91);
            this.btnDesativar.Name = "btnDesativar";
            this.btnDesativar.Size = new System.Drawing.Size(91, 32);
            this.btnDesativar.TabIndex = 6;
            this.btnDesativar.Text = "Desativar";
            this.btnDesativar.UseVisualStyleBackColor = true;
            this.btnDesativar.Click += new System.EventHandler(this.btnDesativar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(114, 91);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 32);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmSalaEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(292, 282);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnDesativar);
            this.Controls.Add(this.nudLotacao);
            this.Controls.Add(this.lblLotacao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.dgvSalaEvento);
            this.Controls.Add(this.lblId);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSalaEvento";
            this.Text = "Sala de Eventos";
            this.Load += new System.EventHandler(this.frmSalaEvento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaEvento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLotacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dgvSalaEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLotacao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblLotacao;
        private System.Windows.Forms.NumericUpDown nudLotacao;
        private System.Windows.Forms.Button btnDesativar;
        private System.Windows.Forms.Button btnSalvar;
    }
}