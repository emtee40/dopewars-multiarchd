using Prism.Navigation;

namespace DopeWars.ViewModels
{
    public class HomeViewModel : ViewModelBase, IInitialize
    {
        public HomeViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "homepage";
        }

        public void Initialize(INavigationParameters parameters)
        {
            
        }
    }
}