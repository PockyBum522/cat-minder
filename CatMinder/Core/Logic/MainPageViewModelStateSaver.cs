using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatMinder.UI.MainPageDependencies;

namespace CatMinder.Core.Logic
{
    public class MainPageViewModelStateSaver
    {
        private readonly MainPageViewModel _viewModel;

        public MainPageViewModelStateSaver(MainPageViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public void SaveMainViewModelState()
        {
            // Lulu location
            Preferences.Default.Set(nameof(_viewModel.IsCheckedLuluGarage), _viewModel.IsCheckedLuluGarage);
            Preferences.Default.Set(nameof(_viewModel.IsCheckedLuluInside), _viewModel.IsCheckedLuluInside);
            Preferences.Default.Set(nameof(_viewModel.IsCheckedLuluOutside), _viewModel.IsCheckedLuluOutside);
        
            // Jake Location
            Preferences.Default.Set(nameof(_viewModel.IsCheckedJakeGarage), _viewModel.IsCheckedJakeGarage);
            Preferences.Default.Set(nameof(_viewModel.IsCheckedJakeInside), _viewModel.IsCheckedJakeInside);

            // Jake Drops
            Preferences.Default.Set(nameof(_viewModel.IsCheckedJakeMorning), _viewModel.IsCheckedJakeMorning);
            Preferences.Default.Set(nameof(_viewModel.IsCheckedJakeNight), _viewModel.IsCheckedJakeNight);

            // Feed
            Preferences.Default.Set(nameof(_viewModel.IsCheckedFoodMorning), _viewModel.IsCheckedFoodMorning);
            Preferences.Default.Set(nameof(_viewModel.IsCheckedFoodNoon), _viewModel.IsCheckedFoodNoon);
            Preferences.Default.Set(nameof(_viewModel.IsCheckedFoodNight), _viewModel.IsCheckedFoodNight);
        }

        public void LoadMainViewModelState()
        {
            // Lulu location
            _viewModel.IsCheckedLuluGarage = Preferences.Default.Get(nameof(_viewModel.IsCheckedLuluGarage), false);
            _viewModel.IsCheckedLuluInside = Preferences.Default.Get(nameof(_viewModel.IsCheckedLuluInside), false);
            _viewModel.IsCheckedLuluOutside = Preferences.Default.Get(nameof(_viewModel.IsCheckedLuluOutside), false);
        
            // Jake Location
            _viewModel.IsCheckedJakeGarage = Preferences.Default.Get(nameof(_viewModel.IsCheckedJakeGarage), false);
            _viewModel.IsCheckedJakeInside = Preferences.Default.Get(nameof(_viewModel.IsCheckedJakeInside), false);

            // Jake Drops
            _viewModel.IsCheckedJakeMorning = Preferences.Default.Get(nameof(_viewModel.IsCheckedJakeMorning), false);
            _viewModel.IsCheckedJakeNight = Preferences.Default.Get(nameof(_viewModel.IsCheckedJakeNight), false);

            // Feed
            _viewModel.IsCheckedFoodMorning = Preferences.Default.Get(nameof(_viewModel.IsCheckedFoodMorning), false);
            _viewModel.IsCheckedFoodNoon = Preferences.Default.Get(nameof(_viewModel.IsCheckedFoodNoon), false);
            _viewModel.IsCheckedFoodNight = Preferences.Default.Get(nameof(_viewModel.IsCheckedFoodNight), false);
        }
    }
}
