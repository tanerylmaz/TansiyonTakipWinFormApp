using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TansiyonTakip
{
    public class Tansiyon
    {
        public static List<Tansiyon> TansiyonVerileri { get; set; } = new List<Tansiyon>();
        public DateTime Tarih { get; set; }
        public int Kucuk { get; set; }
        public int Buyuk { get; set; }
    }
}
