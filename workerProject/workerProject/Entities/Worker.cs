using System.Runtime.Serialization;
using workerProject.Entities.Enums;

namespace workerProject.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }

        //como não teremos uma quantidade de contratos específica, usaremos uma lista para que possamos colocar todos
        //os nossos contratos armazenados
        public List<HourContract> Contracts { get; set; }

        public Worker()
        {
        }

        //nos construtores não se é muito usual colocarmos listas em um parametro, ela deve começar vazia, e assim devemos
        //ir acrecentando conteudo nela após instanciada
        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        //método, que como não possui uma lógica realmente, ele pode ser do tipo void, pois só adiciona um contrato na lista
        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        //mesma lógica do add
        public void removeContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        //método que irá calcular o total que o trabalhador tirou, com o salário base mais os contratos
        public double income(int year, int month)
        {
            double sum = BaseSalary;

            //para usarmos o foreach precisamos colocar o tipo do valor que será percorrido

            //se no contrato que estiver sendo percorrido o ano e mes forem os mesmo que foi parametrado, pegar a soma total
            //do contrato e adicionar no som
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
