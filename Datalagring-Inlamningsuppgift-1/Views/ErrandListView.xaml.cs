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
using ErrandModel.ErrandsModels;
using ErrandModel.ErrandsLogic;

namespace Datalagring_Inlamningsuppgift_1.Views
{
    /// <summary>
    /// Interaction logic for ErrandListView.xaml
    /// </summary>
    public partial class ErrandListView : UserControl
    {
        CustomerLogic _customerLogic = new CustomerLogic();
        public ErrandListView()
        {
            InitializeComponent();
        }

        private void getErrandBtn_Click(object sender, RoutedEventArgs e)
        {
            List<Errand> errandList = _customerLogic.GetErrands();
            errandListDataGrid.ItemsSource = GetErrandViews(errandList);
            var col = errandListDataGrid.Columns.Single(c => c.Header.ToString() == "CustomerId");
            col.Visibility = Visibility.Collapsed;
            errandListDataGrid.SelectedIndex = 0;
        }

        private void getErrandSearchBtn_Click(object sender, RoutedEventArgs e)
        {
            
            if(int.TryParse(getErrandSearchValue.Text, out int errandId))
            {
                List<Errand> errandList = _customerLogic.SearchErrandById(errandId);
                
                errandListDataGrid.ItemsSource = GetErrandViews(errandList);
                var col = errandListDataGrid.Columns.Single(c => c.Header.ToString() == "CustomerId");
                col.Visibility = Visibility.Collapsed;
                errandListDataGrid.SelectedIndex = 0;
            }
            
            
        }

        private List<ErrandView> GetErrandViews(List<Errand> errandList)
        {
            List<ErrandView> errandListView = new List<ErrandView>();
            foreach (Errand errand in errandList)
            {
                ErrandView ev = new ErrandView(errand);
                errandListView.Add(ev);
            }
            return errandListView;
        }

        private void errandListDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(errandListDataGrid.SelectedItems.Count > 0)
            {
                ErrandView ev = (ErrandView)errandListDataGrid.SelectedItems[0];
                if (int.TryParse(ev.CustomerId, out int id))
                {
                    List<Customer> customerList = _customerLogic.SearchCustomerById(id);
                    if (customerList.Count > 0)
                    {
                        Customer customer = customerList.First();
                        firstName.Text = customer.FirstName;
                        lastName.Text = customer.LastName;
                        email.Text = customer.Email;
                        phone.Text = customer.Phone;
                        address.Text = customer.Address;
                    }
                }
            }
        }
    }
}
