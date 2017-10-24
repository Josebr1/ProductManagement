
using MaterialSkin;
using MaterialSkin.Controls;
using ProductManagement.Package.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProductManagement
{
    public partial class Dashboard : Form
    {

        private Point dragCursor;
        private Point dragForm;
        private bool dragging;

        public Dashboard()
        {
            InitializeComponent();
            menuStripDashboard.Renderer = new MenuStripRenderer();
        }

        private void panelTopContainerDashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursor));
                this.Location = Point.Add(dragForm, new Size(dif));
            }
        }

        private void panelTopContainerDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursor = Cursor.Position;
            dragForm = this.Location;
        }

        private void panelTopContainerDashboard_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void dashboardButtonClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void dashboardButtonMaximized_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.CenterToScreen();
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.CenterToScreen();
            }
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void dashboardButtonMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void productProviderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProvider form = new FrmProvider();
            form.MdiParent = this;
            form.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduct form = new FrmProduct();
            form.MdiParent = this;
            form.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQueryProvider form = new FrmQueryProvider();
            form.MdiParent = this;
            form.Show();
        }

        private void produtosToolStripMenuItemQuery_Click(object sender, EventArgs e)
        {
            FrmQueryProduct form = new FrmQueryProduct();
            form.MdiParent = this;
            form.Show();
        }

        private void produtosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmProduct form = new FrmProduct();
            form.MdiParent = this;
            form.Show();
        }
    }
}
