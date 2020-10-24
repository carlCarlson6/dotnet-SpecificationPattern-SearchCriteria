using System;
using System.Collections.Generic;
using Criteria.QueryExecutionELements;

namespace Criteria
{
    public class SearchCriteria
    {
        public String TableName { get; set; }
        public List<Filter> Filters { get; set; }
        public String GroupBy { get; set; }
        public Order Order { get; set; }
        public Pagination Pagination { get; set; }

        public SearchCriteria(String tableName, List<Filter> filters=null, String groupBy=null, Order order=null, Pagination pagination=null)
        {
            this.TableName = tableName;
            this.Filters = filters;
            this.GroupBy = groupBy;
            this.Order = order;
            this.Pagination = pagination;
        }

        public override String ToString() => new SqlQueryStringFactory().Create(this);

    }
}
