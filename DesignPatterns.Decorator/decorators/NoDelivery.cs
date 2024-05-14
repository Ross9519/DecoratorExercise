using DesignPatterns.Decorator.base_models;

namespace DesignPatterns.Decorator.decorators
{
    internal class NoDelivery : Delivery
    {
        public override string Info()
            => $"consegna in negozio, {base.Info()} {TotalPrice()} euro";

        public override decimal TotalPrice()
            => 0;
    }
}
