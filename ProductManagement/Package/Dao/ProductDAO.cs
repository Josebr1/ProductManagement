using ProductManagement.Package.Domain;
using ProductManagement.Package.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using ProductManagement.Package.Utils;

namespace ProductManagement.Package.Dao
{
    class ProductDAO : IAbstractDao<Product>
    {

        OleDbCommand command;

        public ProductDAO()
        {
            command = new OleDbCommand();
            command.Connection = Connection.getConnection();
        }

        public List<Product> all()
        {
            throw new NotImplementedException();
        }

        public void delete(Product domain)
        {
            try
            {
                command.CommandText = "DELETE FROM produtos WHERE cod_produto=?";
                command.Parameters.AddWithValue("@cod_produto", domain.CodProduct);

                command.ExecuteNonQuery();
            }
            finally
            {
                Connection.closeConnection();
            }
        }

        public Product findById(long id)
        {
            throw new NotImplementedException();
        }

        public void insert(Product domain)
        {
            try
            {
                command.CommandText = "insert into produtos (descricao, unidade, qtde_estoque, caracteristicas, cod_fornecedor) " +
                    "values (?, ?, ?, ?, ?)";

                command.Parameters.AddWithValue("@descricao", domain.Description);
                command.Parameters.AddWithValue("@unidade", domain.Unit);
                command.Parameters.AddWithValue("@qtde_estoque", domain.StockQuantity);
                command.Parameters.AddWithValue("@caracteristicas", domain.Characteristics);
                command.Parameters.AddWithValue("@cod_fornecedor", domain.CodProvider);


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

        public void update(Product domain)
        {
            try
            {
                command.CommandText = "UPDATE produtos SET descricao=?, unidade=?, qtde_estoque=?, caracteristicas=?, cod_fornecedor=? WHERE cod_produto=?";


                command.Parameters.AddWithValue("@descricao", domain.Description);
                command.Parameters.AddWithValue("@unidade", domain.Unit);
                command.Parameters.AddWithValue("@qtde_estoque", domain.StockQuantity);
                command.Parameters.AddWithValue("@caracteristicas", domain.Characteristics);
                command.Parameters.AddWithValue("@cod_fornecedor", domain.CodProvider);
                command.Parameters.AddWithValue("@cod_produto", domain.CodProduct);


                command.ExecuteNonQuery();
            }
            finally
            {
                Connection.closeConnection();
            }
        }
    }
}
