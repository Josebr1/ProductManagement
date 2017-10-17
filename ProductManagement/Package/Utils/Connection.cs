using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Package.Utils
{
    class Connection
    {
        private static string connString = @"Provider=Microsoft.Ace.OLEDB.12.0;Data Source=Bd_EMPRESA.accdb";
        private static OleDbConnection connection = null;

        public static OleDbConnection getConnection()
        {
            connection = new OleDbConnection(connString);

            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                connection = null;
                System.Windows.Forms.MessageBox.Show("Conexão não estabelecida!!" + ex.GetBaseException());
            }
            return connection;
        }

        public static void closeConnection()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }
    }
}
