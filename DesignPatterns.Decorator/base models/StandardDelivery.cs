using DesignPatterns.Decorator.decorators;

namespace DesignPatterns.Decorator.base_models
{
    internal class StandardDelivery : DeliveryDecorator
    {
        public StandardDelivery(Delivery delivery) : base(delivery)
        {
            _price = 5.99M;
        }

        public override string Info()
            => $"consegna standard, il prezzo è {_price} euro";
    }
}
