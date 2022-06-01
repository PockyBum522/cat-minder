using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CatMinder.UI.CustomControls;

public partial class CustomCheckBox : ContentView
{
    #if ANDROID
        private CatMinder.Platforms.Android.ToastMessage _toaster;
    #endif

    public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(CustomCheckBox), string.Empty);

    public string Text
    {
        get => (string)GetValue(CustomCheckBox.TextProperty);
        set => SetValue(CustomCheckBox.TextProperty, value);
    }

    public static readonly BindableProperty IsCheckedProperty = 
        BindableProperty.Create
            (nameof(IsChecked), 
                typeof(bool), 
                typeof(CustomCheckBox), 
                false,
                BindingMode.TwoWay);

    public bool IsChecked
    {
        get => (bool)GetValue(CustomCheckBox.IsCheckedProperty);
        set { 

#if ANDROID
                _toaster = new CatMinder.Platforms.Android.ToastMessage();

                    
                _toaster.ShortToast($"IsCheckedLuluGarageCustom:{Environment.NewLine}" +
                                     $"{IsChecked}");
#endif
            
            SetValue(CustomCheckBox.IsCheckedProperty, value);
            OnPropertyChanged();

#if ANDROID

                _toaster.ShortToast($"IsCheckedLuluGarageCustom:{Environment.NewLine}" +
                                     $"{IsChecked}");
#endif
        }
    }
    

    public CustomCheckBox()
	{
		InitializeComponent();

        BindingContext = this;
    }
}