using System;
using System.Collections.Generic;

namespace Criteria
{
    public class SearchCriteria
    {
        private String tableName;
        private List<Filter> filters;
        private Order order;
        private Pagination pagination;

        public SearchCriteria(String tableName, List<Filter> filters, Order order = null, Pagination pagination = null)
        {
            this.tableName = tableName;
            this.filters = filters;
            this.order = order;
            this.pagination = pagination;
        }

        public override String ToString()
        {
            String query = String.Concat("SELECT * FROM", " ", tableName);
            
            query = this.AddFilters(this.filters, query);
            query = order!=null ? this.AddOrder(this.order, query) : query;
            query = pagination!=null ? this.AddPagination(this.pagination, query) : query;

            query = String.Concat(query, ";");
            return query;
        }

        private String AddFilters(List<Filter> filters, String query)
        {
            query = String.Concat(query, " " ,"WHERE");

            for(int i=0; i<filters.Count; i++)
            {
                query = this.AddFilter(filters[i], query);
                query = (i+1 < filters.Count)? String.Concat(query, " ", "AND") : query;
            }

            return query;
        }
        private String AddFilter(Filter filter, String query) => String.Concat(query, " ", filter.Field, filter.OperatorFilter, filter.ValueFilter.Value);
        
        private String AddOrder(Order order, String query) => throw new NotImplementedException();

        private String AddPagination(Pagination pagination, String query) => throw new NotImplementedException();

    }
}
