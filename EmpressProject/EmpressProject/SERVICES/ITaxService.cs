namespace EmpressProject.SERVICES
{
    //calcula a taxa 
    public interface ITaxService
    {
        //interface que iremos utilizar para as taxas aplicadas
        double tax(double amount, int quantity);
    }
}
