using System;
using System.Collections.Generic;

namespace Criteria.QueryExecutionElements
{
    public class Filters
    {
        public List<Filter> ValuesList { get; }

        public Filters(List<Filter> filters)
        {
            this.ValuesList = filters;
        }

        public override string ToString()
        {
            String toStringValue = "WHERE ";

            for(int i=0; i<this.ValuesList.Count; i++)
            {
                toStringValue = String.Concat(toStringValue, this.ValuesList[i].ToString());
                toStringValue = (i+1 < this.ValuesList.Count) ? String.Concat(toStringValue, " AND ") : toStringValue; 
            }

            return toStringValue;
        }
    }
}
