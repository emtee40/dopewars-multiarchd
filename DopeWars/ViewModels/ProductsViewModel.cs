using System;
using Prism.Navigation;

namespace DopeWars.ViewModels
{
    public class ProductsViewModel : ViewModelBase
    {
        public ProductsViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Products";
        }
    }
}