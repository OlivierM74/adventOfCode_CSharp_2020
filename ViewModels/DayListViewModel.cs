using AdventOfCode2020.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace AdventOfCode2020.ViewModels
{
    internal class DayListViewModel : ViewModelBase
    {
        private readonly ObservableCollection<DayViewModel> _days;
        public IEnumerable<DayViewModel> Days => _days;
        public ICommand RunDailyInputCommand { get; }
        public ICommand RunDailyUnitTestCommand { get; }

        public DayListViewModel()
        {
            _days = new ObservableCollection<DayViewModel>();

            _days.Add(new DayViewModel(new Day(1, "short descrption of day 1", "long description of day 1")));
            _days.Add(new DayViewModel(new Day(2, "short descrption of day 2", "long description of day 2")));
            _days.Add(new DayViewModel(new Day(3, "short descrption of day 3", "long description of day 3")));
        }
    }
}
