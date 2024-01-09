using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Inlämning_Affär
{
    internal class Groceries
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public Groceries(string name, int price ) 
        { 
            Name = name;
            Price = price;
        }

        public string GetCSV()
        {
            return Name + "," + Price;

        }

    }
}
