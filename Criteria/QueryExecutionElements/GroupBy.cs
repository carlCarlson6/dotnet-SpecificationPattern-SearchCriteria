using System;

namespace Criteria.QueryExecutionElements
{
    public class GroupBy
    {
        private String value;
        public String Value { get => this.value; }

        public GroupBy(String value)
        {
            this.value = value;
        }

        public override string ToString() => String.Concat("GROUP BY ", this.value);
    }
}
