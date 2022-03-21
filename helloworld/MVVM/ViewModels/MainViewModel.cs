using helloworld.Core;
using helloworld.MVVM.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace helloworld.MVVM.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;
        private readonly NavigationStore _navigationStore;

        public MainViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public ICommand ToAboutCommand => new DelegateCommand(obj =>
        {
            _navigationStore.CurrentViewModel = new AboutVM();
            OnPropertyChanged(nameof(CurrentViewModel));
        });

        public ICommand ToHomeCommand => new DelegateCommand(obj =>
        {
            _navigationStore.CurrentViewModel = new HomeVM();
            OnPropertyChanged(nameof(CurrentViewModel));
        });
    }
}
