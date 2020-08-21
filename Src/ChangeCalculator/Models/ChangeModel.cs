using System;
using System.Collections.Generic;
using System.Text;

namespace ChangeCalculator.Models
{
    public class ChangeModel
    {
        public int Hundreds { get; set; } = 0;
        public int Fifty { get; set; } = 0;
        public int Twenty { get; set; } = 0;
        public int Ten { get; set; } = 0;
        public int Five { get; set; } = 0;
        public int Two { get; set; } = 0;
        public int One { get; set; } = 0;
        public decimal FiftyPence { get; set; } = 0;
        public decimal TwentyPence { get; set; } = 0;
        public decimal TenPence { get; set; } = 0;
        public decimal FivePence { get; set; } = 0;
        public decimal TwoPence { get; set; } = 0;
        public decimal OnePence { get; set; } = 0;

    }
}
