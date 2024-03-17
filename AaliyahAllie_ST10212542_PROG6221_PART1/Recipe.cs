using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AaliyahAllie_ST10212542_PROG6221_PART1
{
    public class Recipe
    {
        public string recipeName { get; set; }
        public List<string> ingredientNames { get; set; }
        public List<int> ingredientQuantities { get; set; }
        public List<string> UnitOfMeasurements { get; set; }
        public List<String> Steps { get; set; }

    }
}
