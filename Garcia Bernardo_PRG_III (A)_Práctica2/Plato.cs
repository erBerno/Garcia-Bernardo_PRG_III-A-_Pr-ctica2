using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garcia_Bernardo_PRG_III__A__Práctica2
{
    internal class Plato
    {
        public string platoName { get; set; }
        public int platoPrice { get; set; }

        List<Ingrediente> ingredientes;
        public List<Ingrediente> Ingredientes { get { return ingredientes; } }

        public Plato(string name, int price)
        {
            platoName = name;
            platoPrice = price;
            ingredientes = new List<Ingrediente>();
        }

        public Plato(string name, int price, List<Ingrediente> ingredientes)
        {
            platoName = name;
            platoPrice = price;
            this.ingredientes = ingredientes;
        }
    }
}
