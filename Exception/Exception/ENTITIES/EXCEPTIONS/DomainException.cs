namespace Exception.ENTITIES.EXCEPTIONS
{
    internal class DomainException : ApplicationException
    {
        // essa é a nossa exception personalizada que iremos utilizar

        //criamos um construtor para a nossa excessão passando uma string que será a mensagem de erro que será lançada caso a nossa exception seja chamada
        internal DomainException(string message) : base(message) { }
    }
}
