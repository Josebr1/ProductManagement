using ProductManagement.Package.Interfaces;
using ProductManagement.Package.Utils;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagement.Package.Domain;

namespace ProductManagement.Package.dao
{
    class ProviderDAO : IAbstractDao<ProductManagement.Package.Domain.Provider>
    {
        private Connection conn;
        private string query;
        OleDbCommand command;

        public ProviderDAO()
        {
            command = new OleDbCommand();
            command.Connection = Connection.getConnection();
        }

        public List<Domain.Provider> all()
        {
            throw new NotImplementedException();
        }

        public void delete(Provider domain)
        {
            try
            {
                command.CommandText = "DELETE FROM fornecedores WHERE cod_fornecedor=?";
                command.Parameters.AddWithValue("@cod_fornecedor", domain.CodProvider);

                command.ExecuteNonQuery();
            }
            finally
            {
                Connection.closeConnection();
            }
        }

        public Provider findById(long id)
        {
            throw new NotImplementedException();
        }

        public void insert(Provider domain)
        {
            try
            {
                command.CommandText = "insert into fornecedores (razao_social, nome_fantasia, CNPJ, endereco, num, bairro, cidade, fone, nome_Contato, email, site) " +
                    "values (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

                command.Parameters.AddWithValue("@razao_social", domain.SocialName);
                command.Parameters.AddWithValue("@nome_fantasia", domain.FantasyName);
                command.Parameters.AddWithValue("@CNPJ", domain.CNPJ);
                command.Parameters.AddWithValue("@endereco", domain.Address);
                command.Parameters.AddWithValue("@num", domain.Number);
                command.Parameters.AddWithValue("@bairro", domain.Neighborhood);
                command.Parameters.AddWithValue("@cidade", domain.City);
                command.Parameters.AddWithValue("@fone", domain.Phone);
                command.Parameters.AddWithValue("@nome_Contato", domain.NameContact);
                command.Parameters.AddWithValue("@email", domain.Email);
                command.Parameters.AddWithValue("@site", domain.Site);

                command.ExecuteNonQuery();
            }
            finally
            {
                Connection.closeConnection();
            }
        }

        public OleDbDataReader querySQL(string query) 
        {
            OleDbDataReader reader;
            command.CommandText = query;
            reader = command.ExecuteReader();
            return reader;
        }

        public void update(Provider domain)
        {
            try
            {
                command.CommandText = "UPDATE fornecedores SET razao_social=?, nome_fantasia=?, CNPJ=?, endereco=?, num=?, bairro=?, cidade=?, fone=?, nome_Contato=?, email=?, site=? WHERE cod_fornecedor=? ";
                    

                command.Parameters.AddWithValue("@razao_social", domain.SocialName);
                command.Parameters.AddWithValue("@nome_fantasia", domain.FantasyName);
                command.Parameters.AddWithValue("@CNPJ", domain.CNPJ);
                command.Parameters.AddWithValue("@endereco", domain.Address);
                command.Parameters.AddWithValue("@num", domain.Number);
                command.Parameters.AddWithValue("@bairro", domain.Neighborhood);
                command.Parameters.AddWithValue("@cidade", domain.City);
                command.Parameters.AddWithValue("@fone", domain.Phone);
                command.Parameters.AddWithValue("@nome_Contato", domain.NameContact);
                command.Parameters.AddWithValue("@email", domain.Email);
                command.Parameters.AddWithValue("@site", domain.Site);
                command.Parameters.AddWithValue("@cod_fornecedor", domain.CodProvider);

                command.ExecuteNonQuery();
            }
            finally
            {
                Connection.closeConnection();
            }
        }
    }
}
