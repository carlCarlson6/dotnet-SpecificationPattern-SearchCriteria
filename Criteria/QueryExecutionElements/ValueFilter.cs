using System;

namespace Criteria.QueryExecutionElements
{
    public class ValueFilter
    {
        private String value;
        public String Value { get => this.FormatValueFilter(); }

        public ValueFilter(String value)
        {
            this.value = value;
        }

        private String FormatValueFilter()
        {
            String formatedValueFilter;

            if(this.IsNumeric(this.value))
            {
                formatedValueFilter = this.value;
            }
            else
            {
                formatedValueFilter = String.Concat("'", this.value, "'");
            }
            
            return formatedValueFilter;
        }

        private Boolean IsNumeric(String value)
        {
            decimal valueNum = 0;
            return decimal.TryParse(value, out valueNum);
        }

    }
}