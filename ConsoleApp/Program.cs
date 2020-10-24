using Criteria;
using Criteria.QueryExecutionELements;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------");
            
            List<Filter> productoFilters = new List<Filter>()
            {
                new Filter("Name", FilterOperator.Equal, new ValueFilter("Juan")),
                new Filter("Price", FilterOperator.GreaterThan, new ValueFilter("32.5")),
            };
            Pagination productPagination = new Pagination(3, 2);
            Order productOrder = new Order("Stock", OrderTypes.Descendent);

            SearchCriteria productCriteria = new SearchCriteria("Products", productoFilters, groupBy: "Price", productOrder, productPagination); 
            Console.WriteLine(productCriteria.ToString());
            
            Console.WriteLine("--------------------------------");
            
            List<Filter> customerFilters = new List<Filter>()
            {
                new Filter("Name", FilterOperator.Equal, new ValueFilter("Juan")),
                new Filter("City", FilterOperator.GreaterThan, new ValueFilter("Valencia")),
            };
            
            SearchCriteria customerCriteria = new SearchCriteria("Customers", customerFilters);
            
            //Console.WriteLine(customerCriteria.ToString());
        }

    }
}
