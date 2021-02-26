
namespace View
{
    partial class frmTrocaSala
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
            this.cbEvento1 = new System.Windows.Forms.ComboBox();
            this.cbEvento2 = new System.Windows.Forms.ComboBox();
            this.lblEvento1 = new System.Windows.Forms.Label();
            this.lblEvento2 = new System.Windows.Forms.Label();
            this.dgvEvento1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEvento2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTroca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvento1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvento2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEvento1
            // 
            this.cbEvento1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEvento1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEvento1.FormattingEnabled = true;
            this.cbEvento1.Location = new System.Drawing.Point(9, 32);
            this.cbEvento1.Name = "cbEvento1";
            this.cbEvento1.Size = new System.Drawing.Size(230, 28);
            this.cbEvento1.TabIndex = 0;
            this.cbEvento1.SelectedIndexChanged += new System.EventHandler(this.cbEvento1_SelectedIndexChanged);
            // 
            // cbEvento2
            // 
            this.cbEvento2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEvento2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEvento2.FormattingEnabled = true;
            this.cbEvento2.Location = new System.Drawing.Point(271, 32);
            this.cbEvento2.Name = "cbEvento2";
            this.cbEvento2.Size = new System.Drawing.Size(230, 28);
            this.cbEvento2.TabIndex = 1;
            this.cbEvento2.SelectedIndexChanged += new System.EventHandler(this.cbEvento2_SelectedIndexChanged);
            // 
            // lblEvento1
            // 
            this.lblEvento1.AutoSize = true;
            this.lblEvento1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvento1.Location = new System.Drawing.Point(5, 9);
            this.lblEvento1.Name = "lblEvento1";
            this.lblEvento1.Size = new System.Drawing.Size(59, 20);
            this.lblEvento1.TabIndex = 2;
            this.lblEvento1.Text = "Evento";
            // 
            // lblEvento2
            // 
            this.lblEvento2.AutoSize = true;
            this.lblEvento2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvento2.Location = new System.Drawing.Point(267, 9);
            this.lblEvento2.Name = "lblEvento2";
            this.lblEvento2.Size = new System.Drawing.Size(59, 20);
            this.lblEvento2.TabIndex = 2;
            this.lblEvento2.Text = "Evento";
            // 
            // dgvEvento1
            // 
            this.dgvEvento1.AllowUserToAddRows = false;
            this.dgvEvento1.AllowUserToDeleteRows = false;
            this.dgvEvento1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEvento1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvento1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvEvento1.Location = new System.Drawing.Point(9, 66);
            this.dgvEvento1.Name = "dgvEvento1";
            this.dgvEvento1.ReadOnly = true;
            this.dgvEvento1.RowHeadersVisible = false;
            this.dgvEvento1.Size = new System.Drawing.Size(230, 216);
            this.dgvEvento1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Pessoa";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 225;
            // 
            // dgvEvento2
            // 
            this.dgvEvento2.AllowUserToAddRows = false;
            this.dgvEvento2.AllowUserToDeleteRows = false;
            this.dgvEvento2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEvento2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvento2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvEvento2.Location = new System.Drawing.Point(271, 66);
            this.dgvEvento2.Name = "dgvEvento2";
            this.dgvEvento2.ReadOnly = true;
            this.dgvEvento2.RowHeadersVisible = false;
            this.dgvEvento2.Size = new System.Drawing.Size(230, 216);
            this.dgvEvento2.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Pessoa";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 225;
            // 
            // btnTroca
            // 
            this.btnTroca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroca.Location = new System.Drawing.Point(215, 288);
            this.btnTroca.Name = "btnTroca";
            this.btnTroca.Size = new System.Drawing.Size(79, 28);
            this.btnTroca.TabIndex = 4;
            this.btnTroca.Text = "Trocar";
            this.btnTroca.UseVisualStyleBackColor = true;
            this.btnTroca.Click += new System.EventHandler(this.btnTroca_Click);
            // 
            // frmTrocaSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 319);
            this.Controls.Add(this.btnTroca);
            this.Controls.Add(this.dgvEvento2);
            this.Controls.Add(this.dgvEvento1);
            this.Controls.Add(this.lblEvento2);
            this.Controls.Add(this.lblEvento1);
            this.Controls.Add(this.cbEvento2);
            this.Controls.Add(this.cbEvento1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTrocaSala";
            this.Text = "Troca de Sala";
            this.Load += new System.EventHandler(this.frmTrocaSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvento1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvento2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEvento1;
        private System.Windows.Forms.ComboBox cbEvento2;
        private System.Windows.Forms.Label lblEvento1;
        private System.Windows.Forms.Label lblEvento2;
        private System.Windows.Forms.DataGridView dgvEvento1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dgvEvento2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnTroca;
    }
}