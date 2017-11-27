using MaterialSkin;
using MaterialSkin.Controls;
using ProductManagement.Package.dao;
using ProductManagement.Package.Dao;
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
    public partial class FrmQueryAnalyticalr : MaterialForm
    {
         
        BindingSource bsProvider = new BindingSource();
        OleDbDataReader drProvider;

        BindingSource bsProduct = new BindingSource();
        OleDbDataReader drProduct;

        BindingSource bsGrid = new BindingSource();
        OleDbDataReader drGrid;

        public FrmQueryAnalyticalr()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Color Schema
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple400, Primary.DeepPurple500, Primary.DeepPurple500, Accent.LightGreen400, TextShade.WHITE);
        }


        private void loadingProviders()
        {
            drProvider = new ProviderDAO().querySQL("Select * from Fornecedores order by Razao_Social");

            if (drProvider.HasRows == true)
            {
                bsProvider.DataSource = drProvider;
                dropdownFieds.DataSource = bsProvider;
                dropdownFieds.DisplayMember = "Razao_Social";
                dropdownFieds.ValueMember = "Cod_Fornecedor";
            }
        }

        private void loadingProduct()
        {
            drProduct = new ProductDAO().querySQL("Select DISTINCT Produtos.Descricao from Produtos order by Descricao");

            if (drProduct.HasRows == true)
            {
                bsProduct.DataSource = drProduct;
                dropdownFieds.DataSource = bsProduct;
                dropdownFieds.DisplayMember = "Descricao";
                dropdownFieds.ValueMember = "Descricao";
            }
        }

        private void dropdownTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropdownTable.Text.Equals("Fornecedores"))
            {
                loadingProviders();
            }
            else if (dropdownTable.Text.Equals("Produtos"))
            {
                loadingProduct();
            }
        }


        private void dropdownFieds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropdownTable.Text.Equals("Fornecedores"))
            {
                bsProvider.DataSource = drProvider;
                dropdownFieds.DataSource = bsProvider;
                dropdownFieds.DisplayMember = "Razao_Social";
                dropdownFieds.ValueMember = "Cod_Fornecedor";

                string search = "Fornecedores.Cod_Fornecedor  like '" + dropdownFieds.SelectedValue.ToString();
                loadingSearch(search);
            }
            else if (dropdownTable.Text.Equals("Produtos"))
            {
                bsProduct.DataSource = drProduct;
                dropdownFieds.DataSource = bsProduct;
                dropdownFieds.DisplayMember = "Descricao";
                dropdownFieds.ValueMember = "Descricao";

                string search = "Produtos.Descricao  like '" + dropdownFieds.SelectedValue.ToString();
                loadingSearch(search);
            }
        }

        private void loadingSearch(string search)
        {
            string query = "SELECT produtos.cod_produto, produtos.descricao, produtos.unidade, produtos.qtde_estoque, produtos.caracteristicas, fornecedores.razao_social  FROM produtos INNER JOIN fornecedores ON produtos.cod_fornecedor = fornecedores.cod_fornecedor WHERE " + search + "'";
            drGrid = new ProviderDAO().querySQL(query);

            if (drGrid.HasRows == true)
            {
                bsGrid.DataSource = drGrid;
                dataGridView.DataSource = bsGrid;
            }
            else
            {
                MessageBox.Show("Não temos esses Paremetros !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
