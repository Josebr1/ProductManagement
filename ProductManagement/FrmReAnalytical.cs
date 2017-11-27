using MaterialSkin;
using MaterialSkin.Controls;
using ProductManagement.Package.dao;
using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace ProductManagement
{
    public partial class FrmReAnalytical : MaterialForm
    {

        OleDbDataReader drRelAnalitico;
        BindingSource bsRelAnalitico = new BindingSource();
        private int record = 0, countFantasyName = 0, countDescription = 0, line = 0, end = 0, countWhile = 0;

        String provider = null, product = null;

        private void bunifuDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bunifuDropdown.Text.Equals("Agrupado por Nome Fantasia do Fornecedor"))
            {
                loadingGrid("Fornecedor");
            }
            else if (bunifuDropdown.Text.Equals("Agrupado por Descrição do Produto"))
            {
                loadingGrid("Produto");
            }
        }

        public FrmReAnalytical()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Color Schema
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple400, Primary.DeepPurple500, Primary.DeepPurple500, Accent.LightGreen400, TextShade.WHITE);
        }

        private void loadingGrid(String order)
        {
            string query = "";
            dataGrid.DataSource = null;
            if (order.Equals("Fornecedor"))
            {

                query = "SELECT Fornecedores.nome_fantasia, produtos.descricao, produtos.unidade, Produtos.Qtde_Estoque, produtos.caracteristicas, fornecedores.endereco, Fornecedores.num, fornecedores.site, fornecedores.nome_contato FROM produtos INNER JOIN fornecedores  ON produtos.cod_fornecedor=fornecedores.cod_fornecedor  ORDER BY fornecedores.nome_fantasia";

            }
            else if (order.Equals("Produto"))
            {
                query = "SELECT Produtos.Descricao, Produtos.Unidade, Produtos.Qtde_Estoque, Produtos.Caracteristicas, Fornecedores.Nome_Fantasia, Fornecedores.Endereco, Fornecedores.num, Fornecedores.Site, Fornecedores.Nome_Contato FROM Produtos INNER JOIN Fornecedores  ON Produtos.Cod_Fornecedor=Fornecedores.Cod_Fornecedor  ORDER BY Produtos.Descricao";

            }

            drRelAnalitico = new ProviderDAO().querySQL(query);

            if (drRelAnalitico.HasRows == true)
            {
                bsRelAnalitico.DataSource = drRelAnalitico;
                dataGrid.DataSource = bsRelAnalitico;
                end = bsRelAnalitico.Count;
            }
            else
            {
                MessageBox.Show("Não temos Menções Lançadas !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (bunifuDropdown.Text.Equals("Agrupado por Nome Fantasia do Fornecedor"))
            {

                DataGridViewRow reg_grid;
                reg_grid = dataGrid.CurrentRow;
                bool verifica = false;

                // e.Graphics.DrawImage(Image.FromFile("logo_ete.jpg"), 50, 25);
                e.Graphics.DrawString("Relatório agrupado por Nome Fantasia", new System.Drawing.Font("Arial", 16, FontStyle.Bold), Brushes.Black, 300, 50);

                line = 150;

                while ((line < 1000) & (record != end) & (!verifica))
                {
                    if (line >= 950)
                    {
                        e.HasMorePages = true;
                        break;
                    }

                    if (verifica)
                    {

                        break;
                    }

                    provider = reg_grid.Cells["Nome_Fantasia"].Value.ToString();

                    e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), 50, line, 800, line);

                    e.Graphics.DrawString("Nome Fantasia: " + provider, new System.Drawing.Font("Arial", 11, FontStyle.Bold), Brushes.Black, 50, line + 20);

                    e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), 50, line + 50, 800, line + 50);

                    e.Graphics.DrawString("Descrição", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, line + 65);
                    e.Graphics.DrawString("UN", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 280, line + 65);
                    e.Graphics.DrawString("Qtde", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 360, line + 65);
                    e.Graphics.DrawString("Caracteristica", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 470, line + 65);

                    do
                    {

                        if (line >= 950)
                        {
                            e.HasMorePages = true;
                            break;
                        }
                        if (verifica)
                        {
                            break;
                        }

                        e.Graphics.DrawString(reg_grid.Cells["Descricao"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 70, line + 100);
                        e.Graphics.DrawString(reg_grid.Cells["Unidade"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 280, line + 100);
                        e.Graphics.DrawString(reg_grid.Cells["Qtde_Estoque"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 360, line + 100);
                        e.Graphics.DrawString(reg_grid.Cells["Caracteristicas"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 470, line + 100);

                        record += 1;
                        countFantasyName += 1;

                        line += 20;

                        if ((bsRelAnalitico.Count == bsRelAnalitico.Position + 1))
                        {
                            verifica = true;
                            e.Graphics.DrawString("Total de Produtos: " + countFantasyName.ToString(), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Blue, 620, line + 120);
                            record = 0;
                            countFantasyName = 0;
                            break;
                        }

                        bsRelAnalitico.MoveNext();

                        reg_grid = dataGrid.CurrentRow;

                        if (!provider.Equals(reg_grid.Cells["Nome_Fantasia"].Value.ToString()))
                        {
                            e.Graphics.DrawString("Total de Produtos: " + countFantasyName.ToString(), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Blue, 620, line + 120);
                            countFantasyName = 0;
                            break;
                        }
                        countWhile++;
                    }
                    while (provider == reg_grid.Cells["Nome_Fantasia"].Value.ToString());

                    line += 150;
                    countWhile++;
                }

                e.Graphics.DrawLine(new Pen(Color.DarkBlue, 1), 50, 1130, 800, 1130);
                e.Graphics.DrawString("Data: " + System.DateTime.Now.ToString("dd/MM/yyyy"), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Blue, 375, 1135);
            }
            else if (bunifuDropdown.Text.Equals("Agrupado por Descrição do Produto"))
            {
                DataGridViewRow reg_grid;
                reg_grid = dataGrid.CurrentRow;
                bool verifica = false;

                e.Graphics.DrawString("Relatório agrupado por Descrição", new System.Drawing.Font("Arial", 16, FontStyle.Bold), Brushes.Black, 300, 50);

                line = 150;

                while ((line < 1000) & (record != end) & (!verifica))
                {

                    if (line >= 800)
                    {
                        e.HasMorePages = true;
                        break;
                    }
                    if (verifica)
                    {
                        break;
                    }

                    product = reg_grid.Cells["Descricao"].Value.ToString();

                    e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), 50, line, 800, line);

                    e.Graphics.DrawString("Descrição: " + product, new System.Drawing.Font("Arial", 11, FontStyle.Bold), Brushes.Black, 50, line + 20);

                    e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), 50, line + 50, 800, line + 50);

                    e.Graphics.DrawString("Caracteriscas", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, line + 65);
                    e.Graphics.DrawString("UN", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 300, line + 65);
                    e.Graphics.DrawString("Qtde", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 350, line + 65);
                    e.Graphics.DrawString("Fornecedor", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 400, line + 65);

                    do
                    {
                        if (line >= 800)
                        {
                            e.HasMorePages = true;
                            break;
                        }
                        if (verifica)
                        {
                            break;
                        }

                        e.Graphics.DrawString(reg_grid.Cells["Caracteristicas"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 70, line + 100);
                        e.Graphics.DrawString(reg_grid.Cells["Unidade"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 300, line + 100);
                        e.Graphics.DrawString(reg_grid.Cells["Qtde_Estoque"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 350, line + 100);
                        e.Graphics.DrawString(reg_grid.Cells["Nome_Fantasia"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 400, line + 100);
                        record += 1;
                        countDescription += 1;

                        line += 20;

                        if ((bsRelAnalitico.Count == bsRelAnalitico.Position + 1))
                        {
                            verifica = true;
                            e.Graphics.DrawString("Total de Produtos: " + countDescription.ToString(), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Blue, 620, line + 120);
                            record = 0;
                            countDescription = 0;
                            break;
                        }


                        bsRelAnalitico.MoveNext();

                        reg_grid = dataGrid.CurrentRow;

                        if (!product.Equals(reg_grid.Cells["Descricao"].Value.ToString()))
                        {
                            e.Graphics.DrawString("Total de Produtos: " + countDescription.ToString(), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Blue, 620, line + 120);
                            countDescription = 0;
                            break;
                        }
                        countWhile++;
                    }
                    while (product == reg_grid.Cells["Descricao"].Value.ToString());
                    countWhile++;
                    line += 150;
                }

                e.Graphics.DrawLine(new Pen(Color.DarkBlue, 1), 50, 1130, 800, 1130);
                e.Graphics.DrawString("Data: " + System.DateTime.Now.ToString("dd/MM/yyyy"), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Blue, 375, 1135);
            }


            if (end <= countWhile)
            {
                e.HasMorePages = false;
                record = 0; countFantasyName = 0; countDescription = 0; line = 0; end = 0; countWhile = 0;
                provider = null; product = null;
                end = bsRelAnalitico.Count;
                bsRelAnalitico.MoveFirst();
            }
        }

        private void buttonViewPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Text = " Visualizando a impressão";   
            printPreviewDialog.WindowState = FormWindowState.Maximized;  
            printPreviewDialog.PrintPreviewControl.Columns = 2;   
            printPreviewDialog.PrintPreviewControl.Zoom = 0.6;  
            printPreviewDialog.ShowDialog();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            printDialog.ShowDialog();
            printDocument.Print();
        }
    }
}
