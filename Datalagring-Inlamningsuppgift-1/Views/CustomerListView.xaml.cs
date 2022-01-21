using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ErrandModel.ErrandsLogic;
using ErrandModel.ErrandsModels;

namespace Datalagring_Inlamningsuppgift_1.Views
{
    /// <summary>
    /// Interaction logic for CustomerListView.xaml
    /// </summary>
    public partial class CustomerListView : UserControl
    {
        CustomerLogic _customerLogic = new CustomerLogic();
        public CustomerListView()
        {
            InitializeComponent();
        }

        private void customerSearchBtn_Click(object sender, RoutedEventArgs e)
        {
            List<Customer> customers;
            if (int.TryParse(customerSearchValue.Text, out int id))
            {
                customers = _customerLogic.SearchCustomerById(id);
            }
            else
            {
                customers = _customerLogic.SearchCustomerByLastName(customerSearchValue.Text);
            }

            PrintCustomers(customers);
        }

        private void customerAllBtn_Click(object sender, RoutedEventArgs e)
        {
            List<Customer> customers = _customerLogic.GetCustomers();
            PrintCustomers(customers);
        }

        private void PrintCustomers(List<Customer> customers)
        {
            customerList.Items.Clear();
            foreach (Customer customer in customers)
            {
                string[] row = { customer.Id.ToString(), customer.FirstName, customer.LastName };

                customerList.Items.Add(customer.Id.ToString() + ", " + customer.LastName + ", " + customer.FirstName);
            }
        }
      
    }
}
