using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CatMinder.Platforms.Android;

namespace CatMinder.UI.MainPageDependencies;

public class MainPageViewModel : INotifyPropertyChanged
{
    // Lulu location
    public bool IsCheckedLuluGarage
    {
        get => _checkedLuluGarage;
        set
        { 
            _toaster = new CatMinder.Platforms.Android.ToastMessage();

                    
            _toaster.ShortToast($"IsCheckedLuluGarageVM:{Environment.NewLine}" +
                                $"{_checkedLuluGarage}");

            
            SetField(ref _checkedLuluGarage, !_checkedLuluGarage);
            OnPropertyChanged();


            _toaster.ShortToast($"IsCheckedLuluGarageVM:{Environment.NewLine}" +
                                $"{_checkedLuluGarage}");
        }
    }

    public bool IsCheckedLuluInside { get; set; }
    public bool IsCheckedLuluOutside { get; set; }

    // Jake Location
    public bool IsCheckedJakeGarage { get; set; }
    public bool IsCheckedJakeInside { get; set; }

    // Jake Drops
    public bool IsCheckedJakeMorning { get; set; }
    public bool IsCheckedJakeNight { get; set; }

    // Feed
    public bool IsCheckedFoodMorning { get; set; }
    public bool IsCheckedFoodNoon { get; set; }
    public bool IsCheckedFoodNight { get; set; }

    // Private
    private bool _checkedLuluGarage;

    private ToastMessage _toaster;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
    {
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}
