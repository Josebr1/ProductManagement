namespace ProductManagement
{
    partial class FrmReProvider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReProvider));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.printPreviewDialogProvider = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentProvider = new System.Drawing.Printing.PrintDocument();
            this.printDialogProvider = new System.Windows.Forms.PrintDialog();
            this.buttonViewPrint = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buttonPrint = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridViewProvider = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // printPreviewDialogProvider
            // 
            this.printPreviewDialogProvider.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogProvider.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogProvider.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogProvider.Document = this.printDocumentProvider;
            this.printPreviewDialogProvider.Enabled = true;
            this.printPreviewDialogProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogProvider.Icon")));
            this.printPreviewDialogProvider.Name = "printPreviewDialogProvider";
            this.printPreviewDialogProvider.Visible = false;
            this.printPreviewDialogProvider.Load += new System.EventHandler(this.printPreviewDialogProvider_Load);
            // 
            // printDocumentProvider
            // 
            this.printDocumentProvider.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentProvider_PrintPage);
            // 
            // printDialogProvider
            // 
            this.printDialogProvider.Document = this.printDocumentProvider;
            this.printDialogProvider.UseEXDialog = true;
            // 
            // buttonViewPrint
            // 
            this.buttonViewPrint.ActiveBorderThickness = 1;
            this.buttonViewPrint.ActiveCornerRadius = 20;
            this.buttonViewPrint.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.buttonViewPrint.ActiveForecolor = System.Drawing.Color.White;
            this.buttonViewPrint.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.buttonViewPrint.BackColor = System.Drawing.SystemColors.Control;
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
            this.buttonViewPrint.Location = new System.Drawing.Point(8, 565);
            this.buttonViewPrint.Margin = new System.Windows.Forms.Padding(5);
            this.buttonViewPrint.Name = "buttonViewPrint";
            this.buttonViewPrint.Size = new System.Drawing.Size(191, 41);
            this.buttonViewPrint.TabIndex = 64;
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
            this.buttonPrint.BackColor = System.Drawing.SystemColors.Control;
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
            this.buttonPrint.Location = new System.Drawing.Point(8, 511);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(5);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(339, 41);
            this.buttonPrint.TabIndex = 63;
            this.buttonPrint.Tag = "";
            this.buttonPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // dataGridViewProvider
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewProvider.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProvider.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewProvider.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProvider.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProvider.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProvider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProvider.DoubleBuffered = true;
            this.dataGridViewProvider.EnableHeadersVisualStyles = false;
            this.dataGridViewProvider.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewProvider.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.dataGridViewProvider.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewProvider.Location = new System.Drawing.Point(8, 75);
            this.dataGridViewProvider.Name = "dataGridViewProvider";
            this.dataGridViewProvider.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewProvider.Size = new System.Drawing.Size(953, 379);
            this.dataGridViewProvider.TabIndex = 62;
            // 
            // FrmReProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 620);
            this.Controls.Add(this.buttonViewPrint);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.dataGridViewProvider);
            this.Name = "FrmReProvider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Fornecedores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogProvider;
        private System.Drawing.Printing.PrintDocument printDocumentProvider;
        private System.Windows.Forms.PrintDialog printDialogProvider;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonViewPrint;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonPrint;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridViewProvider;
    }
}