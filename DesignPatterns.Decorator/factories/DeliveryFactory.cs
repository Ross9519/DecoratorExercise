using DesignPatterns.Decorator.base_models;
using DesignPatterns.Decorator.enums;
using DesignPatterns.Decorator.decorators;

namespace DesignPatterns.Decorator.factories
{
    internal static class DeliveryFactory
    {
        public static Delivery GetDelivery(DeliveryEnum type, Delivery? delivery = null) => type switch
        {
            DeliveryEnum.Standard => new StandardDelivery(delivery!),
            DeliveryEnum.Express => new ExpressDelivery(delivery!),
            DeliveryEnum.Gift => new GiftDelivery(delivery!),
            DeliveryEnum.Store => new NoDelivery(),
            _ => throw new NotSupportedException()
        };
    }
}
