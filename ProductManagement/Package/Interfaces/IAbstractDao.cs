using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Package.Interfaces
{
    interface IAbstractDao<T>
    {
        List<T> all();
        T findById(long id);
        void insert(T domain);
        void update(T domain);
        void delete(T domain);
        OleDbDataReader querySQL(string query);
    }
}
