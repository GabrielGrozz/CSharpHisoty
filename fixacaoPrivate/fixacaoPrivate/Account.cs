using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoPrivate
{
    internal class Account
    {
        private int _accountId;

        //para mostrarmos valor sem lógica podemos usar as auto proprieties propreties, que são declaradas direto na declaração dos valores dentro da classe!!!
        //no exemplo abaixo, definimos uma variável como pública para get, mas privada para set, então só poderemos ler ela, não alterar,
        //para alteralá, poderiamos definir ela como private e criarmos uma proprietie normal para get e set.
        public string _owner { get; private set; }
        private double _value;


        public Account(int accountId, string owner)
        {
            _accountId = accountId;
            _owner = owner;

        }
        public Account(int accountId, string owner, double value) : this(accountId, owner)
        {
            Deposito(value);
        }

        //caso fossemos utilizar uma lógica, como um if por exemplo, poderiamos utilizar uma proprietie normal, ou utilizarmos um método setter

        //aqui temos uma proprietie somente para leitura, que poderia ser feita diretamente na váriavel, com uma auto propretie
        public int Id { get { return _accountId; } }

        //aqui temos uma proprietie completa
        public double Value
        {
            get { return _value; }
            set { _value = value; }
        }


        //aqui temos um setter padrão
        // como elas não retornam um valor, mas sim simplemente alteram o valor da _value, ela pode ser void
        public void Deposito(double value)
        {
            _value += value;
        }
        public void SetWithdrawal(double value)
        {
            _value -= (value + 5);
        }
    }
}
