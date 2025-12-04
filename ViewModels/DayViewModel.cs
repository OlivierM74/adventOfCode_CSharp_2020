using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace AdventOfCode2020.ViewModels
{
    internal class DayViewModel: ViewModelBase
    {
        private int _dayId;
        public int DayId { 
            get { return _dayId; } 
            set {
                _dayId = value; 
                OnPropertyChanged(nameof(DayId));
            } 
        }

        public ICommand RunDailyInputCommand { get; }
        public ICommand RunDailyUnitTestCommand { get; }
    }
}
