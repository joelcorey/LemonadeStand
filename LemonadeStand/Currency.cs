using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Currency
    {
        // Member variables
        private string name;
        private decimal defaultValue;
        private int numericDesignation;

        public string Name
        {
            get { return name; }
        }

        public decimal DefaultValue
        {
            get { return defaultValue; }
        }

        public int NumericDesignation
        {
            get { return numericDesignation; }
        }

        // Constructor
        public Currency(string name, int defaultValue, int numericDesignation)
        {
            this.name = name;
            this.defaultValue = defaultValue;
            this.numericDesignation = numericDesignation;
        }

        // Member methods
    }
}
