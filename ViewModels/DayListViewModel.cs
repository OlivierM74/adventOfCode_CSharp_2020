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

            _days.Add(new DayViewModel(new Day(1)));
            _days.Add(new DayViewModel(new Day(2)));
            _days.Add(new DayViewModel(new Day(3)));
        }
    }
}
