using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using MaterialDesignColors;
using MaterialDesignThemes.Wpf;
using Theme = MaterialDesignThemes.Wpf.Theme;

namespace MyFinances
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly PaletteHelper _PaletteHelper = new PaletteHelper();

        public List<ThemeColorViewModel> ThemeColors { get; } = new List<ThemeColorViewModel>();

        public ICommand SetThemeCommand { get; }

        //The starting value of this must match which resource dictionary we loaded in the App.xaml, in this case the light MDIX theme
        private bool _IsLightTheme = true;
        public bool IsLightTheme
        {
            get => _IsLightTheme;
            set
            {
                if (Set(ref _IsLightTheme, value))
                {
                    ITheme theme = _PaletteHelper.GetTheme();
                    theme.SetBaseTheme(value ? Theme.Light : Theme.Dark);
                    _PaletteHelper.SetTheme(theme);
                }
            }
        }

        public MainWindowViewModel()
        {

            ThemeColors.AddRange(Enum.GetNames(typeof(MaterialDesignColor))
                .Where(x => Enum.TryParse<MaterialDesignColor>($"{x}Secondary", out _))
                .Select(x =>
                {
                    var primary = (MaterialDesignColor)Enum.Parse(typeof(MaterialDesignColor), x);
                    var secondary = (MaterialDesignColor)Enum.Parse(typeof(MaterialDesignColor), $"{x}Secondary");
                    Theme theme = Theme.Create(Theme.Light,
                        SwatchHelper.Lookup[primary],
                        SwatchHelper.Lookup[secondary]);
                    return new ThemeColorViewModel(theme, x);
                }));

          

            IThemeManager themeManager = Application.Current.Resources.GetThemeManager();
            themeManager.ThemeChanged += ThemeManagerOnThemeChanged;

            SetThemeCommand = new RelayCommand<ThemeColorViewModel>(OnSetTheme);

        }

        private void ThemeManagerOnThemeChanged(object sender, ThemeChangedEventArgs e)
        {

        }

        private void OnSetTheme(ThemeColorViewModel themeVm)
        {
            if (themeVm == null) throw new ArgumentNullException(nameof(themeVm));

            ITheme theme = themeVm.Theme;
            theme.SetBaseTheme(IsLightTheme ? Theme.Light : Theme.Dark);
            _PaletteHelper.SetTheme(theme);
        }

    }
}
