using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuxuryCars.Models
{

    public class CarRootObj
    {
        public Car[] data { get; set; }
        public int to { get; set; }
    }

    public class Car
    {
        public int id { get; set; }
        public string marka_modelnev { get; set; }
        public int ferohely { get; set; }
        public int loero { get; set; }
        public string kep_Url { get; set; }
        public string video_Url { get; set; }
    }

}
