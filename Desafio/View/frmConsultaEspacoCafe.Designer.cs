
namespace View
{
    partial class frmConsultaEspacoCafe
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
            this.dgvEspacoCafe = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.cbEspaco = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspacoCafe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEspacoCafe
            // 
            this.dgvEspacoCafe.AllowUserToAddRows = false;
            this.dgvEspacoCafe.AllowUserToDeleteRows = false;
            this.dgvEspacoCafe.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEspacoCafe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspacoCafe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNome});
            this.dgvEspacoCafe.Location = new System.Drawing.Point(5, 64);
            this.dgvEspacoCafe.Name = "dgvEspacoCafe";
            this.dgvEspacoCafe.ReadOnly = true;
            this.dgvEspacoCafe.RowHeadersVisible = false;
            this.dgvEspacoCafe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEspacoCafe.Size = new System.Drawing.Size(255, 150);
            this.dgvEspacoCafe.TabIndex = 2;
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
            this.ColumnNome.HeaderText = "Pessoa";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 200;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(1, 9);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(139, 20);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar pelo Nome";
            // 
            // cbEspaco
            // 
            this.cbEspaco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEspaco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEspaco.FormattingEnabled = true;
            this.cbEspaco.Location = new System.Drawing.Point(5, 32);
            this.cbEspaco.Name = "cbEspaco";
            this.cbEspaco.Size = new System.Drawing.Size(255, 28);
            this.cbEspaco.TabIndex = 1;
            this.cbEspaco.SelectedIndexChanged += new System.EventHandler(this.cbEspaco_SelectedIndexChanged);
            // 
            // frmConsultaEspacoCafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 218);
            this.Controls.Add(this.cbEspaco);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.dgvEspacoCafe);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaEspacoCafe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Espaço de Cafe";
            this.Load += new System.EventHandler(this.frmConsultaEspacoCafe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspacoCafe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEspacoCafe;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.ComboBox cbEspaco;
    }
}