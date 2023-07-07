using Exception.ENTITIES

namespace Exception.ENTITIES
{
    internal class Reservation
    {
        internal int RoomNumver { get; set; }
        internal DateTime CheckIn { get; set; }
        internal DateTime CheckOut { get; set; }

        public Reservation() { }
        public Reservation(int roomNumver, DateTime checkIn, DateTime checkOut)
        {
            RoomNumver = roomNumver;
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

        internal void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            //basicamente se o checkin ou checkout forem de dias anteriores a agora lançaremos uma Exception
            if (CheckIn < now || CheckOut < now) {
                throw new Dom
            }
        }
    }
}
