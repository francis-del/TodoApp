using ToDoApp.Services;
using ToDoApp.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDoApp.Views
{
    public partial class SocialLoginPage : ContentPage
    {
        public SocialLoginPage(IOAuth2Service oAuth2Service)
        {
            InitializeComponent();
            this.BindingContext = new SocialLoginPageViewModel(oAuth2Service);
        }
    }
}