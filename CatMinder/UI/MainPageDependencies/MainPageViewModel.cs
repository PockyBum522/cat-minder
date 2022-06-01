using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatMinder.UI.MainPageDependencies;

internal class MainPageViewModel
{
    // Lulu location
    public bool IsCheckedLuluGarage { get; set; }
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
}
