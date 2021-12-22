using System.ComponentModel;
using Xamarin.Forms;
using sample.ViewModels;

namespace sample.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
