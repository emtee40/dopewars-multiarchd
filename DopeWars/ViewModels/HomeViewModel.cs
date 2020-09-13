using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using DopeWars.Domain;
using DopeWars.Views;
using Prism.Commands;
using Prism.Navigation;

namespace DopeWars.ViewModels
{
    public class HomeViewModel : ViewModelBase, IInitialize
    {
        public DelegateCommand<string> CitySelectionBtn { get; private set; }

        public HomeViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "homepage";
            CitySelectionBtn = new DelegateCommand<string>(async (x)=> await CitySelectionCmd(x));
        }


        ObservableCollection<string> _ListOfCities;
        public ObservableCollection<string> ListOfCities
        {
            get { return _ListOfCities; }
            set { SetProperty(ref _ListOfCities, value); }
        }

        private async Task CitySelectionCmd(string city)
        {
            Console.WriteLine(city);
            await Task.Delay(500);
        }

        public void Initialize(INavigationParameters parameters)
        {
            var assembly = typeof(HomeView).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("DopeWars.Data.CitiesData.json");
            string text = "";
            using (var reader = new StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }
            ListOfCities = Cities.FromJson(text);
        }
    }
}