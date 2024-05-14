using DesignPatterns.Decorator.decorators;

namespace DesignPatterns.Decorator.base_models
{
    internal class StandardDelivery(Delivery delivery) : DeliveryDecorator(delivery)
    {
        public override decimal TotalPrice()
            => base.TotalPrice() + 5.99M;

        public override string Info()
            => $"consegna standard, {base.Info()} {TotalPrice()} euro";
    }
}
