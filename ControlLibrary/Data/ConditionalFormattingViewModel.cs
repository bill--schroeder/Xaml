using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLibrary.Data
{
    public class ConditionalFormattingViewModel
    {
        public ConditionalFormattingViewModel()
        {
            //Items = SaleOverviewDataGenerator.GenerateSales();

            List<SaleOverviewData> _items = new List<SaleOverviewData>();

            for (int i = 1; i <= 10; i++)
            {
                //SaleOverviewData item = new SaleOverviewData("WI", 7.7, 3.3, 1.1, 5.5, 7.77);
                _items.Add(new SaleOverviewData("WI - " + i.ToString("00#"), i * 70101010.1, i * 3.3, i * 10101010.1, i * 0.5, i * 7.77));
            }

            Items = _items.ToArray();

        }

        public SaleOverviewData[] Items { get; private set; }
    }
}
