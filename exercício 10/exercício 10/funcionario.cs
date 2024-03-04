using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_10
{
    internal class funcionario
    {
        public funcionario() { }
        public string nome;
        public double salario;

        public double SalarioAnual(double salario)
        {
            return salario * 12;
        }
    }
}
