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

            if(this.distinct)
                query = String.Concat(query, " DISTINCT");


            query = String.Concat(query, " ", this.AddColumns());
            query = String.Concat(query, " FROM ", this.TableName);

            return query;
        }

        public String AddColumns()
        {
            String columnsString = "";

            if(columns == null)
            {
                columnsString = "*";
            }
            else
            {
                for(int i=0; i<this.columns.Count; i++)
                {
                    columnsString = String.Concat(columnsString, this.columns[i]);
                    columnsString = (i+1 < this.columns.Count)? String.Concat(columnsString, ", ") : columnsString;
                }
            }

            return columnsString;
        }

    }

}
