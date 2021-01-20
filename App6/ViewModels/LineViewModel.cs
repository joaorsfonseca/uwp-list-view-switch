using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App6.ViewModels
{
    public class LineViewModel : BindableBase
    {
        private bool _pricePerSize;
        public bool PricePerSize
        {
            get => _pricePerSize;
            set
            {
                Set(ref _pricePerSize, value);
            }
        }

        public List<SizeViewModel> Sizes { get; set; }

        public LineViewModel()
        {
            Sizes = new List<SizeViewModel>()
            {
                new SizeViewModel()
                {
                    Size="3XS", Quantity = 2
                },
                new SizeViewModel()
                {
                    Size="XXS", Quantity = 4
                }
            };
        }
    }

    public class SizeViewModel
    {
        public string Size { get; set; }

        public int Quantity { get; set; }
    }
}
