using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DottedLinechartSample
{
    public class ViewModel
    {
        public ObservableCollection<Model> ActualData { get; set; }
        public ObservableCollection<Model> Data { get; set; }

        public ViewModel()
        {
            Data = new ObservableCollection<Model>()
            {
                new Model() { Year = "2022", Revenue = 2},
                new Model() { Year = "2023", Revenue = 3.5},
                new Model() { Year = "2024", Revenue = 5},
                new Model() { Year = "2025", Revenue = 11},
                new Model() { Year = "2026", Revenue = 20},
                new Model() { Year = "2027", Revenue = 35},
            };

        }
    }
}
