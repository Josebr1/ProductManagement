namespace ProductManagement
{
    partial class FrmQueryProvider
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQueryProvider));
            this.dropdownFiedsProvider = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtSearchProvider = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridViewProvider = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.buttonPrint = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buttonViewPrint = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buttonSelectValue = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblCodeProvider = new MaterialSkin.Controls.MaterialLabel();
            this.lblSocialName = new MaterialSkin.Controls.MaterialLabel();
            this.lblFantasyName = new MaterialSkin.Controls.MaterialLabel();
            this.lblNeighborhood = new MaterialSkin.Controls.MaterialLabel();
            this.lblCNPJ = new MaterialSkin.Controls.MaterialLabel();
            this.txtCodeProvider = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtSocialName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtFantasyName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNeighborhood = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCNPJ = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.printDialogProvider = new System.Windows.Forms.PrintDialog();
            this.printDocumentProvider = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogProvider = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProvider)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dropdownFiedsProvider
            // 
            this.dropdownFiedsProvider.BackColor = System.Drawing.Color.Transparent;
            this.dropdownFiedsProvider.BorderRadius = 3;
            this.dropdownFiedsProvider.DisabledColor = System.Drawing.Color.Gray;
            this.dropdownFiedsProvider.ForeColor = System.Drawing.Color.White;
            this.dropdownFiedsProvider.Items = new string[] {
        "Nome fantasia",
        "Razão social",
        "CNPJ"};
            this.dropdownFiedsProvider.Location = new System.Drawing.Point(14, 123);
            this.dropdownFiedsProvider.Name = "dropdownFiedsProvider";
            this.dropdownFiedsProvider.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dropdownFiedsProvider.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.dropdownFiedsProvider.selectedIndex = 0;
            this.dropdownFiedsProvider.Size = new System.Drawing.Size(249, 30);
            this.dropdownFiedsProvider.TabIndex = 0;
            this.dropdownFiedsProvider.onItemSelected += new System.EventHandler(this.dropdownFiedsProvider_onItemSelected);
            // 
            // txtSearchProvider
            // 
            this.txtSearchProvider.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtSearchProvider.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchProvider.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtSearchProvider.BorderThickness = 1;
            this.txtSearchProvider.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchProvider.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSearchProvider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchProvider.isPassword = false;
            this.txtSearchProvider.Location = new System.Drawing.Point(270, 123);
            this.txtSearchProvider.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchProvider.Name = "txtSearchProvider";
            this.txtSearchProvider.Size = new System.Drawing.Size(284, 30);
            this.txtSearchProvider.TabIndex = 44;
            this.txtSearchProvider.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchProvider.OnValueChanged += new System.EventHandler(this.txtSearchProvider_OnValueChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(14, 87);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(249, 19);
            this.lblTitle.TabIndex = 45;
            this.lblTitle.Text = "Escolha o campo a ser pesquisado:";
            // 
            // dataGridViewProvider
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewProvider.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewProvider.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewProvider.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProvider.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProvider.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewProvider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProvider.DoubleBuffered = true;
            this.dataGridViewProvider.EnableHeadersVisualStyles = false;
            this.dataGridViewProvider.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewProvider.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.dataGridViewProvider.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewProvider.Location = new System.Drawing.Point(12, 173);
            this.dataGridViewProvider.Name = "dataGridViewProvider";
            this.dataGridViewProvider.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewProvider.Size = new System.Drawing.Size(542, 379);
            this.dataGridViewProvider.TabIndex = 47;
            this.dataGridViewProvider.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProvider_CellClick);
            this.dataGridViewProvider.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridViewProvider_KeyUp);
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
            this.buttonPrint.Location = new System.Drawing.Point(14, 560);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(5);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(149, 41);
            this.buttonPrint.TabIndex = 48;
            this.buttonPrint.Tag = "";
            this.buttonPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
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
            this.buttonViewPrint.Location = new System.Drawing.Point(18, 611);
            this.buttonViewPrint.Margin = new System.Windows.Forms.Padding(5);
            this.buttonViewPrint.Name = "buttonViewPrint";
            this.buttonViewPrint.Size = new System.Drawing.Size(191, 41);
            this.buttonViewPrint.TabIndex = 49;
            this.buttonViewPrint.Tag = "";
            this.buttonViewPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonViewPrint.Click += new System.EventHandler(this.buttonViewPrint_Click);
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
            this.buttonSelectValue.Location = new System.Drawing.Point(828, 560);
            this.buttonSelectValue.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSelectValue.Name = "buttonSelectValue";
            this.buttonSelectValue.Size = new System.Drawing.Size(149, 85);
            this.buttonSelectValue.TabIndex = 50;
            this.buttonSelectValue.Tag = "";
            this.buttonSelectValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonSelectValue.Click += new System.EventHandler(this.buttonSelectValue_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.txtCNPJ);
            this.bunifuCards1.Controls.Add(this.txtNeighborhood);
            this.bunifuCards1.Controls.Add(this.txtFantasyName);
            this.bunifuCards1.Controls.Add(this.txtSocialName);
            this.bunifuCards1.Controls.Add(this.txtCodeProvider);
            this.bunifuCards1.Controls.Add(this.lblCNPJ);
            this.bunifuCards1.Controls.Add(this.lblNeighborhood);
            this.bunifuCards1.Controls.Add(this.lblFantasyName);
            this.bunifuCards1.Controls.Add(this.lblSocialName);
            this.bunifuCards1.Controls.Add(this.lblCodeProvider);
            this.bunifuCards1.LeftSahddow = true;
            this.bunifuCards1.Location = new System.Drawing.Point(575, 173);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(402, 379);
            this.bunifuCards1.TabIndex = 51;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(571, 151);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(235, 19);
            this.materialLabel1.TabIndex = 52;
            this.materialLabel1.Text = "Informações do item selecionado";
            // 
            // lblCodeProvider
            // 
            this.lblCodeProvider.AutoSize = true;
            this.lblCodeProvider.Depth = 0;
            this.lblCodeProvider.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCodeProvider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCodeProvider.Location = new System.Drawing.Point(19, 35);
            this.lblCodeProvider.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCodeProvider.Name = "lblCodeProvider";
            this.lblCodeProvider.Size = new System.Drawing.Size(137, 19);
            this.lblCodeProvider.TabIndex = 1;
            this.lblCodeProvider.Text = "Código Fornecedor";
            // 
            // lblSocialName
            // 
            this.lblSocialName.AutoSize = true;
            this.lblSocialName.Depth = 0;
            this.lblSocialName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSocialName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSocialName.Location = new System.Drawing.Point(19, 108);
            this.lblSocialName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSocialName.Name = "lblSocialName";
            this.lblSocialName.Size = new System.Drawing.Size(95, 19);
            this.lblSocialName.TabIndex = 2;
            this.lblSocialName.Text = "Razão social";
            // 
            // lblFantasyName
            // 
            this.lblFantasyName.AutoSize = true;
            this.lblFantasyName.Depth = 0;
            this.lblFantasyName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFantasyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFantasyName.Location = new System.Drawing.Point(19, 175);
            this.lblFantasyName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFantasyName.Name = "lblFantasyName";
            this.lblFantasyName.Size = new System.Drawing.Size(108, 19);
            this.lblFantasyName.TabIndex = 3;
            this.lblFantasyName.Text = "Nome fantasia";
            // 
            // lblNeighborhood
            // 
            this.lblNeighborhood.AutoSize = true;
            this.lblNeighborhood.Depth = 0;
            this.lblNeighborhood.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNeighborhood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNeighborhood.Location = new System.Drawing.Point(19, 244);
            this.lblNeighborhood.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNeighborhood.Name = "lblNeighborhood";
            this.lblNeighborhood.Size = new System.Drawing.Size(49, 19);
            this.lblNeighborhood.TabIndex = 4;
            this.lblNeighborhood.Text = "Bairro";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Depth = 0;
            this.lblCNPJ.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCNPJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCNPJ.Location = new System.Drawing.Point(19, 311);
            this.lblCNPJ.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(47, 19);
            this.lblCNPJ.TabIndex = 5;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // txtCodeProvider
            // 
            this.txtCodeProvider.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtCodeProvider.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodeProvider.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtCodeProvider.BorderThickness = 1;
            this.txtCodeProvider.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodeProvider.Enabled = false;
            this.txtCodeProvider.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCodeProvider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodeProvider.isPassword = false;
            this.txtCodeProvider.Location = new System.Drawing.Point(23, 60);
            this.txtCodeProvider.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodeProvider.Name = "txtCodeProvider";
            this.txtCodeProvider.Size = new System.Drawing.Size(352, 30);
            this.txtCodeProvider.TabIndex = 45;
            this.txtCodeProvider.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSocialName
            // 
            this.txtSocialName.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtSocialName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSocialName.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtSocialName.BorderThickness = 1;
            this.txtSocialName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSocialName.Enabled = false;
            this.txtSocialName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSocialName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSocialName.isPassword = false;
            this.txtSocialName.Location = new System.Drawing.Point(23, 131);
            this.txtSocialName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSocialName.Name = "txtSocialName";
            this.txtSocialName.Size = new System.Drawing.Size(352, 30);
            this.txtSocialName.TabIndex = 46;
            this.txtSocialName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtFantasyName
            // 
            this.txtFantasyName.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtFantasyName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFantasyName.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtFantasyName.BorderThickness = 1;
            this.txtFantasyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFantasyName.Enabled = false;
            this.txtFantasyName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFantasyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFantasyName.isPassword = false;
            this.txtFantasyName.Location = new System.Drawing.Point(23, 198);
            this.txtFantasyName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFantasyName.Name = "txtFantasyName";
            this.txtFantasyName.Size = new System.Drawing.Size(352, 30);
            this.txtFantasyName.TabIndex = 47;
            this.txtFantasyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNeighborhood
            // 
            this.txtNeighborhood.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtNeighborhood.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNeighborhood.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtNeighborhood.BorderThickness = 1;
            this.txtNeighborhood.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNeighborhood.Enabled = false;
            this.txtNeighborhood.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNeighborhood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNeighborhood.isPassword = false;
            this.txtNeighborhood.Location = new System.Drawing.Point(23, 267);
            this.txtNeighborhood.Margin = new System.Windows.Forms.Padding(4);
            this.txtNeighborhood.Name = "txtNeighborhood";
            this.txtNeighborhood.Size = new System.Drawing.Size(352, 30);
            this.txtNeighborhood.TabIndex = 48;
            this.txtNeighborhood.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtCNPJ.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCNPJ.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtCNPJ.BorderThickness = 1;
            this.txtCNPJ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCNPJ.Enabled = false;
            this.txtCNPJ.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCNPJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCNPJ.isPassword = false;
            this.txtCNPJ.Location = new System.Drawing.Point(23, 334);
            this.txtCNPJ.Margin = new System.Windows.Forms.Padding(4);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(352, 30);
            this.txtCNPJ.TabIndex = 49;
            this.txtCNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // printDialogProvider
            // 
            this.printDialogProvider.Document = this.printDocumentProvider;
            this.printDialogProvider.UseEXDialog = true;
            // 
            // printDocumentProvider
            // 
            this.printDocumentProvider.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentProvider_PrintPage);
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
            // 
            // FrmQueryProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 659);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.buttonSelectValue);
            this.Controls.Add(this.buttonViewPrint);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.dataGridViewProvider);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtSearchProvider);
            this.Controls.Add(this.dropdownFiedsProvider);
            this.MaximizeBox = false;
            this.Name = "FrmQueryProvider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QueryProvider";
            this.Load += new System.EventHandler(this.FrmQueryProvider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProvider)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDropdown dropdownFiedsProvider;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSearchProvider;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridViewProvider;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonPrint;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonViewPrint;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonSelectValue;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCNPJ;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNeighborhood;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFantasyName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSocialName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCodeProvider;
        private MaterialSkin.Controls.MaterialLabel lblCNPJ;
        private MaterialSkin.Controls.MaterialLabel lblNeighborhood;
        private MaterialSkin.Controls.MaterialLabel lblFantasyName;
        private MaterialSkin.Controls.MaterialLabel lblSocialName;
        private MaterialSkin.Controls.MaterialLabel lblCodeProvider;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PrintDialog printDialogProvider;
        private System.Drawing.Printing.PrintDocument printDocumentProvider;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogProvider;
    }
}