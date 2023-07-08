namespace ExceptionProject.ENTITIES.EXCEPTIONS
{
    internal class DomainException : Exception
    {
        // esse é a nossa excessão personalizada
        //para criarmos uma excessão simples basta criarmos um construtor e nele usarmos a superclasse passando uma string que será a mensagem de erro
        internal DomainException(string errorMessage) : base(errorMessage) { }
    }
}
