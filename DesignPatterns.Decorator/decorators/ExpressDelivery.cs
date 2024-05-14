using DesignPatterns.Decorator.base_models;

namespace DesignPatterns.Decorator.decorators
{
    internal class ExpressDelivery(Delivery delivery) : DeliveryDecorator(delivery)
    {
        public override decimal TotalPrice()
            => base.TotalPrice() + 9.99M;

        public override string Info()
            => $"consegna express, {base.Info()} {TotalPrice()} euro";
    }
}
