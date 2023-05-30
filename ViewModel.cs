using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapsExample
{
    public class ViewModel
    {
        public ObservableCollection<Model> Data { get; set; }
        public ViewModel() 
        {
            Data = new ObservableCollection<Model>();
            Data.Add(new Model(117, "Albania", 3195000, 111));
            Data.Add(new Model(15, "Argentina", 40091359, 14));
            Data.Add(new Model(102, "Austria", 8372930, 100));
            Data.Add(new Model(359, "Belgium", 10827519, 355));
            Data.Add(new Model(23, "Brazil", 206598985, 24));
            Data.Add(new Model(80, "Cambodia", 14805000, 82));
            Data.Add(new Model(4, "Canada", 35151728, 3.4));
            Data.Add(new Model(143, "China", 1389750000, 144));
            Data.Add(new Model(394, "India", 1198003000, 364));
            Data.Add(new Model(504, "Korea", 48456369, 487));
        }
    }
}
