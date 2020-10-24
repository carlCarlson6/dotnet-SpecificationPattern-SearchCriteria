using System;
using System.Collections.Generic;

namespace Criteria.QueryExecutionElements
{
    public class Filters
    {
        public List<Filter> ListOfFilters { get; set; }

        public Filters(List<Filter> filters)
        {
            this.ListOfFilters = filters;
        }

        public override string ToString()
        {
            // TODO
            return base.ToString();
        }
    }
}
