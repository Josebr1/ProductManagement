namespace ProductManagement
{
    partial class FrmReProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReProducts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonViewPrint = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buttonPrint = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridViewProduct = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.printDocumentProduct = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogProduct = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialogProduct = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.SuspendLayout();
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
            this.buttonViewPrint.Location = new System.Drawing.Point(14, 604);
            this.buttonViewPrint.Margin = new System.Windows.Forms.Padding(5);
            this.buttonViewPrint.Name = "buttonViewPrint";
            this.buttonViewPrint.Size = new System.Drawing.Size(191, 41);
            this.buttonViewPrint.TabIndex = 61;
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
            this.buttonPrint.Location = new System.Drawing.Point(14, 553);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(5);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(339, 41);
            this.buttonPrint.TabIndex = 60;
            this.buttonPrint.Tag = "";
            this.buttonPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // dataGridViewProduct
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProduct.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.DoubleBuffered = true;
            this.dataGridViewProduct.EnableHeadersVisualStyles = false;
            this.dataGridViewProduct.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewProduct.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.dataGridViewProduct.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewProduct.Location = new System.Drawing.Point(14, 90);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewProduct.Size = new System.Drawing.Size(953, 379);
            this.dataGridViewProduct.TabIndex = 59;
            // 
            // printDocumentProduct
            // 
            this.printDocumentProduct.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentProduct_PrintPage);
            // 
            // printPreviewDialogProduct
            // 
            this.printPreviewDialogProduct.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogProduct.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogProduct.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogProduct.Document = this.printDocumentProduct;
            this.printPreviewDialogProduct.Enabled = true;
            this.printPreviewDialogProduct.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogProduct.Icon")));
            this.printPreviewDialogProduct.Name = "printPreviewDialogProvider";
            this.printPreviewDialogProduct.Visible = false;
            // 
            // printDialogProduct
            // 
            this.printDialogProduct.Document = this.printDocumentProduct;
            this.printDialogProduct.UseEXDialog = true;
            // 
            // FrmReProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 659);
            this.Controls.Add(this.buttonViewPrint);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.dataGridViewProduct);
            this.Name = "FrmReProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Produtos";
            this.Load += new System.EventHandler(this.FrmReProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 buttonViewPrint;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonPrint;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridViewProduct;
        private System.Drawing.Printing.PrintDocument printDocumentProduct;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogProduct;
        private System.Windows.Forms.PrintDialog printDialogProduct;
    }
}