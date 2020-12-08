using Criteria;
using Criteria.QueryExecutionElements;
using System;
using System.Collections.Generic;
using Repository;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static String sqlConnStr = "<cadena de conexion>";

        static async Task Main(string[] args)
        {
            TryingOutSearchCriteria();
            await TryingOutQueryExecutorAsync();
        }

        static void TryingOutSearchCriteria()
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

        static async Task TryingOutQueryExecutorAsync()
        {
            QueryExecutor queryExecutor = new QueryExecutor(sqlConnStr);
            
            Select selectNames = new Select("Products", new List<String>(){"Name"});
            SearchCriteria criteriaNames = new SearchCriteria(selectNames);
            IEnumerable<ProductName> productNames1 = await queryExecutor.Execute<ProductName>(criteriaNames);
            IEnumerable<String> productNames2 = await queryExecutor.Execute<String>(criteriaNames);
            foreach (var productName in productNames1)
            {
                Console.WriteLine(productName.Name);
            }
            Console.WriteLine("-----------------");
            foreach (var name in productNames2)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("-----------------");

            Select selectSomeFields = new Select("Products", new List<String>(){ "Name", "Price", "Stock"});
            SearchCriteria criteriaSomeFields = new SearchCriteria(selectSomeFields);
            IEnumerable<dynamic> dynamicEntites = await queryExecutor.Execute<dynamic>(criteriaSomeFields);
            foreach (var dynamicEntity in dynamicEntites)
            {
                Console.WriteLine(dynamicEntity.Name);
                Console.WriteLine(dynamicEntity.Price);
            }
        }

    }
}
