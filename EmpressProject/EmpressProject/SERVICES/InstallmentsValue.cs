using EmpressProject.ENTITIES;

namespace EmpressProject.SERVICES
{
    //total que as parcelas irão ser
    internal class InstallmentsValue
    {
        public int InstallmentsQuantity { get; set; }
        public double InstallmentsTotalValue { get; set; }

        private ITaxService _TaxService;

        public InstallmentsValue(int installmentsQuantity, ITaxService taxService)
        {
            InstallmentsQuantity = installmentsQuantity;
            _TaxService = taxService;
            InstallmentsTotalValue = 0;

        }


        public void CalcInstallmentsValue(ENTITIES.Contract contract)
        {
            InstallmentsTotalValue = contract.TotalValue / InstallmentsQuantity;

            for (int i = 0; i < InstallmentsQuantity; i++)
            {
                double ValueWithTax = _TaxService.tax(InstallmentsTotalValue, i);

                InstallmentCreator Generator = new InstallmentCreator(contract, i, ValueWithTax);

                Generator.Generate();
            }
        }
    }
}
