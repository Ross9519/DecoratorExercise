using DesignPatterns.Decorator.base_models;

namespace DesignPatterns.Decorator.decorators
{
    internal class GiftDelivery(Delivery delivery) : DeliveryDecorator(delivery)
    {
        public override decimal TotalPrice()
            => base.TotalPrice() + 3.99M;

        public override string Info()
            => $"imballaggio regalo, {base.Info()} {TotalPrice()} euro";
    }
}
