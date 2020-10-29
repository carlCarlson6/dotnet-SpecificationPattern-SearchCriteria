using System;
using System.Collections.Generic;
using Criteria;
using Criteria.QueryExecutionElements;
using Xunit;

namespace Testing
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            String queryResult = "SELECT Name, Price, Stock FROM Products GROUP BY Price ORDER BY Stock DESC;";

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

            Assert.Equal(criteria.ToString(), queryResult);

        }
    }
}
