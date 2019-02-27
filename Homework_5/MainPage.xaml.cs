using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Homework_5.Models;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace Homework_5
{
    public partial class MainPage : ContentPage
    {

        List<ProductData> dataFromJson = new List<ProductData>();

        public MainPage()
        {
            InitializeComponent();
            ReadAndDisplayJson();
        }

        void ReadAndDisplayJson()
        {
            var fileName = "Homework_5.Products.json";
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream(fileName);
            using (var reader = new StreamReader(stream))
            {
                var jsonAsString = reader.ReadToEnd();
                dataFromJson = (JsonConvert.DeserializeObject<List<ProductData>>(jsonAsString));
            }
            ProductListView.ItemsSource = new ObservableCollection<ProductData>(dataFromJson);
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            Navigation.PushAsync(new ProductPage((ProductData)menuItem.CommandParameter));
        }
    }
}
