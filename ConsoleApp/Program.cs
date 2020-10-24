using System.Text.RegularExpressions;
using Criteria;
using Criteria.QueryExecutionElements;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            List<String> columns = new List<String>(){ "Name", "Price", "Stock"};
            Select select = new Select("Products", columns);
            List<Filter> filters = new List<Filter>()
            {
                new Filter("Name", FilterOperator.Equal, new ValueFilter("Juan")),
                new Filter("Price", FilterOperator.GreaterThan, new ValueFilter("32.5")),
            };
            GroupBy group = new GroupBy("Price");
            Order order = new Order("Stock", OrderTypes.Descendent);
            Pagination pagination = new Pagination(3, 2);
            
            SearchCriteria criteria = new SearchCriteria(select, null, group, order);

            Console.WriteLine(criteria.ToString());            

        }

    }
}
