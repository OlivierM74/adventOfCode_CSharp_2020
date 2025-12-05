using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2020.Models
{
    internal class Day(int n, string shortDescription, string description)
    {
        public int Id { get; set; } = n;
        public string ShortDescription { get; set; } = shortDescription;
        public string Description { get; set; } = description;

        public override string ToString()
        {
            return $"Day{Id}";
        }
    }
}
