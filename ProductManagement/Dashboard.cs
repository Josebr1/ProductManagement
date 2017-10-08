
using MaterialSkin.Controls;
using ProductManagement.Package.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
