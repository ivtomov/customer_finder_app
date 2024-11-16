using System;
using System.Linq;
using System.Windows;

namespace CustomerFinderApp
{
    public partial class MainWindow : Window
    {
        private CustomerRepository repository;

        public MainWindow()
        {
            InitializeComponent();
            repository = new CustomerRepository();
        }

        private async void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            ResultsListBox.Items.Clear();

            try
            {
                
                var idStrings = IdsTextBox.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var ids = idStrings.Select(int.Parse);

                
                var customers = await repository.FindCustomersByIdsAsync(ids);

                
                foreach (var customer in customers)
                {
                    if (customer != null)
                    {
                        ResultsListBox.Items.Add($"{customer.Id}: {customer.Name}, {customer.Address} ({customer.NumberOfOrders} orders)");
                    }
                    else
                    {
                        ResultsListBox.Items.Add("Customer not found");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
        private void IdsTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            PlaceholderTextBlock.Visibility = string.IsNullOrEmpty(IdsTextBox.Text)
                ? Visibility.Visible
                : Visibility.Collapsed;
        }

    }
}
