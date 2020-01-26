using MaterialDesignThemes.Wpf;
using System;
using System.Windows.Media;

namespace MyFinances
{
    public class ThemeColorViewModel
    {
        public ThemeColorViewModel(ITheme theme, string name)
        {
            Theme = theme ?? throw new ArgumentNullException(nameof(theme));
            Name = name;
        }

        public Color SampleColor => Theme.PrimaryMid.Color;

        public string Name { get; }

        public ITheme Theme { get; }

    }
}
