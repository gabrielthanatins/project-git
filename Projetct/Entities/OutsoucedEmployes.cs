namespace Projetct.Entities
{
    class OutsoucedEmployes : Employes
    {
        public double AdditionalCharge { get; set; }
        public OutsoucedEmployes()
        {
        }

        public OutsoucedEmployes(string name, int hours, double valuePerHour, double additionalCharge)
            : base (name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
