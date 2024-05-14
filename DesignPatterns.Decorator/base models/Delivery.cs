namespace DesignPatterns.Decorator.base_models
{
    internal abstract class Delivery
    {
        protected decimal _price;

        protected Delivery() { }

        protected Delivery(decimal price) 
        {
            _price = price;
        }

        public virtual string Info()
            => $"il prezzo è {_price} euro";
    }
}
