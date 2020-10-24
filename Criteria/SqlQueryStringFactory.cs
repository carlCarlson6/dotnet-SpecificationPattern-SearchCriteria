using System;
using System.Collections.Generic;
using Criteria.QueryExecutionELements;

namespace Criteria
{
    public class SqlQueryStringFactory
    {
        public String Create(SearchCriteria criteria)
        {
            String query = String.Concat("SELECT * FROM", " ", criteria.TableName);

            query = criteria.Filters!=null? this.AddFilters(criteria.Filters, query) : query;
            query = criteria.Order!=null ? this.AddOrder(criteria.Order, query) : query;
            query = criteria.GroupBy!=null ? this.AddGroup(criteria.GroupBy, query) : query;
            query = criteria.Pagination!=null ? this.AddPagination(criteria.Pagination, query) : query;

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
        private String AddGroup(String groupBy, String query) => String.Concat(query, " ", "GROUP BY", " ", groupBy); 
        private String AddOrder(Order order, String query) => String.Concat(query, " ", "ORDER BY", " ", order.OrderBy, " ", order.OrderType);
        private String AddPagination(Pagination pagination, String query)
        {
            query = String.Concat(query, " ", "LIMIT", " ", pagination.Limit);
            query = String.Concat(query, " ", "OFFSET", " ", pagination.Offset);
            return query;
        }
    }
}
