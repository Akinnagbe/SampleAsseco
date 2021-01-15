using System.ComponentModel;
using Xamarin.Forms;
using SampleAsseco.ViewModels;

namespace SampleAsseco.Views
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