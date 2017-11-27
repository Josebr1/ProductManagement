using MaterialSkin;
using MaterialSkin.Controls;
using ProductManagement.Package.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManagement
{
    public partial class FrmReProvider : MaterialForm
    {
        private BindingSource source = new BindingSource();
        private int registro, line = 0;
        private int end = 0;
        private int pag = 1;

        public FrmReProvider()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Color Schema
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple400, Primary.DeepPurple500, Primary.DeepPurple500, Accent.LightGreen400, TextShade.WHITE);

            loadingGrid();
            end = source.Count;
        }

        private void loadingGrid()
        {
           
            OleDbDataReader reader = new ProviderDAO().querySQL("Select * from Fornecedores");
           
            //Teste para verificar se retornaram linhas
            if (reader.HasRows == true)
            {
                source.DataSource = reader;
                dataGridViewProvider.DataSource = source;

            }
            else
            {
                MessageBox.Show("Não temos Fornecedores cadastrados !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonViewPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialogProvider.Text = " Visualizando a impressão";
            printPreviewDialogProvider.WindowState = FormWindowState.Maximized;
            printPreviewDialogProvider.PrintPreviewControl.Columns = 2;
            printPreviewDialogProvider.PrintPreviewControl.Zoom = 0.6;
            printPreviewDialogProvider.ShowDialog();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            printDialogProvider.ShowDialog();
            printDocumentProvider.Print();
        }

        private void printDocumentProvider_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataGridViewRow reg_grid;
            reg_grid = dataGridViewProvider.CurrentRow;

            // e.Graphics.DrawImage(Image.FromFile("logo_ete.JPG"), 50, 25);
            // texto = objimpressao.DrawString(string,fonte,cor,coluna,linha)
            e.Graphics.DrawString("RELATÓRIO GERAL DE FORNECEDORES", new System.Drawing.Font("Times new roman", 14, FontStyle.Bold), Brushes.Black, 300, 50);

            line = 100;

            e.Graphics.DrawString("Codigo", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 10, line);
            e.Graphics.DrawString("Razao Social", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 65, line);
            e.Graphics.DrawString("Nome Fantasia", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 300, line);
            e.Graphics.DrawString("CNPJ ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 420, line);
            e.Graphics.DrawString("Telefone ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 550, line);
            e.Graphics.DrawString("Nome do Contato ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 650, line);
            e.Graphics.DrawString("Email  ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 780, line);
            e.Graphics.DrawString("Site ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 940, line);

            line = 130;

            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), 50, 75, 1150, 75);

            while ((line < 720) & (registro != end))
            {
                e.Graphics.DrawString(reg_grid.Cells["Cod_Fornecedor"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 40, line);
                e.Graphics.DrawString(reg_grid.Cells["Razao_Social"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 65, line);
                e.Graphics.DrawString(reg_grid.Cells["Nome_Fantasia"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 300, line);
                e.Graphics.DrawString(reg_grid.Cells["CNPJ"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 420, line);
                e.Graphics.DrawString(reg_grid.Cells["fone"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 550, line);
                e.Graphics.DrawString(reg_grid.Cells["Nome_Contato"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 650, line);
                e.Graphics.DrawString(reg_grid.Cells["Email"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 780, line);
                e.Graphics.DrawString(reg_grid.Cells["Site"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 940, line);

                source.MoveNext(); 
                reg_grid = dataGridViewProvider.CurrentRow;  
                registro += 1;
                line += 20; 
            }

            //***************************** 
            //imprime o rodapé do relatório 
            //***************************** 
            e.Graphics.DrawString("Total de Registros: " + registro.ToString(), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Blue, 1000, 745);
            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 1), 10, 760, 1150, 760);
            e.Graphics.DrawString("Data: " + System.DateTime.Now.ToString("dd/MM/yyyy"), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Blue, 50, 765);
            e.Graphics.DrawString("Pág: " + pag.ToString(), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Blue, 1000, 765);

            pag += 1;  

            if ((pag > 1) & (registro < end))
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
                end = source.Count;
                source.MoveFirst();
                pag = 1;
                registro = 0;
                line = 0;
            }
        }

        private void printPreviewDialogProvider_Load(object sender, EventArgs e)
        {
            printDocumentProvider.DefaultPageSettings.Landscape = true;
        }
    }
}
