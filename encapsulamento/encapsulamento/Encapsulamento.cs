using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulamento
{
    internal class Encapsulamento
    {
        //quando adicionamos a palavra private, privamos a variavel a esse escopo, assim ela não pode ser chamada nem alterada diretamente
        // sendo necessário um método para fazer essa alteração
        private string _Name;
        private double _Salario;

        //podemos utilizar a auto propeties para lógica simopples, como apenas ebixir o conteudo da variavel
        public int Idade { get; private set; }
        public Encapsulamento(string name, double salario, int idade) {
            _Name = name;
            _Salario = salario;
            Idade = idade;
        }

        //esse seria um método get, que iremos utilizar quando quisermos utilizar a variável privada
        public string GetName() {
            return _Name;
        }

        //agora para alterarmos um valor utilizamos o setter
        public void SetName(string name)
        {
            _Name = name;
        }


        //no lugar de criarmos toda essa estrutura de get e set, podemos apenas utilziar uma proprietie, que irá funcionar do mesmo jeito
        public double Salario
        {
            //UTILIZAMOS O VALUE PARA REPRESENTAR O VALOR!!
            get { return _Salario; }
            set { _Salario = value;}
        }


    }
}

