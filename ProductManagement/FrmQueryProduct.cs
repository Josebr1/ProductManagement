using MaterialSkin;
using MaterialSkin.Controls;
using ProductManagement.Package.Dao;
using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace ProductManagement
{
    public partial class FrmQueryProduct : MaterialForm
    {
        private BindingSource source = new BindingSource();
        private string querySQL;
        OleDbDataReader readerProduct;

        public FrmQueryProduct()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Color Schema
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple400, Primary.DeepPurple500, Primary.DeepPurple500, Accent.LightGreen400, TextShade.WHITE);
        }

        private void loadingGrid()
        {
            OleDbDataReader reader = new ProductDAO().querySQL("SELECT cod_produto, descricao, caracteristicas, qtde_estoque FROM produtos");
            if (reader.HasRows == true)
            {
                source.DataSource = reader;
                dataGridViewProduct.DataSource = source;
                formatText();
                //clearSearch();
                //clearAll();
            }
            else
            {
                MessageBox.Show("Não temos fornecedores cadastrados!!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


        private void formatText()
        {

            txtCodeProduct.DataBindings.Add("Text", source, "cod_produto");
            txtCodeProduct.DataBindings.Clear();


            txtDescription.DataBindings.Add("Text", source, "descricao");
            txtDescription.DataBindings.Clear();


            txtCharacteristics.DataBindings.Add("Text", source, "caracteristicas");
            txtCharacteristics.DataBindings.Clear();

            txtAmount.DataBindings.Add("Text", source, "qtde_estoque");
            txtAmount.DataBindings.Clear();

        }

        private void FrmQueryProduct_Load(object sender, EventArgs e)
        {
            loadingGrid();
        }

        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            formatText();
        }

        private void dataGridViewProduct_KeyUp(object sender, KeyEventArgs e)
        {
            formatText();
        }

        private void txtSearchProduct_OnValueChanged(object sender, EventArgs e)
        {
            if (dropdownFiedsProduct.selectedValue.Equals("Descrição"))
            {
                querySQL = "SELECT cod_produto, descricao, caracteristicas, qtde_estoque FROM produtos WHERE descricao like '" + txtSearchProduct.Text + "%'";
            }
            else if (dropdownFiedsProduct.selectedValue.Equals("Características"))
            {
                querySQL = "SELECT cod_produto, descricao, caracteristicas, qtde_estoque FROM produtos WHERE caracteristicas like '" + txtSearchProduct.Text + "%'";
            }
            else
            {
                MessageBox.Show("Selecione um Campo para pesquisar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSearchProduct.Text = "";
            }


            readerProduct = new ProductDAO().querySQL(querySQL);

            if (readerProduct.HasRows == true)
            {
                source.DataSource = readerProduct;
                dataGridViewProduct.DataSource = source;
            }
        }

        private void printDocumentProduct_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataGridViewRow line;
            line = dataGridViewProduct.CurrentRow;

            //e.Graphics.DrawImage(Image.FromFile("logo_ete.JPG"), 50, 25);

            e.Graphics.DrawString("FICHA INDIVIDUAL DO PRODUTO", new System.Drawing.Font("Times new roman", 14, FontStyle.Bold), Brushes.Black, 400, 50);

            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), 50, 75, 800, 75);

            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), 50, 75, 800, 75);

            e.Graphics.DrawString("CÓDIGO DO PRODUTO: " + line.Cells["cod_produto"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 120);

            e.Graphics.DrawString("DESCRIÇÃO: " + line.Cells["descricao"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 140);

            e.Graphics.DrawString("CARACTERÍSTICAS: " + line.Cells["caracteristicas"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 160);

            e.Graphics.DrawString("QUANTIDADE NO ESTOQUE: " + line.Cells["qtde_estoque"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 180);

          
            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), 50, 1100, 800, 1100);

            //imprime o rodapé do relatório 
            //***************************** 
            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 1), 50, 1115, 800, 800);
            e.Graphics.DrawString("Data: " + System.DateTime.Now.ToString("dd/MM/yyyy"), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Blue, 50, 800);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            printDialogProduct.ShowDialog();
            printDocumentProduct.Print();
        }

        private void buttonViewPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialogProduct.Text = " Visualizando a impressão";
            printPreviewDialogProduct.WindowState = FormWindowState.Maximized;
            printPreviewDialogProduct.PrintPreviewControl.Columns = 2;
            printPreviewDialogProduct.PrintPreviewControl.Zoom = 0.6;
            printPreviewDialogProduct.ShowDialog();
        }

        private void buttonSelectValue_Click(object sender, EventArgs e)
        {
            int a = source.Count;
            MessageBox.Show("Quantidade: " + a, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
