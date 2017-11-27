namespace ProductManagement
{
    partial class FrmQueryProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQueryProduct));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.txtAmount = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCharacteristics = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtDescription = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCodeProduct = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblAmount = new MaterialSkin.Controls.MaterialLabel();
            this.lblCharacteristics = new MaterialSkin.Controls.MaterialLabel();
            this.lblDescription = new MaterialSkin.Controls.MaterialLabel();
            this.lblCodeProduct = new MaterialSkin.Controls.MaterialLabel();
            this.buttonSelectValue = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buttonViewPrint = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buttonPrint = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridViewProduct = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.txtSearchProduct = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dropdownFiedsProduct = new Bunifu.Framework.UI.BunifuDropdown();
            this.printPreviewDialogProduct = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentProduct = new System.Drawing.Printing.PrintDocument();
            this.printDialogProduct = new System.Windows.Forms.PrintDialog();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(569, 148);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(235, 19);
            this.materialLabel1.TabIndex = 61;
            this.materialLabel1.Text = "Informações do item selecionado";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.txtAmount);
            this.bunifuCards1.Controls.Add(this.txtCharacteristics);
            this.bunifuCards1.Controls.Add(this.txtDescription);
            this.bunifuCards1.Controls.Add(this.txtCodeProduct);
            this.bunifuCards1.Controls.Add(this.lblAmount);
            this.bunifuCards1.Controls.Add(this.lblCharacteristics);
            this.bunifuCards1.Controls.Add(this.lblDescription);
            this.bunifuCards1.Controls.Add(this.lblCodeProduct);
            this.bunifuCards1.LeftSahddow = true;
            this.bunifuCards1.Location = new System.Drawing.Point(573, 170);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(402, 379);
            this.bunifuCards1.TabIndex = 60;
            // 
            // txtAmount
            // 
            this.txtAmount.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtAmount.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAmount.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtAmount.BorderThickness = 1;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.Enabled = false;
            this.txtAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAmount.isPassword = false;
            this.txtAmount.Location = new System.Drawing.Point(23, 267);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(352, 30);
            this.txtAmount.TabIndex = 48;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCharacteristics
            // 
            this.txtCharacteristics.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtCharacteristics.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCharacteristics.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtCharacteristics.BorderThickness = 1;
            this.txtCharacteristics.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCharacteristics.Enabled = false;
            this.txtCharacteristics.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCharacteristics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCharacteristics.isPassword = false;
            this.txtCharacteristics.Location = new System.Drawing.Point(23, 198);
            this.txtCharacteristics.Margin = new System.Windows.Forms.Padding(4);
            this.txtCharacteristics.Name = "txtCharacteristics";
            this.txtCharacteristics.Size = new System.Drawing.Size(352, 30);
            this.txtCharacteristics.TabIndex = 47;
            this.txtCharacteristics.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtDescription.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescription.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtDescription.BorderThickness = 1;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.Enabled = false;
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescription.isPassword = false;
            this.txtDescription.Location = new System.Drawing.Point(23, 131);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(352, 30);
            this.txtDescription.TabIndex = 46;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCodeProduct
            // 
            this.txtCodeProduct.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtCodeProduct.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodeProduct.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtCodeProduct.BorderThickness = 1;
            this.txtCodeProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodeProduct.Enabled = false;
            this.txtCodeProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCodeProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodeProduct.isPassword = false;
            this.txtCodeProduct.Location = new System.Drawing.Point(23, 60);
            this.txtCodeProduct.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodeProduct.Name = "txtCodeProduct";
            this.txtCodeProduct.Size = new System.Drawing.Size(352, 30);
            this.txtCodeProduct.TabIndex = 45;
            this.txtCodeProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Depth = 0;
            this.lblAmount.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAmount.Location = new System.Drawing.Point(19, 244);
            this.lblAmount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(144, 19);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Quantidade Estoque";
            // 
            // lblCharacteristics
            // 
            this.lblCharacteristics.AutoSize = true;
            this.lblCharacteristics.Depth = 0;
            this.lblCharacteristics.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCharacteristics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCharacteristics.Location = new System.Drawing.Point(19, 175);
            this.lblCharacteristics.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCharacteristics.Name = "lblCharacteristics";
            this.lblCharacteristics.Size = new System.Drawing.Size(111, 19);
            this.lblCharacteristics.TabIndex = 3;
            this.lblCharacteristics.Text = "Características";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Depth = 0;
            this.lblDescription.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDescription.Location = new System.Drawing.Point(19, 108);
            this.lblDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(77, 19);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Descrição";
            // 
            // lblCodeProduct
            // 
            this.lblCodeProduct.AutoSize = true;
            this.lblCodeProduct.Depth = 0;
            this.lblCodeProduct.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCodeProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCodeProduct.Location = new System.Drawing.Point(19, 35);
            this.lblCodeProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCodeProduct.Name = "lblCodeProduct";
            this.lblCodeProduct.Size = new System.Drawing.Size(114, 19);
            this.lblCodeProduct.TabIndex = 1;
            this.lblCodeProduct.Text = "Código Produto";
            // 
            // buttonSelectValue
            // 
            this.buttonSelectValue.ActiveBorderThickness = 1;
            this.buttonSelectValue.ActiveCornerRadius = 20;
            this.buttonSelectValue.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.buttonSelectValue.ActiveForecolor = System.Drawing.Color.White;
            this.buttonSelectValue.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.buttonSelectValue.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSelectValue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSelectValue.BackgroundImage")));
            this.buttonSelectValue.ButtonText = "Quantidade de itens visualizados";
            this.buttonSelectValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSelectValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectValue.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonSelectValue.IdleBorderThickness = 1;
            this.buttonSelectValue.IdleCornerRadius = 20;
            this.buttonSelectValue.IdleFillColor = System.Drawing.Color.White;
            this.buttonSelectValue.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.buttonSelectValue.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.buttonSelectValue.Location = new System.Drawing.Point(826, 557);
            this.buttonSelectValue.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSelectValue.Name = "buttonSelectValue";
            this.buttonSelectValue.Size = new System.Drawing.Size(149, 85);
            this.buttonSelectValue.TabIndex = 59;
            this.buttonSelectValue.Tag = "";
            this.buttonSelectValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonSelectValue.Click += new System.EventHandler(this.buttonSelectValue_Click);
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
            this.buttonViewPrint.Location = new System.Drawing.Point(16, 608);
            this.buttonViewPrint.Margin = new System.Windows.Forms.Padding(5);
            this.buttonViewPrint.Name = "buttonViewPrint";
            this.buttonViewPrint.Size = new System.Drawing.Size(191, 41);
            this.buttonViewPrint.TabIndex = 58;
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
            this.buttonPrint.Location = new System.Drawing.Point(12, 557);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(5);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(149, 41);
            this.buttonPrint.TabIndex = 57;
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
            this.dataGridViewProduct.Location = new System.Drawing.Point(10, 170);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewProduct.Size = new System.Drawing.Size(542, 379);
            this.dataGridViewProduct.TabIndex = 56;
            this.dataGridViewProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellClick);
            this.dataGridViewProduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridViewProduct_KeyUp);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 84);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(249, 19);
            this.lblTitle.TabIndex = 55;
            this.lblTitle.Text = "Escolha o campo a ser pesquisado:";
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtSearchProduct.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchProduct.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtSearchProduct.BorderThickness = 1;
            this.txtSearchProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSearchProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchProduct.isPassword = false;
            this.txtSearchProduct.Location = new System.Drawing.Point(268, 120);
            this.txtSearchProduct.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(284, 30);
            this.txtSearchProduct.TabIndex = 54;
            this.txtSearchProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchProduct.OnValueChanged += new System.EventHandler(this.txtSearchProduct_OnValueChanged);
            // 
            // dropdownFiedsProduct
            // 
            this.dropdownFiedsProduct.BackColor = System.Drawing.Color.Transparent;
            this.dropdownFiedsProduct.BorderRadius = 3;
            this.dropdownFiedsProduct.DisabledColor = System.Drawing.Color.Gray;
            this.dropdownFiedsProduct.ForeColor = System.Drawing.Color.White;
            this.dropdownFiedsProduct.Items = new string[] {
        "Descrição",
        "Características"};
            this.dropdownFiedsProduct.Location = new System.Drawing.Point(12, 120);
            this.dropdownFiedsProduct.Name = "dropdownFiedsProduct";
            this.dropdownFiedsProduct.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dropdownFiedsProduct.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.dropdownFiedsProduct.selectedIndex = 0;
            this.dropdownFiedsProduct.Size = new System.Drawing.Size(249, 30);
            this.dropdownFiedsProduct.TabIndex = 53;
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
            // printDocumentProduct
            // 
            this.printDocumentProduct.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentProduct_PrintPage);
            // 
            // printDialogProduct
            // 
            this.printDialogProduct.Document = this.printDocumentProduct;
            this.printDialogProduct.UseEXDialog = true;
            // 
            // FrmQueryProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 659);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.buttonSelectValue);
            this.Controls.Add(this.buttonViewPrint);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.dataGridViewProduct);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.dropdownFiedsProduct);
            this.MaximizeBox = false;
            this.Name = "FrmQueryProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Produtos";
            this.Load += new System.EventHandler(this.FrmQueryProduct_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCharacteristics;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDescription;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCodeProduct;
        private MaterialSkin.Controls.MaterialLabel lblCharacteristics;
        private MaterialSkin.Controls.MaterialLabel lblDescription;
        private MaterialSkin.Controls.MaterialLabel lblCodeProduct;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonSelectValue;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonViewPrint;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonPrint;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridViewProduct;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSearchProduct;
        private Bunifu.Framework.UI.BunifuDropdown dropdownFiedsProduct;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAmount;
        private MaterialSkin.Controls.MaterialLabel lblAmount;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogProduct;
        private System.Drawing.Printing.PrintDocument printDocumentProduct;
        private System.Windows.Forms.PrintDialog printDialogProduct;
    }
}