using Contoso.Store.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Contoso.Store.Infrastructure.DataAccess.Dapper.Context
{
    public class DapperContext : IDisposable
    {
        public DapperContext()
        {
            Connection = new SqlConnection(ConnectionStringHelper.ConnectionString());
            Connection.Open();
        }

        public SqlConnection Connection { get; set; }
        public void Dispose()
        {
            if (Connection.State != ConnectionState.Closed)
                Connection.Close();
        }
    }
}
