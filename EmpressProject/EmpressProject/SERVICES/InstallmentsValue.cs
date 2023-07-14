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
        }

        public void CalcInstallmentsValue(ENTITIES.Contract contract)
        {
            InstallmentsTotalValue = contract.TotalValue / InstallmentsQuantity;


        }
    }
}
