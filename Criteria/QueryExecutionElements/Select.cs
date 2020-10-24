using System;
using System.Collections.Generic;

namespace Criteria.QueryExecutionElements
{
    public class Select
    {
        private String tableName;
        private List<String> columns;
        private Boolean distinct;

        public String TableName { get => this.tableName; }
        public List<String> Columns { get => this.columns; }
        public Boolean Distinct { get => this.distinct; }

        public Select(String tableName, List<String> columns=null, Boolean distinct=false)
        {
            this.tableName = tableName;
            this.columns = columns;
            this.distinct = distinct;
        }

        public override String ToString()
        {
            String query = "SELECT";

            //  TODO

            return query;
        }

    }


}
