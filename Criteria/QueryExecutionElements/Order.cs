using System;

namespace Criteria.QueryExecutionElements
{
    public class Order
    {
        private String orderBy;
        private String orderType;

        public String OrderBy { get => this.orderBy; }
        public String OrderType { get => this.orderType; }
        
        public Order(String orderBy, String orderType)
        {
            this.orderBy = orderBy;
            this.orderType = orderType;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}