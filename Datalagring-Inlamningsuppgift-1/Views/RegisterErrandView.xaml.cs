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
    /// Interaction logic for RegisterErrandView.xaml
    /// </summary>
    public partial class RegisterErrandView : UserControl
    {
        CustomerLogic _customerLogic = new CustomerLogic();

        public RegisterErrandView()
        {
            InitializeComponent();
        }


        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(customerText.Text, out int id))
            {
                errandIdValue.Content = _customerLogic.AddErrand(id, errandNameText.Text, descriptionText.Text).ToString();
            }
        }

        private void UserControl_Initialized(object sender, EventArgs e)
        {
            List<ErrandStatus> errandStatuses = _customerLogic.GetStatuses();
            foreach(ErrandStatus status in errandStatuses)
            {
                statusComboBox.Items.Add(status.Id + ". " + status.Status);
            }

            statusComboBox.SelectedIndex = 0;
            errandDateCreated.Content = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            errandDateUpdated.Content = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }
    }
}
