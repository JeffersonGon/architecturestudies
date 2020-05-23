using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.Store.Shared.Helpers
{
    public static class ConnectionStringHelper
    {
        public static string ConnectionString()
        {
            return "Server=(localdb)\\.;Database=RepositoryDemo;Trusted_Connection=True;MultipleActiveResultSets=true;";
        }
    }
}
