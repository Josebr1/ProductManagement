namespace ProductManagement
{
    partial class Dashboard
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
            this.menuStripDashboard = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productProviderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItemQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.analíticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastralToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.analíticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDashboard = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonInsertProducts = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonInsertProductSuppliers = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.statusStripDashboard = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelHour = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelNameDeveloper = new System.Windows.Forms.ToolStripStatusLabel();
            this.dashboardButtonClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.dashboardButtonMaximized = new Bunifu.Framework.UI.BunifuImageButton();
            this.dashboardButtonMinimized = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelTopContainerDashboard = new System.Windows.Forms.Panel();
            this.menuStripDashboard.SuspendLayout();
            this.toolStripDashboard.SuspendLayout();
            this.statusStripDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardButtonClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardButtonMaximized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardButtonMinimized)).BeginInit();
            this.panelTopContainerDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripDashboard
            // 
            this.menuStripDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.menuStripDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuStripDashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStripDashboard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStripDashboard.Location = new System.Drawing.Point(0, 0);
            this.menuStripDashboard.Name = "menuStripDashboard";
            this.menuStripDashboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStripDashboard.Size = new System.Drawing.Size(250, 580);
            this.menuStripDashboard.TabIndex = 1;
            this.menuStripDashboard.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productProviderToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cadastroToolStripMenuItem.Image = global::ProductManagement.Properties.Resources.ic_register;
            this.cadastroToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Red;
            this.cadastroToolStripMenuItem.Margin = new System.Windows.Forms.Padding(8, 80, 8, 8);
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Padding = new System.Windows.Forms.Padding(64, 8, 64, 8);
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(221, 41);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // productProviderToolStripMenuItem
            // 
            this.productProviderToolStripMenuItem.Name = "productProviderToolStripMenuItem";
            this.productProviderToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.productProviderToolStripMenuItem.Text = "Fornecedor";
            this.productProviderToolStripMenuItem.Click += new System.EventHandler(this.productProviderToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click_1);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastralToolStripMenuItem,
            this.analíticasToolStripMenuItem});
            this.consultaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.consultaToolStripMenuItem.Image = global::ProductManagement.Properties.Resources.ic_search;
            this.consultaToolStripMenuItem.Margin = new System.Windows.Forms.Padding(8);
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Padding = new System.Windows.Forms.Padding(64, 8, 64, 8);
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(221, 41);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // cadastralToolStripMenuItem
            // 
            this.cadastralToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fornecedorQueryToolStripMenuItem,
            this.produtosToolStripMenuItemQuery});
            this.cadastralToolStripMenuItem.Name = "cadastralToolStripMenuItem";
            this.cadastralToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.cadastralToolStripMenuItem.Text = "Cadastral";
            // 
            // fornecedorQueryToolStripMenuItem
            // 
            this.fornecedorQueryToolStripMenuItem.Name = "fornecedorQueryToolStripMenuItem";
            this.fornecedorQueryToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.fornecedorQueryToolStripMenuItem.Text = "Fornecedor";
            this.fornecedorQueryToolStripMenuItem.Click += new System.EventHandler(this.fornecedorToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItemQuery
            // 
            this.produtosToolStripMenuItemQuery.Name = "produtosToolStripMenuItemQuery";
            this.produtosToolStripMenuItemQuery.Size = new System.Drawing.Size(159, 26);
            this.produtosToolStripMenuItemQuery.Text = "Produtos";
            this.produtosToolStripMenuItemQuery.Click += new System.EventHandler(this.produtosToolStripMenuItemQuery_Click);
            // 
            // analíticasToolStripMenuItem
            // 
            this.analíticasToolStripMenuItem.Name = "analíticasToolStripMenuItem";
            this.analíticasToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.analíticasToolStripMenuItem.Text = "Analíticas";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastralToolStripMenuItem1,
            this.analíticaToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatóriosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.relatóriosToolStripMenuItem.Image = global::ProductManagement.Properties.Resources.ic_report;
            this.relatóriosToolStripMenuItem.Margin = new System.Windows.Forms.Padding(8);
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Padding = new System.Windows.Forms.Padding(64, 8, 64, 8);
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(221, 41);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // cadastralToolStripMenuItem1
            // 
            this.cadastralToolStripMenuItem1.Name = "cadastralToolStripMenuItem1";
            this.cadastralToolStripMenuItem1.Size = new System.Drawing.Size(145, 26);
            this.cadastralToolStripMenuItem1.Text = "Cadastral";
            // 
            // analíticaToolStripMenuItem
            // 
            this.analíticaToolStripMenuItem.Name = "analíticaToolStripMenuItem";
            this.analíticaToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.analíticaToolStripMenuItem.Text = "Analítica";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sairToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sairToolStripMenuItem.Image = global::ProductManagement.Properties.Resources.ic_exit;
            this.sairToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sairToolStripMenuItem.Margin = new System.Windows.Forms.Padding(8);
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Padding = new System.Windows.Forms.Padding(64, 8, 64, 8);
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(221, 41);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobreToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sobreToolStripMenuItem.Image = global::ProductManagement.Properties.Resources.ic_about;
            this.sobreToolStripMenuItem.Margin = new System.Windows.Forms.Padding(8);
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Padding = new System.Windows.Forms.Padding(64, 8, 64, 8);
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(221, 41);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // toolStripDashboard
            // 
            this.toolStripDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.toolStripDashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStripDashboard.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripDashboard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonInsertProducts,
            this.toolStripButtonInsertProductSuppliers,
            this.toolStripButtonExit});
            this.toolStripDashboard.Location = new System.Drawing.Point(250, 0);
            this.toolStripDashboard.Name = "toolStripDashboard";
            this.toolStripDashboard.Size = new System.Drawing.Size(24, 580);
            this.toolStripDashboard.TabIndex = 2;
            this.toolStripDashboard.Text = "toolStrip1";
            // 
            // toolStripButtonInsertProducts
            // 
            this.toolStripButtonInsertProducts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInsertProducts.Image = global::ProductManagement.Properties.Resources.ic_product;
            this.toolStripButtonInsertProducts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInsertProducts.Margin = new System.Windows.Forms.Padding(0, 30, 0, 2);
            this.toolStripButtonInsertProducts.Name = "toolStripButtonInsertProducts";
            this.toolStripButtonInsertProducts.Size = new System.Drawing.Size(21, 20);
            this.toolStripButtonInsertProducts.Text = "toolStripButton1";
            // 
            // toolStripButtonInsertProductSuppliers
            // 
            this.toolStripButtonInsertProductSuppliers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInsertProductSuppliers.Image = global::ProductManagement.Properties.Resources.ic_store;
            this.toolStripButtonInsertProductSuppliers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInsertProductSuppliers.Name = "toolStripButtonInsertProductSuppliers";
            this.toolStripButtonInsertProductSuppliers.Size = new System.Drawing.Size(21, 20);
            this.toolStripButtonInsertProductSuppliers.Text = "toolStripButton2";
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExit.Image = global::ProductManagement.Properties.Resources.ic_exit1;
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(21, 20);
            this.toolStripButtonExit.Text = "toolStripButton3";
            // 
            // statusStripDashboard
            // 
            this.statusStripDashboard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelDate,
            this.toolStripStatusLabelHour,
            this.toolStripStatusLabelNameDeveloper});
            this.statusStripDashboard.Location = new System.Drawing.Point(274, 558);
            this.statusStripDashboard.Name = "statusStripDashboard";
            this.statusStripDashboard.Size = new System.Drawing.Size(624, 22);
            this.statusStripDashboard.TabIndex = 3;
            this.statusStripDashboard.Text = "statusStrip1";
            // 
            // toolStripStatusLabelDate
            // 
            this.toolStripStatusLabelDate.Name = "toolStripStatusLabelDate";
            this.toolStripStatusLabelDate.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusLabelDate.Text = "Data";
            // 
            // toolStripStatusLabelHour
            // 
            this.toolStripStatusLabelHour.Name = "toolStripStatusLabelHour";
            this.toolStripStatusLabelHour.Size = new System.Drawing.Size(33, 17);
            this.toolStripStatusLabelHour.Text = "Hora";
            // 
            // toolStripStatusLabelNameDeveloper
            // 
            this.toolStripStatusLabelNameDeveloper.Name = "toolStripStatusLabelNameDeveloper";
            this.toolStripStatusLabelNameDeveloper.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabelNameDeveloper.Text = "José Antônio da Silva";
            // 
            // dashboardButtonClose
            // 
            this.dashboardButtonClose.BackColor = System.Drawing.Color.Transparent;
            this.dashboardButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboardButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardButtonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.dashboardButtonClose.Image = global::ProductManagement.Properties.Resources.ic_close;
            this.dashboardButtonClose.ImageActive = global::ProductManagement.Properties.Resources.ic_close_activated;
            this.dashboardButtonClose.Location = new System.Drawing.Point(588, 0);
            this.dashboardButtonClose.Name = "dashboardButtonClose";
            this.dashboardButtonClose.Size = new System.Drawing.Size(36, 36);
            this.dashboardButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dashboardButtonClose.TabIndex = 1;
            this.dashboardButtonClose.TabStop = false;
            this.dashboardButtonClose.Zoom = 10;
            this.dashboardButtonClose.Click += new System.EventHandler(this.dashboardButtonClose_Click);
            // 
            // dashboardButtonMaximized
            // 
            this.dashboardButtonMaximized.BackColor = System.Drawing.Color.Transparent;
            this.dashboardButtonMaximized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardButtonMaximized.Dock = System.Windows.Forms.DockStyle.Right;
            this.dashboardButtonMaximized.Image = global::ProductManagement.Properties.Resources.ic_maximized;
            this.dashboardButtonMaximized.ImageActive = null;
            this.dashboardButtonMaximized.Location = new System.Drawing.Point(557, 0);
            this.dashboardButtonMaximized.Name = "dashboardButtonMaximized";
            this.dashboardButtonMaximized.Size = new System.Drawing.Size(31, 36);
            this.dashboardButtonMaximized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dashboardButtonMaximized.TabIndex = 2;
            this.dashboardButtonMaximized.TabStop = false;
            this.dashboardButtonMaximized.Zoom = 10;
            this.dashboardButtonMaximized.Click += new System.EventHandler(this.dashboardButtonMaximized_Click);
            // 
            // dashboardButtonMinimized
            // 
            this.dashboardButtonMinimized.BackColor = System.Drawing.Color.Transparent;
            this.dashboardButtonMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardButtonMinimized.Dock = System.Windows.Forms.DockStyle.Right;
            this.dashboardButtonMinimized.Image = global::ProductManagement.Properties.Resources.ic_minimized;
            this.dashboardButtonMinimized.ImageActive = null;
            this.dashboardButtonMinimized.Location = new System.Drawing.Point(527, 0);
            this.dashboardButtonMinimized.Name = "dashboardButtonMinimized";
            this.dashboardButtonMinimized.Size = new System.Drawing.Size(30, 36);
            this.dashboardButtonMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dashboardButtonMinimized.TabIndex = 3;
            this.dashboardButtonMinimized.TabStop = false;
            this.dashboardButtonMinimized.Zoom = 10;
            this.dashboardButtonMinimized.Click += new System.EventHandler(this.dashboardButtonMinimized_Click);
            // 
            // panelTopContainerDashboard
            // 
            this.panelTopContainerDashboard.BackColor = System.Drawing.Color.White;
            this.panelTopContainerDashboard.Controls.Add(this.dashboardButtonMinimized);
            this.panelTopContainerDashboard.Controls.Add(this.dashboardButtonMaximized);
            this.panelTopContainerDashboard.Controls.Add(this.dashboardButtonClose);
            this.panelTopContainerDashboard.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panelTopContainerDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopContainerDashboard.Location = new System.Drawing.Point(274, 0);
            this.panelTopContainerDashboard.Name = "panelTopContainerDashboard";
            this.panelTopContainerDashboard.Size = new System.Drawing.Size(624, 36);
            this.panelTopContainerDashboard.TabIndex = 4;
            this.panelTopContainerDashboard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopContainerDashboard_MouseDown);
            this.panelTopContainerDashboard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTopContainerDashboard_MouseMove);
            this.panelTopContainerDashboard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTopContainerDashboard_MouseUp);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(898, 580);
            this.Controls.Add(this.panelTopContainerDashboard);
            this.Controls.Add(this.statusStripDashboard);
            this.Controls.Add(this.toolStripDashboard);
            this.Controls.Add(this.menuStripDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripDashboard;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripDashboard.ResumeLayout(false);
            this.menuStripDashboard.PerformLayout();
            this.toolStripDashboard.ResumeLayout(false);
            this.toolStripDashboard.PerformLayout();
            this.statusStripDashboard.ResumeLayout(false);
            this.statusStripDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardButtonClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardButtonMaximized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardButtonMinimized)).EndInit();
            this.panelTopContainerDashboard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripDashboard;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productProviderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItemQuery;
        private System.Windows.Forms.ToolStripMenuItem analíticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastralToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem analíticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripDashboard;
        private System.Windows.Forms.ToolStripButton toolStripButtonInsertProducts;
        private System.Windows.Forms.ToolStripButton toolStripButtonInsertProductSuppliers;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
        private System.Windows.Forms.StatusStrip statusStripDashboard;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHour;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNameDeveloper;
        private Bunifu.Framework.UI.BunifuImageButton dashboardButtonClose;
        private Bunifu.Framework.UI.BunifuImageButton dashboardButtonMaximized;
        private Bunifu.Framework.UI.BunifuImageButton dashboardButtonMinimized;
        private System.Windows.Forms.Panel panelTopContainerDashboard;
    }
}

