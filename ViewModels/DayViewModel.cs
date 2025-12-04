using AdventOfCode2020.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace AdventOfCode2020.ViewModels
{
    internal class DayViewModel(Day day) : ViewModelBase
    {
        private readonly Day _day = day;
        public string DayName => _day.ToString();

        public ICommand RunDailyInputCommand { get; }
        public ICommand RunDailyUnitTestCommand { get; }
    }
}
