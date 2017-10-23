namespace ProductManagement
{
    partial class FrmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduct));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.buttonDeleteProduct = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buttonEditProduct = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buttonInsertProduct = new Bunifu.Framework.UI.BunifuThinButton2();
            this.textCharacteristics = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.textDescription = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblProvider = new MaterialSkin.Controls.MaterialLabel();
            this.dropdownProvider = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblCharacteristics = new MaterialSkin.Controls.MaterialLabel();
            this.numericStockQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblStockQuantity = new MaterialSkin.Controls.MaterialLabel();
            this.dropdownUnit = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblUnit = new MaterialSkin.Controls.MaterialLabel();
            this.lblDescription = new MaterialSkin.Controls.MaterialLabel();
            this.productGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textSearchProduct = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericStockQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(28, 105);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(171, 19);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Informações do produto";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.SeaGreen;
            this.bunifuCards1.Controls.Add(this.buttonDeleteProduct);
            this.bunifuCards1.Controls.Add(this.buttonEditProduct);
            this.bunifuCards1.Controls.Add(this.buttonInsertProduct);
            this.bunifuCards1.Controls.Add(this.textCharacteristics);
            this.bunifuCards1.Controls.Add(this.textDescription);
            this.bunifuCards1.Controls.Add(this.lblProvider);
            this.bunifuCards1.Controls.Add(this.dropdownProvider);
            this.bunifuCards1.Controls.Add(this.lblCharacteristics);
            this.bunifuCards1.Controls.Add(this.numericStockQuantity);
            this.bunifuCards1.Controls.Add(this.lblStockQuantity);
            this.bunifuCards1.Controls.Add(this.dropdownUnit);
            this.bunifuCards1.Controls.Add(this.lblUnit);
            this.bunifuCards1.Controls.Add(this.lblDescription);
            this.bunifuCards1.LeftSahddow = true;
            this.bunifuCards1.Location = new System.Drawing.Point(25, 127);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(507, 469);
            this.bunifuCards1.TabIndex = 14;
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.ActiveBorderThickness = 1;
            this.buttonDeleteProduct.ActiveCornerRadius = 20;
            this.buttonDeleteProduct.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.buttonDeleteProduct.ActiveForecolor = System.Drawing.Color.White;
            this.buttonDeleteProduct.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.buttonDeleteProduct.BackColor = System.Drawing.Color.White;
            this.buttonDeleteProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDeleteProduct.BackgroundImage")));
            this.buttonDeleteProduct.ButtonText = "Deletar";
            this.buttonDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.buttonDeleteProduct.IdleBorderThickness = 1;
            this.buttonDeleteProduct.IdleCornerRadius = 20;
            this.buttonDeleteProduct.IdleFillColor = System.Drawing.Color.White;
            this.buttonDeleteProduct.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.buttonDeleteProduct.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.buttonDeleteProduct.Location = new System.Drawing.Point(336, 393);
            this.buttonDeleteProduct.Margin = new System.Windows.Forms.Padding(5);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(154, 41);
            this.buttonDeleteProduct.TabIndex = 34;
            this.buttonDeleteProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.ActiveBorderThickness = 1;
            this.buttonEditProduct.ActiveCornerRadius = 20;
            this.buttonEditProduct.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.buttonEditProduct.ActiveForecolor = System.Drawing.Color.White;
            this.buttonEditProduct.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.buttonEditProduct.BackColor = System.Drawing.Color.White;
            this.buttonEditProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEditProduct.BackgroundImage")));
            this.buttonEditProduct.ButtonText = "Editar";
            this.buttonEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.buttonEditProduct.IdleBorderThickness = 1;
            this.buttonEditProduct.IdleCornerRadius = 20;
            this.buttonEditProduct.IdleFillColor = System.Drawing.Color.White;
            this.buttonEditProduct.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.buttonEditProduct.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.buttonEditProduct.Location = new System.Drawing.Point(176, 393);
            this.buttonEditProduct.Margin = new System.Windows.Forms.Padding(5);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(152, 41);
            this.buttonEditProduct.TabIndex = 33;
            this.buttonEditProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonInsertProduct
            // 
            this.buttonInsertProduct.ActiveBorderThickness = 1;
            this.buttonInsertProduct.ActiveCornerRadius = 20;
            this.buttonInsertProduct.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.buttonInsertProduct.ActiveForecolor = System.Drawing.Color.White;
            this.buttonInsertProduct.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.buttonInsertProduct.BackColor = System.Drawing.Color.White;
            this.buttonInsertProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonInsertProduct.BackgroundImage")));
            this.buttonInsertProduct.ButtonText = "Inserir";
            this.buttonInsertProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInsertProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertProduct.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonInsertProduct.IdleBorderThickness = 1;
            this.buttonInsertProduct.IdleCornerRadius = 20;
            this.buttonInsertProduct.IdleFillColor = System.Drawing.Color.White;
            this.buttonInsertProduct.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.buttonInsertProduct.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.buttonInsertProduct.Location = new System.Drawing.Point(17, 393);
            this.buttonInsertProduct.Margin = new System.Windows.Forms.Padding(5);
            this.buttonInsertProduct.Name = "buttonInsertProduct";
            this.buttonInsertProduct.Size = new System.Drawing.Size(149, 41);
            this.buttonInsertProduct.TabIndex = 7;
            this.buttonInsertProduct.Tag = "";
            this.buttonInsertProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonInsertProduct.Click += new System.EventHandler(this.buttonInsertProduct_Click);
            // 
            // textCharacteristics
            // 
            this.textCharacteristics.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.textCharacteristics.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textCharacteristics.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.textCharacteristics.BorderThickness = 1;
            this.textCharacteristics.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textCharacteristics.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textCharacteristics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textCharacteristics.isPassword = false;
            this.textCharacteristics.Location = new System.Drawing.Point(17, 245);
            this.textCharacteristics.Margin = new System.Windows.Forms.Padding(4);
            this.textCharacteristics.Name = "textCharacteristics";
            this.textCharacteristics.Size = new System.Drawing.Size(473, 34);
            this.textCharacteristics.TabIndex = 5;
            this.textCharacteristics.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textDescription
            // 
            this.textDescription.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.textDescription.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textDescription.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.textDescription.BorderThickness = 1;
            this.textDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textDescription.isPassword = false;
            this.textDescription.Location = new System.Drawing.Point(17, 46);
            this.textDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(473, 30);
            this.textDescription.TabIndex = 2;
            this.textDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblProvider
            // 
            this.lblProvider.AutoSize = true;
            this.lblProvider.Depth = 0;
            this.lblProvider.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProvider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProvider.Location = new System.Drawing.Point(13, 293);
            this.lblProvider.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProvider.Name = "lblProvider";
            this.lblProvider.Size = new System.Drawing.Size(85, 19);
            this.lblProvider.TabIndex = 23;
            this.lblProvider.Text = "Fornecedor";
            // 
            // dropdownProvider
            // 
            this.dropdownProvider.BackColor = System.Drawing.Color.Transparent;
            this.dropdownProvider.BorderRadius = 3;
            this.dropdownProvider.DisabledColor = System.Drawing.Color.Gray;
            this.dropdownProvider.ForeColor = System.Drawing.Color.White;
            this.dropdownProvider.Items = new string[0];
            this.dropdownProvider.Location = new System.Drawing.Point(17, 315);
            this.dropdownProvider.Name = "dropdownProvider";
            this.dropdownProvider.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dropdownProvider.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.dropdownProvider.selectedIndex = -1;
            this.dropdownProvider.Size = new System.Drawing.Size(473, 35);
            this.dropdownProvider.TabIndex = 6;
            // 
            // lblCharacteristics
            // 
            this.lblCharacteristics.AutoSize = true;
            this.lblCharacteristics.Depth = 0;
            this.lblCharacteristics.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCharacteristics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCharacteristics.Location = new System.Drawing.Point(13, 221);
            this.lblCharacteristics.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCharacteristics.Name = "lblCharacteristics";
            this.lblCharacteristics.Size = new System.Drawing.Size(115, 19);
            this.lblCharacteristics.TabIndex = 21;
            this.lblCharacteristics.Text = "Características ";
            // 
            // numericStockQuantity
            // 
            this.numericStockQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericStockQuantity.Location = new System.Drawing.Point(17, 188);
            this.numericStockQuantity.Name = "numericStockQuantity";
            this.numericStockQuantity.Size = new System.Drawing.Size(217, 26);
            this.numericStockQuantity.TabIndex = 4;
            // 
            // lblStockQuantity
            // 
            this.lblStockQuantity.AutoSize = true;
            this.lblStockQuantity.Depth = 0;
            this.lblStockQuantity.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblStockQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStockQuantity.Location = new System.Drawing.Point(13, 166);
            this.lblStockQuantity.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStockQuantity.Name = "lblStockQuantity";
            this.lblStockQuantity.Size = new System.Drawing.Size(168, 19);
            this.lblStockQuantity.TabIndex = 18;
            this.lblStockQuantity.Text = "Quantidade no estoque ";
            // 
            // dropdownUnit
            // 
            this.dropdownUnit.BackColor = System.Drawing.Color.Transparent;
            this.dropdownUnit.BorderRadius = 3;
            this.dropdownUnit.DisabledColor = System.Drawing.Color.Gray;
            this.dropdownUnit.ForeColor = System.Drawing.Color.White;
            this.dropdownUnit.Items = new string[] {
        "Unidade",
        "Caixa",
        "Dezena",
        "Pacote"};
            this.dropdownUnit.Location = new System.Drawing.Point(17, 115);
            this.dropdownUnit.Name = "dropdownUnit";
            this.dropdownUnit.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dropdownUnit.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.dropdownUnit.selectedIndex = 1;
            this.dropdownUnit.Size = new System.Drawing.Size(217, 34);
            this.dropdownUnit.TabIndex = 3;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Depth = 0;
            this.lblUnit.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUnit.Location = new System.Drawing.Point(13, 93);
            this.lblUnit.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(63, 19);
            this.lblUnit.TabIndex = 16;
            this.lblUnit.Text = "Unidade";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Depth = 0;
            this.lblDescription.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDescription.Location = new System.Drawing.Point(13, 23);
            this.lblDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(77, 19);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "Descrição";
            // 
            // productGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.productGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.productGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.productGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.DoubleBuffered = true;
            this.productGridView.EnableHeadersVisualStyles = false;
            this.productGridView.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.productGridView.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.productGridView.Location = new System.Drawing.Point(538, 199);
            this.productGridView.Name = "productGridView";
            this.productGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.productGridView.Size = new System.Drawing.Size(486, 397);
            this.productGridView.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProductManagement.Properties.Resources.ic_search_color;
            this.pictureBox1.Location = new System.Drawing.Point(975, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // textSearchProduct
            // 
            this.textSearchProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textSearchProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textSearchProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textSearchProduct.HintForeColor = System.Drawing.Color.Empty;
            this.textSearchProduct.HintText = "";
            this.textSearchProduct.isPassword = false;
            this.textSearchProduct.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.textSearchProduct.LineIdleColor = System.Drawing.Color.Gray;
            this.textSearchProduct.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.textSearchProduct.LineThickness = 3;
            this.textSearchProduct.Location = new System.Drawing.Point(539, 149);
            this.textSearchProduct.Margin = new System.Windows.Forms.Padding(4);
            this.textSearchProduct.Name = "textSearchProduct";
            this.textSearchProduct.Size = new System.Drawing.Size(429, 33);
            this.textSearchProduct.TabIndex = 18;
            this.textSearchProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 613);
            this.Controls.Add(this.textSearchProduct);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.productGridView);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.Name = "FrmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Produto";
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericStockQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private MaterialSkin.Controls.MaterialLabel lblProvider;
        private Bunifu.Framework.UI.BunifuDropdown dropdownProvider;
        private MaterialSkin.Controls.MaterialLabel lblCharacteristics;
        private System.Windows.Forms.NumericUpDown numericStockQuantity;
        private MaterialSkin.Controls.MaterialLabel lblStockQuantity;
        private Bunifu.Framework.UI.BunifuDropdown dropdownUnit;
        private MaterialSkin.Controls.MaterialLabel lblUnit;
        private MaterialSkin.Controls.MaterialLabel lblDescription;
        private Bunifu.Framework.UI.BunifuMetroTextbox textDescription;
        private Bunifu.Framework.UI.BunifuMetroTextbox textCharacteristics;
        private Bunifu.Framework.UI.BunifuCustomDataGrid productGridView;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonInsertProduct;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonDeleteProduct;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonEditProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textSearchProduct;
    }
}