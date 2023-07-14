using EmpressProject.ENTITIES;
namespace EmpressProject.SERVICES
{
    internal class InstallmentCreator
    {

        public void InstallmentGenerator(Contract contract)
        {

            contract.Installments = new Installment();
          }

    }
}
