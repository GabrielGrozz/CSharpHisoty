using System.Globalization;
using EmpressProject.ENTITIES;

namespace EmpressProject.SERVICES
{
    internal class InstallmentCreator
    {
        public Contract ContractData { get; set; }
        public int InstallmentQuantity { get; set; }
        public double InstallmentValue { get; set; }

        public InstallmentCreator(Contract contract, int installmentQuantity, double installmentValue)
        {
            ContractData = contract;
            InstallmentQuantity = installmentQuantity;
            InstallmentValue = installmentValue;
        }

        public void Generate()
        {
            DateTime dueDate = ContractData.Date.AddMonths(InstallmentQuantity + 1);

            Installment generatedInstallment = new Installment(dueDate, InstallmentValue);

            ContractData.Installments.Add(generatedInstallment);
        }
}
}
