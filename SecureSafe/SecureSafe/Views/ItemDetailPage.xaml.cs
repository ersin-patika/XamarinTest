using System.ComponentModel;
using Xamarin.Forms;
using SecureSafe.ViewModels;

namespace SecureSafe.Views
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
