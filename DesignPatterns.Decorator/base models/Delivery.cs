namespace DesignPatterns.Decorator.base_models
{
    internal abstract class Delivery
    {
        public abstract decimal TotalPrice();

        public virtual string Info()
            => $"il prezzo è";
    }
}
