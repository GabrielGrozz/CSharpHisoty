using Exception.ENTITIES.EXCEPTIONS;

namespace Exception.ENTITIES
{
    internal class Reservation
    {
        internal int RoomNumber { get; set; }
        internal DateTime CheckIn { get; set; }
        internal DateTime CheckOut { get; set; }

        public Reservation() { }
        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            //podemos tratar excessões também no construtor

            if (checkOut <= checkIn)
            {
                throw new DomainException("a data de checkOut deve ser para depois da data de checkIn");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        internal int Duration()
        {
            //timespan é um tipo que armazena tempo em forma de valor
            //subtract é um metódo do DateTime que pega a data da classe que o chamou e subtrai pela data que foi passada
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            //totaldays irá pegar o total de dias que sobrou após a subtração
            return (int)duration.TotalDays;
        }

        //esse é o nosso método para quando formos atualizar a reserva, nele terá varios testes para ver se estamos passando os valores corretos
        internal void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            //basicamente se o checkin ou checkout forem de dias anteriores a agora lançaremos uma Exception
            if (checkin < now || checkout < now)
            {
                //o throw serve para lansar algo, no exemplo abaixo estamos lansando uma instancia de uma excessão, isso irá fazer com que o programa pare a execução
                //de forma "meio por cima", o throw é como um return
                throw new DomainException("as datas devem ser para depois de hoje");
            }
            else if (checkout <= checkin)
            {
                throw new DomainException("a data de checkOut deve ser para depois da data de checkIn");
            }

            CheckIn = checkin;
            CheckOut = checkout;
        }

        public override string ToString()
        {
            return $"Reservation: Room {RoomNumber}, check -in: {CheckIn}, check -out: {CheckOut}, {Duration()} nights";
        }
    }
}
