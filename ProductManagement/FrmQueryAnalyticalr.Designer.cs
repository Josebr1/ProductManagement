namespace ProductManagement
{
    partial class FrmQueryAnalyticalr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.dropdownTable = new System.Windows.Forms.ComboBox();
            this.dropdownFieds = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.DoubleBuffered = true;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.dataGridView.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridView.Location = new System.Drawing.Point(41, 183);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.Size = new System.Drawing.Size(915, 443);
            this.dataGridView.TabIndex = 60;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(37, 100);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(249, 19);
            this.lblTitle.TabIndex = 59;
            this.lblTitle.Text = "Escolha o campo a ser pesquisado:";
            // 
            // dropdownTable
            // 
            this.dropdownTable.FormattingEnabled = true;
            this.dropdownTable.Items.AddRange(new object[] {
            "Fornecedores",
            "Produtos"});
            this.dropdownTable.Location = new System.Drawing.Point(41, 137);
            this.dropdownTable.Name = "dropdownTable";
            this.dropdownTable.Size = new System.Drawing.Size(355, 21);
            this.dropdownTable.TabIndex = 62;
            this.dropdownTable.SelectedIndexChanged += new System.EventHandler(this.dropdownTable_SelectedIndexChanged);
            // 
            // dropdownFieds
            // 
            this.dropdownFieds.FormattingEnabled = true;
            this.dropdownFieds.Location = new System.Drawing.Point(403, 136);
            this.dropdownFieds.Name = "dropdownFieds";
            this.dropdownFieds.Size = new System.Drawing.Size(553, 21);
            this.dropdownFieds.TabIndex = 63;
            this.dropdownFieds.SelectedIndexChanged += new System.EventHandler(this.dropdownFieds_SelectedIndexChanged);
            // 
            // FrmQueryAnalyticalr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 659);
            this.Controls.Add(this.dropdownFieds);
            this.Controls.Add(this.dropdownTable);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmQueryAnalyticalr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Analítica";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private System.Windows.Forms.ComboBox dropdownTable;
        private System.Windows.Forms.ComboBox dropdownFieds;
    }
}