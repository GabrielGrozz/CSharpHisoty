namespace EmpressProject.SERVICES
{
    // service que irá calcular o valor de cada installment
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

        //método que irá calcular, primeiró pegando o valor total e dividindo pela quantidade de parcelas e após isso irá aplicar as taxas
        //após issó irá gerar um novo instalment e chamar o Generator.Generate que irá adicionar a installment no Contract
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
