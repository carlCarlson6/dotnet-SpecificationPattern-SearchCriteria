using System;

namespace Criteria
{
    public class Order
    {
        private String orderBy;
        private String orderType;

        public String OrderBy { get => this.orderBy; }
        public String OrderType { get => this.orderBy; }
        
        public Order(String orderBy, String orderType)
        {
            this.orderBy = orderBy;
            this.orderType = orderType;
        }

    }
}