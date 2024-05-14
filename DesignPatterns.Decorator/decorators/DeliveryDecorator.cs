using DesignPatterns.Decorator.base_models;

namespace DesignPatterns.Decorator.decorators
{
    internal abstract class DeliveryDecorator(Delivery delivery) : Delivery
    {
        protected Delivery _delivery = delivery;

        public override string Info()
            => _delivery.Info();
    }
}
