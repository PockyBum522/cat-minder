namespace CatMinder.UI.CustomControls;

public partial class CustomCheckBox : ContentView
{
    public string Text {
        get => GetValue(TextProperty).ToString() ?? "";
        set => SetValue(TextProperty, value);
    }

    public static BindableProperty TextProperty = 
        BindableProperty.Create(nameof(Text), typeof(string), typeof(CustomCheckBox), "");

    public bool CustomChecked {
        get => (bool)GetValue(CustomCheckedProperty);
        set => SetValue(CustomCheckedProperty, value);
    }

    public static BindableProperty CustomCheckedProperty = 
        BindableProperty.Create(nameof(CustomChecked), typeof(bool), typeof(CustomCheckBox), false, BindingMode.TwoWay);

    public CustomCheckBox()
    {
        BindingContext = this;

        InitializeComponent();
    }
}