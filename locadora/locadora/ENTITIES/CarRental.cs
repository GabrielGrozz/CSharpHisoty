namespace locadora.ENTITIES
{
    internal class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }

        //o CarRental terá os valores do vihicle e do invoice(se possível olhar o esquemograma da aula)
        public Vehicle Vehicle { get; set; }

        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
            //o invoice irá começar como nulo, pois ele será gerado somente depois
            Invoice = null;
        }
    }
}
