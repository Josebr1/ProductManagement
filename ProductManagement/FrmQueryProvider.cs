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
    public partial class FrmQueryProvider : MaterialForm
    {

        private BindingSource source = new BindingSource();
        private string querySQL;
        OleDbDataReader readerProvider;

        public FrmQueryProvider()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Color Schema
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple400, Primary.DeepPurple500, Primary.DeepPurple500, Accent.LightGreen400, TextShade.WHITE);

            querySQL = "SELECT cod_fornecedor, razao_social, nome_fantasia, bairro, CNPJ FROM fornecedores WHERE nome_fantasia like '" + txtSearchProvider.Text + "%'";
        }


        private void loadingGrid()
        {
            OleDbDataReader reader = new ProviderDAO().querySQL("SELECT cod_fornecedor, razao_social, nome_fantasia, bairro, CNPJ FROM fornecedores");
            if (reader.HasRows == true)
            {
                source.DataSource = reader;
                dataGridViewProvider.DataSource = source;
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

            txtCodeProvider.DataBindings.Add("Text", source, "cod_fornecedor");
            txtCodeProvider.DataBindings.Clear();

            txtSocialName.DataBindings.Add("Text", source, "razao_social");
            txtSocialName.DataBindings.Clear();

            txtFantasyName.DataBindings.Add("Text", source, "nome_fantasia");
            txtFantasyName.DataBindings.Clear();

            txtNeighborhood.DataBindings.Add("Text", source, "bairro");
            txtNeighborhood.DataBindings.Clear();

            txtCNPJ.DataBindings.Add("Text", source, "CNPJ");
            txtCNPJ.DataBindings.Clear();

        }

        private void FrmQueryProvider_Load(object sender, EventArgs e)
        {
            loadingGrid();
        }

        private void dataGridViewProvider_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            formatText();
        }

        private void dataGridViewProvider_KeyUp(object sender, KeyEventArgs e)
        {
            formatText();
        }

        private void dropdownFiedsProvider_onItemSelected(object sender, EventArgs e)
        {

            
        }

        private void txtSearchProvider_OnValueChanged(object sender, EventArgs e)
        {
            if (dropdownFiedsProvider.selectedValue.Equals("Nome fantasia"))
            {
                querySQL = "SELECT cod_fornecedor, razao_social, nome_fantasia, bairro, CNPJ FROM fornecedores WHERE nome_fantasia like '" + txtSearchProvider.Text + "%'";
            }
            else if (dropdownFiedsProvider.selectedValue.Equals("Razão social"))
            {
                querySQL = "SELECT cod_fornecedor, razao_social, nome_fantasia, bairro, CNPJ FROM fornecedores WHERE razao_social like '" + txtSearchProvider.Text + "%'";
            }
            else if (dropdownFiedsProvider.selectedValue.Equals("CNPJ"))
            {
                querySQL = "SELECT cod_fornecedor, razao_social, nome_fantasia, bairro, CNPJ FROM fornecedores WHERE CNPJ like '" + txtSearchProvider.Text + "%'";
            }
            else
            {
                MessageBox.Show("Selecione um Campo para pesquisar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSearchProvider.Text = "";
            }


            readerProvider = new ProviderDAO().querySQL(querySQL);

            if (readerProvider.HasRows == true)
            {
                source.DataSource = readerProvider;
                dataGridViewProvider.DataSource = source;
            }
            else
            {
                MessageBox.Show("Não temos fornecedores cadastrados !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                loadingGrid();
            }
        }

        private void printDocumentProvider_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataGridViewRow line;
            line = dataGridViewProvider.CurrentRow;

            //e.Graphics.DrawImage(Image.FromFile("logo_ete.JPG"), 50, 25);

            e.Graphics.DrawString("FICHA INDIVIDUAL DO FORNECEDOR", new System.Drawing.Font("Times new roman", 14, FontStyle.Bold), Brushes.Black, 400, 50);

            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), 50, 75, 800, 75);

            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), 50, 75, 800, 75);
           
            e.Graphics.DrawString("CÓDIGO DO FORNECEDOR:  " + line.Cells["cod_fornecedor"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 120);
           
            e.Graphics.DrawString("RAZÃO SOCIAL:   " + line.Cells["razao_social"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 140);
           
            e.Graphics.DrawString("NOME FANTASIA : " + line.Cells["nome_fantasia"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 160);
           
            e.Graphics.DrawString("BAIRRO :   " + line.Cells["bairro"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 180);
           
            e.Graphics.DrawString("CNPJ :   " + line.Cells["CNPJ"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 200);

            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), 50, 1100, 800, 1100);

            //imprime o rodapé do relatório 
            //***************************** 
            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 1), 50, 1115, 800, 800);
            e.Graphics.DrawString("Data: " + System.DateTime.Now.ToString("dd/MM/yyyy"), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Blue, 50, 800);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            printDialogProvider.ShowDialog();
            printDocumentProvider.Print();
        }

        private void buttonViewPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialogProvider.Text = " Visualizando a impressão";
            printPreviewDialogProvider.WindowState = FormWindowState.Maximized;
            printPreviewDialogProvider.PrintPreviewControl.Columns = 2;
            printPreviewDialogProvider.PrintPreviewControl.Zoom = 0.6;
            printPreviewDialogProvider.ShowDialog();
        }

        private void buttonSelectValue_Click(object sender, EventArgs e)
        {
            int a = source.Count;
            MessageBox.Show("Quantidade: " + a, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
