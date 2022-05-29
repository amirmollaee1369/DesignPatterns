using DesignPatterns.CommandPattern.fx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern
{
    public class AddCustomerCommand : ICommand
    {
        private CustomerService customerService;

        public AddCustomerCommand(CustomerService customerService)
        {
            this.customerService = customerService;
        }

        public void execute()
        {
            customerService.addCustomer();
        }
    }
}
