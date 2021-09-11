using ShareTechApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ShareTechApp.Views
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