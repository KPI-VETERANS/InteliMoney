using InteliMoney.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace InteliMoney.Views
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