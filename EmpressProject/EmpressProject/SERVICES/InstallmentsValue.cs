using System.Diagnostics.Contracts;

namespace EmpressProject.SERVICES
{
    //total que as parcelas irão ser
    internal class InstallmentsValue
    {
        public int InstallmentsQuantity { get; set; }
        public double InstallmentsTotalValue { get; set; }

        public InstallmentsValue(int installmentsQuantity, double installmentsValue)
        {
            InstallmentsQuantity = installmentsQuantity;
            InstallmentsTotalValue = installmentsValue;
        }

        public void CalcInstallmentsValue(Contract contract)
        {
            

        }
    }X
}
