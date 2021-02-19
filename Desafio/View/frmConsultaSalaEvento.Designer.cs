
namespace View
{
    partial class frmConsultaSalaEvento
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
            this.dgvSalaEvento = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLotacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaEvento)).BeginInit();
            this.SuspendLayout();
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
            this.dgvSalaEvento.Location = new System.Drawing.Point(5, 64);
            this.dgvSalaEvento.Name = "dgvSalaEvento";
            this.dgvSalaEvento.ReadOnly = true;
            this.dgvSalaEvento.RowHeadersVisible = false;
            this.dgvSalaEvento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalaEvento.Size = new System.Drawing.Size(280, 150);
            this.dgvSalaEvento.TabIndex = 2;
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
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(5, 32);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(280, 26);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(1, 9);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(139, 20);
            this.lblBuscar.TabIndex = 3;
            this.lblBuscar.Text = "Buscar pelo Nome";
            // 
            // frmConsultaSalaEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 218);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.dgvSalaEvento);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaSalaEvento";
            this.Text = "Consultar Sala de Evento";
            this.Load += new System.EventHandler(this.frmConsultaSalaEvento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaEvento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSalaEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLotacao;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
    }
}