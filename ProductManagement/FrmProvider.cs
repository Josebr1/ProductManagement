using FluentValidation.Results;
using MaterialSkin;
using MaterialSkin.Controls;
using ProductManagement.Package.dao;
using ProductManagement.Package.Domain;
using ProductManagement.Package.Validators;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ProductManagement
{
    public partial class FrmProvider : MaterialForm
    {
        private BindingSource source = new BindingSource();

        public FrmProvider()
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
            OleDbDataReader reader = new ProviderDAO().querySQL("SELECT * FROM fornecedores");
            if (reader.HasRows == true)
            {
                source.DataSource = reader;
                dataGridViewProvider.DataSource = source;
                formatText();
                clearSearch();
                clearAll();
            }
            else
            {
                MessageBox.Show("Não temos fornecedores cadastrados!!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void formatText()
        {

            lblCodProvider.DataBindings.Add("Text", source, "cod_fornecedor");
            lblCodProvider.DataBindings.Clear();

            txtSocialName.DataBindings.Add("Text", source, "razao_social");
            txtSocialName.DataBindings.Clear();

            txtFantasyName.DataBindings.Add("Text", source, "nome_fantasia");
            txtFantasyName.DataBindings.Clear();

            txtNameContact.DataBindings.Add("Text", source, "nome_contato");
            txtNameContact.DataBindings.Clear();

            txtPhone.DataBindings.Add("Text", source, "fone");
            txtPhone.DataBindings.Clear();

            txtCNPJ.DataBindings.Add("Text", source, "CNPJ");
            txtCNPJ.DataBindings.Clear();

            txtEmail.DataBindings.Add("Text", source, "email");
            txtEmail.DataBindings.Clear();

            txtAddress.DataBindings.Add("Text", source, "endereco");
            txtAddress.DataBindings.Clear();

            txtNeighborhood.DataBindings.Add("Text", source, "bairro");
            txtNeighborhood.DataBindings.Clear();

            txtCity.DataBindings.Add("Text", source, "cidade");
            txtCity.DataBindings.Clear();

            txtNumber.DataBindings.Add("Text", source, "num");
            txtNumber.DataBindings.Clear();

            txtSite.DataBindings.Add("Text", source, "site");
            txtSite.DataBindings.Clear();

        }

        private void FrmProvider_Load(object sender, EventArgs e)
        {
            loadingGrid();
        }


        private void txtSearchProvider_OnValueChanged(object sender, EventArgs e)
        {

            OleDbDataReader reader = new ProviderDAO().querySQL("SELECT * FROM fornecedores WHERE nome_fantasia LIKE '" + txtSearchProvider.Text + "%'");
            if (reader.HasRows == true)
            {
                source.DataSource = reader;
                dataGridViewProvider.DataSource = source;
                formatText();
            }
        }

        private void buttunInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Provider provider = new Provider();

                provider.SocialName = txtSocialName.Text;
                provider.FantasyName = txtFantasyName.Text;
                provider.CNPJ = txtCNPJ.Text;
                provider.Address = txtAddress.Text;
                provider.Number = txtNumber.Text;
                provider.Neighborhood = txtNeighborhood.Text;
                provider.City = txtCity.Text;
                provider.Phone = txtPhone.Text;
                provider.NameContact = txtNameContact.Text;
                provider.Email = txtEmail.Text;
                provider.Site = txtSite.Text;

                ProviderValidador validador = new ProviderValidador();
                ValidationResult results = validador.Validate(provider);

                if (results.IsValid)
                {
                    new ProviderDAO().insert(provider);
                    loadingGrid();

                    MessageBox.Show("Fornecedor inserido com sucesso!!!!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buttunUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Provider provider = new Provider();

                provider.SocialName = txtSocialName.Text;
                provider.FantasyName = txtFantasyName.Text;
                provider.CNPJ = txtCNPJ.Text;
                provider.Address = txtAddress.Text;
                provider.Number = txtNumber.Text;
                provider.Neighborhood = txtNeighborhood.Text;
                provider.City = txtCity.Text;
                provider.Phone = txtPhone.Text;
                provider.NameContact = txtNameContact.Text;
                provider.Email = txtEmail.Text;
                provider.Site = txtSite.Text;
                provider.CodProvider = Int64.Parse(lblCodProvider.Text);

                ProviderValidador validador = new ProviderValidador();
                ValidationResult results = validador.Validate(provider);

                if (results.IsValid)
                {
                    new ProviderDAO().update(provider);
                    loadingGrid();

                    MessageBox.Show("Fornecedor Atualizado com sucesso!!", "Atualização!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    foreach (var failure in results.Errors)
                    {
                        MessageBox.Show(failure.ErrorMessage, "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas na atualização do fornecedor!? ", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Provider provider = new Provider();
                provider.CodProvider = Int64.Parse(lblCodProvider.Text);

                if (lblCodProvider.Text != "")
                {
                    new ProviderDAO().delete(provider);

                    loadingGrid();

                    MessageBox.Show("Fornecedor deletado com sucesso!!", "Atualização!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Selecione um fornecedor", "Exclusão!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas com a Exclusão!? ", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewProvider_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            formatText();
        }

        private void dataGridViewProvider_KeyUp(object sender, KeyEventArgs e)
        {
            formatText();
        }

        private void clearSearch()
        {
            txtSearchProvider.Text = "";
        }

        private void clearAll()
        {
            txtSocialName.Text = "";
            txtFantasyName.Text = "";
            txtNameContact.Text = "";
            txtPhone.Text = "";
            txtCNPJ.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtNeighborhood.Text = "";
            txtCity.Text = "";
            txtNumber.Text = "";
            txtSite.Text = "";
            txtSearchProvider.Text = "";
            lblCodProvider.Text = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
