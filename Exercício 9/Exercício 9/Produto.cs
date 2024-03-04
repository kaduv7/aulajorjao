using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_9
{
    internal class Produto
    {

        public string nome;
        public double Ddp(double preco, double desconto) 
        
        {
            return (preco-(desconto * (preco / 100)));
        }   
    }
}
