using DesignPatterns.Decorator.base_models;

namespace DesignPatterns.Decorator.decorators
{
    internal class ExpressDelivery : DeliveryDecorator
    {
        public ExpressDelivery(Delivery delivery) : base(delivery)
        {
            _price = 9.99M;
        }

        public override string Info()
            => $"consegna express, {base.Info()}";
    }
}
