using DesignPatterns.Decorator.base_models;

namespace DesignPatterns.Decorator.decorators
{
    internal class NoDelivery() : Delivery(0M)
    {
        public override string Info()
            => $"consegna in negozio, il prezzo è {_price} euro";
    }
}
