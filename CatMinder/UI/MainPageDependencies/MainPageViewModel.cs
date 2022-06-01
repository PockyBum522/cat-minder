using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CatMinder.Core.Logic;

namespace CatMinder.UI.MainPageDependencies;

public class MainPageViewModel : INotifyPropertyChanged
{
    public bool IsFinishedLoading { get; set; } = false;

    // Lulu location
    public bool IsCheckedLuluGarage { get => _isCheckedLuluGarage; set => SetField(ref _isCheckedLuluGarage, value); }
    public bool IsCheckedLuluInside { get => _isCheckedLuluInside; set => SetField(ref _isCheckedLuluInside, value); }
    public bool IsCheckedLuluOutside { get => _isCheckedLuluOutside; set => SetField(ref _isCheckedLuluOutside, value); }
    
    // Jake Location
    public bool IsCheckedJakeGarage { get => _isCheckedJakeGarage; set => SetField(ref _isCheckedJakeGarage, value); }
    public bool IsCheckedJakeInside { get => _isCheckedJakeInside; set => SetField(ref _isCheckedJakeInside, value); }

    // Jake Drops
    public bool IsCheckedJakeMorning { get => _isCheckedJakeMorning; set => SetField(ref _isCheckedJakeMorning, value); }
    public bool IsCheckedJakeNight { get => _isCheckedJakeNight; set => SetField(ref _isCheckedJakeNight, value); }


    // Feed
    public bool IsCheckedFoodMorning { get => _isCheckedFoodMorning; set => SetField(ref _isCheckedFoodMorning, value); }
    public bool IsCheckedFoodNoon { get => _isCheckedFoodNoon; set => SetField(ref _isCheckedFoodNoon, value); }
    public bool IsCheckedFoodNight { get => _isCheckedFoodNight; set => SetField(ref _isCheckedFoodNight, value); }

    // Private
    private bool _isCheckedLuluGarage;
    private bool _isCheckedLuluInside;
    private bool _isCheckedLuluOutside;
    private bool _isCheckedJakeGarage;
    private bool _isCheckedJakeInside;
    private bool _isCheckedJakeMorning;
    private bool _isCheckedJakeNight;
    private bool _isCheckedFoodMorning;
    private bool _isCheckedFoodNoon;
    private bool _isCheckedFoodNight;

    // OnPropertyChanged stuff below here
    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        field = value;
        OnPropertyChanged(propertyName);

        var valueAsBool = (value as bool?) ?? false;
        FixAnyConflictingCheckBoxes(propertyName ?? "", valueAsBool);

        return true;
    }

    private void FixAnyConflictingCheckBoxes(string propertyName, bool newValue)
    {
        if (!IsFinishedLoading) return;
        
        // If someone's un-checking things, don't do anything:
        if (!newValue) return;
        
        // Set this so we can use the properties without it trying to do, well, this:
        IsFinishedLoading = false;

        switch (propertyName)
        {
            // Lulu Location Fixes
            case nameof(IsCheckedLuluGarage):
                IsCheckedLuluInside = false;
                IsCheckedLuluOutside = false;
                break;

            case nameof(IsCheckedLuluInside):
                IsCheckedLuluGarage = false;
                IsCheckedLuluOutside = false;
                break;
            
            case nameof(IsCheckedLuluOutside):
                IsCheckedLuluGarage = false;
                IsCheckedLuluInside = false;
                break;

            // Jake Location
            case nameof(IsCheckedJakeGarage):
                IsCheckedJakeInside = false;
                break;

            case nameof(IsCheckedJakeInside):
                IsCheckedJakeGarage = false;
                break;
        }

        IsFinishedLoading = true;
    }
}
