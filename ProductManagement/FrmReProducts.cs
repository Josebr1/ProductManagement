using MaterialSkin;
using MaterialSkin.Controls;
using ProductManagement.Package.Dao;
using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace ProductManagement
{
    public partial class FrmReProducts : MaterialForm
    {

        private BindingSource source = new BindingSource();
        private int registro, line = 0;
        private int end = 0;
        private int pag = 1;

        public FrmReProducts()
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
            OleDbDataReader reader = new ProductDAO().querySQL("SELECT Produtos.Cod_Produto,Produtos.Descricao,Produtos.Unidade,Produtos.Qtde_Estoque,Produtos.Caracteristicas,Fornecedores.Nome_Fantasia FROM Produtos INNER JOIN Fornecedores  ON Produtos.Cod_Fornecedor=Fornecedores.Cod_Fornecedor  ORDER BY Produtos.Cod_Produto");
            if (reader.HasRows == true)
            {
                source.DataSource = reader;
                dataGridViewProduct.DataSource = source;
            }
            else
            {
                MessageBox.Show("Não temos fornecedores cadastrados!!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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

        private void FrmReProducts_Load(object sender, EventArgs e)
        {
            loadingGrid();
        }

        private void printDocumentProduct_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataGridViewRow reg_grid;
            reg_grid = dataGridViewProduct.CurrentRow;

           // e.Graphics.DrawImage(Image.FromFile("logo_ete.JPG"), 50, 25);
            // texto = objimpressao.DrawString(string,fonte,cor,coluna,linha)
            e.Graphics.DrawString("RELATÓRIO GERAL PRODUTOS", new System.Drawing.Font("Times new roman", 14, FontStyle.Bold), Brushes.Black, 300, 50);
            //linha – cor, espessura, posição x – ponto inicial(coluna e linha), posição y – ponto final (coluna e linha)

            line = 100;

            e.Graphics.DrawString("CÓDIGO", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 10, line);
            e.Graphics.DrawString("DESCRIÇÃO", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 65, line);
            e.Graphics.DrawString("UNIDADE", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 280, line);
            e.Graphics.DrawString("QTDE ESTOQUE ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 380, line);
            e.Graphics.DrawString("CARACTERÍSTICA ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 510, line);
            e.Graphics.DrawString("FORNECEDOR", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 620, line);


            line = 130;

            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), 50, 75, 800, 75);

            while ((line < 1000) & (registro != end))
            {

                e.Graphics.DrawString(reg_grid.Cells["Cod_Produto"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 40, line);
                e.Graphics.DrawString(reg_grid.Cells["Descricao"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 65, line);
                e.Graphics.DrawString(reg_grid.Cells["unidade"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 280, line);
                e.Graphics.DrawString(reg_grid.Cells["Qtde_Estoque"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 390, line);
                e.Graphics.DrawString(reg_grid.Cells["Caracteristicas"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 520, line);
                e.Graphics.DrawString(reg_grid.Cells["Nome_Fantasia"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 620, line);
              
                source.MoveNext(); 

                reg_grid = dataGridViewProduct.CurrentRow; 

                registro += 1; 

                line += 20;
            }

            //***************************** 
            //imprime o rodapé do relatório 
            //***************************** 
            e.Graphics.DrawString("Total de Registros: " + registro.ToString(), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Blue, 650, 1105);
            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 1), 50, 1115, 800, 800);
            e.Graphics.DrawString("Data: " + System.DateTime.Now.ToString("dd/MM/yyyy"), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Blue, 50, 1120);
            e.Graphics.DrawString("Pág: " + pag.ToString(), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Blue, 700, 1120);

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
    }
}
