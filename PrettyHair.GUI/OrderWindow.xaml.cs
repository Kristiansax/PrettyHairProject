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

namespace PrettyHair.GUI
{
    /// <summary>
    /// Interaction logic for OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {
        public OrderWindow()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CreateOrderButton_Click(object sender, RoutedEventArgs e)
        {
            DateTime delivery;
            DateTime date;


            delivery = Convert.ToDateTime(DeliveryDateTextBox.Text);
            date     = Convert.ToDateTime(OrderDateTextBox.Text);

            Core.Facade.CoreFacade.Instance.CreateOrder(date, delivery);
            Close();
        }
    }
}
