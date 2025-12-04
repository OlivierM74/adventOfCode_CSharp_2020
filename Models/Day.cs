using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2020.Models
{
    internal class Day(int n)
    {
        public int Id { get; set; } = n;
        public string? Description { get; set; }

        public override string ToString()
        {
            return $"Day{n}";
        }
    }
}
