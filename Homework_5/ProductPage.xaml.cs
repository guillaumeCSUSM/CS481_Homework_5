using Homework_5.Models;
using Xamarin.Forms;

namespace Homework_5
{
    public partial class ProductPage : ContentPage
    {
        public ProductPage()
        {
            InitializeComponent();
        }

        public ProductPage(ProductData products)
        {
            InitializeComponent();
            BindingContext = products;
        }
    }
}
