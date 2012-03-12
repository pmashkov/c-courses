using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop
{
    abstract class Items
    {
        public int cost;
        public string name;
        public string model;

        public Items(string _name, int _cost, string _model)
        {
            name = _name;
            cost = _cost;
            model = _model;
        }

        public abstract string Show();

    }

    class Nouts : Items
    {
        public int timeWorck;
        public int monitor;
        public int prosessor;
        public string companyName;

        public Nouts(string _name, int _cost, string _model, int _timeWorck, int _monitor, int _prosessor, string _companyName)
            : base( _name, _cost, _model)
        {
            timeWorck = _timeWorck;
            monitor = _monitor;
            prosessor = _prosessor;
            companyName = _companyName;

            
        }
        public override string Show()
        {
            
            if (companyName == "Asus")
            {
                return "Дополнительно: Гарантия 2 года";
            }

            return "Дополнительно: Гарантии нет";
        }
    }
}
