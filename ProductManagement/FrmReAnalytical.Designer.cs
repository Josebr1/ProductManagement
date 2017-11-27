namespace ProductManagement
{
    partial class FrmReAnalytical
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReAnalytical));
            this.dataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.buttonViewPrint = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buttonPrint = new Bunifu.Framework.UI.BunifuThinButton2();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.bunifuDropdown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.DoubleBuffered = true;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataGrid.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dataGrid.Location = new System.Drawing.Point(12, 165);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid.Size = new System.Drawing.Size(938, 384);
            this.dataGrid.TabIndex = 1;
            // 
            // buttonViewPrint
            // 
            this.buttonViewPrint.ActiveBorderThickness = 1;
            this.buttonViewPrint.ActiveCornerRadius = 20;
            this.buttonViewPrint.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.buttonViewPrint.ActiveForecolor = System.Drawing.Color.White;
            this.buttonViewPrint.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.buttonViewPrint.BackColor = System.Drawing.Color.White;
            this.buttonViewPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonViewPrint.BackgroundImage")));
            this.buttonViewPrint.ButtonText = "Visualizar impressão";
            this.buttonViewPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewPrint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewPrint.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonViewPrint.IdleBorderThickness = 1;
            this.buttonViewPrint.IdleCornerRadius = 20;
            this.buttonViewPrint.IdleFillColor = System.Drawing.Color.White;
            this.buttonViewPrint.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.buttonViewPrint.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.buttonViewPrint.Location = new System.Drawing.Point(759, 565);
            this.buttonViewPrint.Margin = new System.Windows.Forms.Padding(5);
            this.buttonViewPrint.Name = "buttonViewPrint";
            this.buttonViewPrint.Size = new System.Drawing.Size(191, 41);
            this.buttonViewPrint.TabIndex = 66;
            this.buttonViewPrint.Tag = "";
            this.buttonViewPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonViewPrint.Click += new System.EventHandler(this.buttonViewPrint_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.ActiveBorderThickness = 1;
            this.buttonPrint.ActiveCornerRadius = 20;
            this.buttonPrint.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.buttonPrint.ActiveForecolor = System.Drawing.Color.White;
            this.buttonPrint.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.buttonPrint.BackColor = System.Drawing.Color.White;
            this.buttonPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPrint.BackgroundImage")));
            this.buttonPrint.ButtonText = "Imprimir";
            this.buttonPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonPrint.IdleBorderThickness = 1;
            this.buttonPrint.IdleCornerRadius = 20;
            this.buttonPrint.IdleFillColor = System.Drawing.Color.White;
            this.buttonPrint.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.buttonPrint.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.buttonPrint.Location = new System.Drawing.Point(12, 565);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(5);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(339, 41);
            this.buttonPrint.TabIndex = 65;
            this.buttonPrint.Tag = "";
            this.buttonPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialogProvider";
            this.printPreviewDialog.Visible = false;
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // bunifuDropdown
            // 
            this.bunifuDropdown.FormattingEnabled = true;
            this.bunifuDropdown.Items.AddRange(new object[] {
            "Agrupado por Nome Fantasia do Fornecedor",
            "Agrupado por Descrição do Produto"});
            this.bunifuDropdown.Location = new System.Drawing.Point(283, 118);
            this.bunifuDropdown.Name = "bunifuDropdown";
            this.bunifuDropdown.Size = new System.Drawing.Size(381, 21);
            this.bunifuDropdown.TabIndex = 67;
            this.bunifuDropdown.SelectedIndexChanged += new System.EventHandler(this.bunifuDropdown_SelectedIndexChanged);
            // 
            // FrmReAnalytical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 620);
            this.Controls.Add(this.bunifuDropdown);
            this.Controls.Add(this.buttonViewPrint);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.dataGrid);
            this.Name = "FrmReAnalytical";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Analítico";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGrid;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonViewPrint;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonPrint;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.ComboBox bunifuDropdown;
    }
}