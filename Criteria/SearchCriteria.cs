using System;
using System.Collections.Generic;
using Criteria.QueryExecutionElements;

namespace Criteria
{
    public class SearchCriteria
    {
        public Select Select { get; set; }
        public List<Filter> Filters { get; set; }
        public GroupBy GroupBy { get; set; }
        public Order Order { get; set; }
        public Pagination Pagination { get; set; }

        public SearchCriteria(Select select, List<Filter> filters=null, GroupBy groupBy=null, Order order=null, Pagination pagination=null)
        {
            this.Select = select;
            this.Filters = filters;
            this.GroupBy = groupBy;
            this.Order = order;
            this.Pagination = pagination;
        }

        public override String ToString()
        {
            String searchCriteriaString = this.Select.ToString();
            searchCriteriaString = this.Filters!=null ? this.AddFilters(searchCriteriaString) : searchCriteriaString;
            searchCriteriaString = this.GroupBy!=null ? String.Concat(searchCriteriaString, " ", this.GroupBy.ToString()) : searchCriteriaString;
            searchCriteriaString = this.Order!=null ? String.Concat(searchCriteriaString, " ", this.Order.ToString()) : searchCriteriaString;
            searchCriteriaString = this.Pagination!=null ? String.Concat(searchCriteriaString, " ", this.Pagination.ToString()) : searchCriteriaString;
            
            searchCriteriaString = String.Concat(searchCriteriaString, ";");
            return searchCriteriaString;
        }

        private String AddFilters(String query)
        {
            query = String.Concat(query, " WHERE ");

            for(int i=0; i<this.Filters.Count; i++)
            {
                query = String.Concat(query, this.Filters[i].ToString());
                query = (i+1 < this.Filters.Count)? String.Concat(query, " AND ") : query;
            }

            return query;
        }

    }
}
