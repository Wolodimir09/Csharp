using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Backpack
    {
        public string Color { get; private set; }
        public string BrandAndProducer { get; private set; }
        public string Cloth { get; private set; }
        public double Weight { get; set; }
        public double Volume { get; set; }
        public Dictionary<string, double> _content;

        public Backpack(string color,string brandAndProducer,string cloth,double weight,double volume)
        {
            Color = color;
            BrandAndProducer = brandAndProducer;
            Cloth = cloth;
            Weight = weight;
            Volume = volume;
            _content = new Dictionary<string, double>();
        }
        public string ToNameContent()
        {
            string result=" ";
            foreach (var item in _content)
            {
                result += $"{item.Key,-5}| ";
            }
            return result;
        }
        public override string ToString()
        {
            return "Ваш рюкзак:\n" +
                    $"\t{"Марка і виробник",20} - {BrandAndProducer,-15}\n"+
                    $"\t{"Колір",20} - {Color,-15}\n" +
                    $"\t{"Тканина",20} - {Cloth,-15}\n" +
                    $"\t{"Ваговий ліміт (кг)",20} - {Weight,-15}\n" +
                    $"\t{"Вільний об'єм (л)",20} - {Volume,-15}\n" +
                    $"\t{"Вміст",20} - " + ToNameContent(); 
        }


    }
}
