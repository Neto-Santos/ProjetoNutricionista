using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNutricionista.Model
{
    public class Imc
    {
        //O Cálculo do IMC se faz dividindo o peso pela altura(em metros) ao quadrado (IMC = 80 ÷ 1,80²)
        public int Id { get; set; }
        public  double Peso { get; set; }
        public double Altura { get; set; }
    }
}
