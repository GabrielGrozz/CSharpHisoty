namespace locadora.SERVICE
{
    //essa será a nossa interface, essa serve para deixarmos o nosso sistema de imposto de uma forma mais abstrata, assim podendo receber varios tipos de imposto
    //declaracao da interface se faz com a palavra interface
    interface ItaxService
    {
        double Tax(double amount);
    }
}
