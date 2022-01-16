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
        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show($"{firstNameText.Text} {lastNameText.Text} har lagts till i kundlistan!");

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = @"(localdb)\MSSQLLocalDB";
            builder.InitialCatalog = "DatabaseContacts";

            using (SqlConnection connection = new(builder.ConnectionString))
            {
               connection.Open();
            string sql = "SELECT * FROM ErrandsStatus WHERE Id = 1";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                       
                        while (reader.Read())
                        {
                            MessageBox.Show("{0} {1}", reader.GetString(0));
                        }
                    }
                }
            }

             
        }
        }

            
        }

    
        

    

