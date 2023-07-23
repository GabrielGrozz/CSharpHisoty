namespace GEnerics2.Services
{
    //essa classe/service será para calcualar qual dos product é mais caro
    internal class CalculationService 
    {
        //podemos fazer métodos genéricos
        //precisamos informar que alem de ele retornar um resultado genético, precisamo informar que o método em si é genérico
        //a parte where irá dizer que: esse método será genérico, mas somente quando a classe implementar o ICompareble
        public G Max<G>(List<G> list) where G : IComparable
        {
            // o .Count pega o tamanho da list
            if (list.Count == 0)
            {
                throw new ArgumentException("the list is empty");
            }

            G max = list[0];

            //basicamente se o valor dos próximos arrays for maior que o anterior, ele é o maior
            for (int i = 1; i < list.Count; i++)
            {
                //aqui iremos testar se o item da lista é maior que o max, mas precisamo colocar uma lógica com o IComparable para
                //dizer oque é maior que o que.
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }

            }

            return max;
        }
    }
}
