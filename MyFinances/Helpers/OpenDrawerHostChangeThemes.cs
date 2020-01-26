using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyFinances.Helpers
{
    // Pop-up field for choosing a color theme

    public class OpenDrawerHostChangeThemes : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool _DrawerOpen;
        public bool DrawerOpen
        {
            get => _DrawerOpen;
            set
            {
                if (!value && LockDrawer)
                {
                    //If the drawer is locked open, prevent the change
                    return;
                }
                Set(ref _DrawerOpen, value);
            }
        }

        private bool _LockDrawer;
        public bool LockDrawer
        {
            get => _LockDrawer;
            set => Set(ref _LockDrawer, value);
        }

        private void Set<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                RaisePropertyChanged(propertyName);
            }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
