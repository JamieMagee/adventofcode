﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdventOfCode.Core;

namespace AdventOfCode._2020.Puzzles.Solutions
{
    [Puzzle("Binary Boarding")]
    public sealed class Day05 : SolutionBase
    {
        
        protected override string Part1(string input)
        {
            return ParseInput(input).Max().ToString();
        }

        protected override string Part2(string input)
        {
            var parsedInput = ParseInput(input);
            var min = parsedInput.Min();
            var max = parsedInput.Max();
            return Enumerable.Range(min, max - min + 1).Single(id => !parsedInput.Contains(id)).ToString();
        }

        private static IEnumerable<int> ParseInput(string input)
        {
            return GetLines(input)
                .Select(row => Convert.ToInt32(
                    row.Replace("F", "0")
                        .Replace("B", "1")
                        .Replace("L", "0")
                        .Replace("R", "1"),
                    2)
                );
        }
    }
}