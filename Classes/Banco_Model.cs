using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCaldeirasV2.Classes
{
    public class Banco_Model
    {
        public double pressao { get; set; }
        public double temperatura { get; set; }
        public double nivelAgua { get; set; }
        public double nivelCombustivel { get; set; }

        //public Banco_Model(double pressao, double temperatura, double nivelAgua, double nivelCombustivel)
        //{
        //    this.pressao = pressao;
        //    this.temperatura = temperatura;
        //    this.nivelAgua = nivelAgua;
        //    this.nivelCombustivel = nivelCombustivel;
        //}
    }
}
