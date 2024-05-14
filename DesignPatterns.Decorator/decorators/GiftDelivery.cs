using DesignPatterns.Decorator.base_models;

namespace DesignPatterns.Decorator.decorators
{
    internal class GiftDelivery : DeliveryDecorator
    {
        public GiftDelivery(Delivery delivery) : base(delivery)
        {
            _price = 3.99M;
        }

        public override string Info()
            => $"imballaggio regalo, il prezzo è {_price} euro";
    }
}
