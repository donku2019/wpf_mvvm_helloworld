using helloworld.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld.MVVM.Stores
{
    internal class NavigationStore
    {
        public ViewModelBase CurrentViewModel { get; set; }
    }
}
