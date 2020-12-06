using System;
using System.Windows;
using Services.ServiceProduct;

namespace SalesApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ProductService productService;
        public MainWindow()
        {
            InitializeComponent();

            productService = new ProductService();
            Loaded += MainWindow_Loaded;
            ButtonAdd.Click += ButtonAdd_Click;

        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                productService.Add(TextBoxProductID.Text, TextBoxProductName.Text, decimal.Parse(TextBoxProductCost.Text), decimal.Parse(TextBoxProductPrice.Text));
            }
            catch (SystemException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                TextBoxProductID.Focus();
            }
            catch (SystemException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
