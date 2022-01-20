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
using System.Data.SqlClient;
using ErrandModel.ErrandsLogic;

namespace Datalagring_Inlamningsuppgift_1.Views
{
    /// <summary>
    /// Interaction logic for RegisterCustomerView.xaml
    /// </summary>
    public partial class RegisterCustomerView : UserControl
    {
        public RegisterCustomerView()
        {
            InitializeComponent();
        }
        private void submitCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            CustomerLogic customerLogic = new CustomerLogic();
            customerIdValue.Content = customerLogic.AddCustomer(firstNameText.Text, lastNameText.Text, addressText.Text, postNumberText.Text, cityText.Text, phoneNumberText.Text, emailText.Text);
            // MessageBox.Show($"{firstNameText.Text} {lastNameText.Text} har lagts till i kundlistan!");
        }
        }

            
        }

    
        

    

