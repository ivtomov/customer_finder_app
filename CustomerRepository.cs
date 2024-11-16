using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerFinderApp
{
    public class CustomerRepository
    {
        private List<Customer> customers;

        public CustomerRepository()
        {
            customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "Ivan Tomov", Address = "ulitsa 123", NumberOfOrders = 5 },
            new Customer { Id = 2, Name = "Yanko Yankov", Address = "ulitsa 456 ", NumberOfOrders = 3 },
            new Customer { Id = 3, Name = "Tseko Krumov", Address = "ulitsa 789", NumberOfOrders = 7 },
        };
        }

        public async Task<Customer?> FindCustomerByIdAsync(int id)
        {
            Random random = new Random();
            int delay = random.Next(100, 1001);
            await Task.Delay(delay);

            return customers.FirstOrDefault(c => c.Id == id);
        }

        public async Task<Customer?[]> FindCustomersByIdsAsync(IEnumerable<int> ids)
        {
            var tasks = ids.Select(id => FindCustomerByIdAsync(id));
            return await Task.WhenAll(tasks);
        }

    }
}
