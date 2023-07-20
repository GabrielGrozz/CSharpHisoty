namespace GEnerics2.Services
{
    //essa classe/service será para calcualar qual dos product é mais caro
    internal class CalculationService
    {
        public int Max(List<int> list)
        {
            // o .Count pega o tamanho da list
            if (list.Count == 0)
            {
                throw new ArgumentException("the list is empty");
            }

            int max = list[0];

            //basicamente se o valor dos próximos arrays for maior que o anterior, ele é o maior
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }

            }

            return max;
        }
    }
}
