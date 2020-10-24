using System;
using System.Collections.Generic;

namespace Criteria
{
    public class SearchCriteria
    {
        private String tableName;
        private List<Filter> filters;
        private String groupBy;
        private Order order;
        private Pagination pagination;

        public String TableName { get => this.tableName; }
        public List<Filter> Filters { get => this.filters; }
        public String GroupBy { get => this.groupBy; }
        public Order Order { get => this.order; }
        public Pagination Pagination { get => this.pagination; }

        public SearchCriteria(String tableName, List<Filter> filters=null, String groupBy=null, Order order=null, Pagination pagination=null)
        {
            this.tableName = tableName;
            this.filters = filters;
            this.order = order;
            this.pagination = pagination;
        }

        public override String ToString() => new SqlQueryStringFactory().Create(this);

    }
}
