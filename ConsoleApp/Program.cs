using Criteria;
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
                new Filter("Name", OperatorFilter.Equal, new ValueFilter("Juan")),
                new Filter("Price", OperatorFilter.GreaterThan, new ValueFilter("32.5")),
            };
            
            SearchCriteria productCriteria = new SearchCriteria("Products", productoFilters);
            
            Console.WriteLine(productCriteria.ToString());
            
            Console.WriteLine("--------------------------------");
            
            List<Filter> customerFilters = new List<Filter>()
            {
                new Filter("Name", OperatorFilter.Equal, new ValueFilter("Juan")),
                new Filter("City", OperatorFilter.GreaterThan, new ValueFilter("Valencia")),
            };
            
            SearchCriteria customerCriteria = new SearchCriteria("Customers", customerFilters);
            
            Console.WriteLine(customerCriteria.ToString());
        }

    }
}
