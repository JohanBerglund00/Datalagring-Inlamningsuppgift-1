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
            int customerNumber = 1; // Lägg till sökruta.
            List<Errand> errandList = _customerLogic.SearchErrandByCustomer(customerNumber);
        }

        private void getErrandSearchBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PrintErrands(List<Errand> errands)
        {
            errandList.Items.Clear();
            foreach (Errand errand in errands)
            {
                string[] row = { errand.Id.ToString(), errand.Name, errand.Description };
                errandList.Items.Add(errand.Id.ToString() + ", " + errand.Name + ", " + errand.Description); ;
            }
        }
    }
}
