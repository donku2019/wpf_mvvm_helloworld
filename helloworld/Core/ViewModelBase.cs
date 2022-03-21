using System.ComponentModel;

namespace helloworld.Core
{
    internal class ViewModelBase: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool isLoad;
        public bool IsLoad
        {
            get { return isLoad; }
            set
            {
                isLoad = value;
                OnPropertyChanged(nameof(IsLoad));
            }
        }

        private bool update;
        public bool Update
        {
            get { return update; }
            set
            {
                update = value;
                OnPropertyChanged(nameof(Update));
            }
        }
    }
}
