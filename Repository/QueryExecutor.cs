using System.Data.Common;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Criteria;
using Dapper;
using System.Collections.Generic;

namespace Repository
{
    public class QueryExecutor
    {
        private SqlConnection connection;
        public QueryExecutor(String sqlServerConnectionString)
        {
            this.connection = new SqlConnection(sqlServerConnectionString);
        }

        public async Task<IEnumerable<T>> Execute<T>(SearchCriteria criteria)
        {
            String query = criteria.ToString();
            IEnumerable<T> entities = await connection.QueryAsync<T>(query);
            return entities;
        }        
    }
}
