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
using System.Windows.Shapes;
using PrettyHair.Core.Facade;
using PrettyHair.GUI;

namespace PrettyHair.GUI
{
    /// <summary>
    /// Interaction logic for CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window
    {
        public CustomerWindow()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            CoreFacade.Instance.CreateCustomer(FirstNameTextBox.Text, LastNameTextBox.Text);
            
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            /*Controller controller = new Controller();
            controller.
            CoreFacade.Instance.RemoveCustomerByID(ID)*/
        }
    }
}
