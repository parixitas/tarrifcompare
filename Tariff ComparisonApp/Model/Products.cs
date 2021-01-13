using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tariff_ComparisonApp.Model
{
    public class Products
    {
        public int Id { get; set; }
        public string product { get; set; }
        public string Name { get; set; }
        public int Consumption { get; set; }
        public int AnualCost { get; set; }
        public int CalOfAnualCostForProduct_A(int Consumption)
        {
            // Consumption Unit considering Consumption (kWh/year)
            int _AnualCost = 0;
            //: base costs per month 5 €
            int _basecost = 5;             
            // consumption costs 22 cent/kWh
            int _consumptioncost = 22;

            _AnualCost = ((_basecost * 12) + ((Consumption * _consumptioncost)/ 100));
            return _AnualCost;
        }
        public int CalOfAnualCostForProduct_B(int Consumption)
        {
            //800 € for up to 4000 kWh/year and above 4000 kWh/year additionally 30(cent / kWh.)

            int _AnualCost = 0;
            if (Consumption <= 4000)
            {
                _AnualCost = 800;
            }
            else {
                int _OverConsumption = (Consumption - 4000);
                _AnualCost = (800 + ((_OverConsumption * 30) / 100));
            }
            return _AnualCost;
        }

    }
}
