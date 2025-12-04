using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2020.ViewModels
{
    internal class MainViewModel: ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; }

        public MainViewModel()
        { 
            CurrentViewModel = new DayListViewModel();
        }
    }
}
