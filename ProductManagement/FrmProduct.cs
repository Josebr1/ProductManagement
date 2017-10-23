using FluentValidation.Results;
using MaterialSkin;
using MaterialSkin.Controls;
using ProductManagement.Package.dao;
using ProductManagement.Package.Dao;
using ProductManagement.Package.Domain;
using ProductManagement.Package.Validators;
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
    public partial class FrmProduct : MaterialForm
    {
        private BindingSource source = new BindingSource();
        private BindingSource bsProvider = new BindingSource();

        public FrmProduct()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager =  MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Color Schema
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple400, Primary.DeepPurple500, Primary.DeepPurple500, Accent.LightGreen400, TextShade.WHITE);

        }

        private void loadingGrid()
        {
            OleDbDataReader reader = new ProviderDAO().querySQL("SELECT produtos.cod_produto, produtos.descricao, produtos.unidade, produtos.qtde_estoque, produtos.caracteristicas, fornecedores.razao_social  FROM produtos INNER JOIN fornecedores ON produtos.cod_fornecedor = fornecedores.cod_fornecedor");
            if (reader.HasRows == true)
            {
                source.DataSource = reader;
                productGridView.DataSource = source;
                formatText();
                clearSearch();
                clearAll();
            }
            else
            {
                MessageBox.Show("Não temos produtos cadastrados!!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void formatText()
        {

            lblCodProduct.DataBindings.Add("Text", source, "cod_produto");
            lblCodProduct.DataBindings.Clear();

            textDescription.DataBindings.Add("Text", source, "descricao");
            textDescription.DataBindings.Clear();

            numericStockQuantity.DataBindings.Add("Text", source, "qtde_estoque");
            numericStockQuantity.DataBindings.Clear();

            textCharacteristics.DataBindings.Add("Text", source, "caracteristicas");
            textCharacteristics.DataBindings.Clear();

            dropdownUnit.DataBindings.Add("Text", source, "unidade", true);
            dropdownUnit.DataBindings.Clear();

            dropdownProvider.DataBindings.Add("Text", source, "razao_social", true);
            dropdownProvider.DataBindings.Clear();

        }

        private void clearSearch()
        {
            textSearchProduct.Text = "";
        }

        private void clearAll()
        {
            textDescription.Text = "";
            dropdownUnit.SelectedIndex = 0;
            numericStockQuantity.Value = 0;
            textCharacteristics.Text = "";
            dropdownProvider.SelectedIndex = 0;
            lblCodProduct.Text = "";
        }

        private void loadingProvider()
        {
            OleDbDataReader reader = new ProductDAO().querySQL("SELECT * FROM fornecedores");
            if (reader.HasRows == true)
            {
                bsProvider.DataSource = reader;

                dropdownProvider.DataSource = bsProvider;
                dropdownProvider.DisplayMember = "razao_social";
                dropdownProvider.ValueMember = "cod_fornecedor";
            }
            else
            {
                MessageBox.Show("Não temos produtos cadastrados!!!!" , "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonInsertProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();

                product.Description = textDescription.Text;
                product.Unit = dropdownUnit.SelectedItem.ToString();
                product.StockQuantity = Int64.Parse( numericStockQuantity.Text);
                product.Characteristics = textCharacteristics.Text;
                product.CodProvider = Int64.Parse(dropdownProvider.SelectedValue.ToString());


                ProductValidador validador = new ProductValidador();
                ValidationResult results = validador.Validate(product);

                if (results.IsValid)
                {
                    new ProductDAO().insert(product);
                    loadingGrid();

                    MessageBox.Show("Produto inserido com sucesso!!!!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    foreach (var failure in results.Errors)
                    {
                        MessageBox.Show(failure.ErrorMessage, "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas com a inserção!?", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            loadingProvider();
            loadingGrid();
        }

        private void productGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            formatText();
        }

        private void productGridView_KeyUp(object sender, KeyEventArgs e)
        {
            formatText();
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();

                product.Description = textDescription.Text;
                product.Unit = dropdownUnit.SelectedItem.ToString();
                product.StockQuantity = Int64.Parse(numericStockQuantity.Text);
                product.Characteristics = textCharacteristics.Text;
                product.CodProvider = Int64.Parse(dropdownProvider.SelectedValue.ToString());
                product.CodProduct = Int64.Parse(lblCodProduct.Text);


                ProductValidador validador = new ProductValidador();
                ValidationResult results = validador.Validate(product);

                if (results.IsValid)
                {
                    new ProductDAO().update(product);
                    loadingGrid();

                    MessageBox.Show("Produto atualizado com sucesso!!!!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    foreach (var failure in results.Errors)
                    {
                        MessageBox.Show(failure.ErrorMessage, "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas na atualização do produto. Selecione um produto!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();
                product.CodProduct = Int64.Parse(lblCodProduct.Text);

                if (lblCodProduct.Text != "")
                {
                    new ProductDAO().delete(product);

                    loadingGrid();

                    MessageBox.Show("Produto deletado com sucesso!!", "Exclusão!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Selecione um produto", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas com a Exclusão. Selecione um produto!! ", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
