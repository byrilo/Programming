namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Накопительная скидка. Один балл равен одному рублю.
    /// </summary>
    public class PointsDiscount : IDiscount
    {
        /// <summary>Возвращает количество накопленных баллов.</summary>
        public int Points { get; private set; }

        /// <inheritdoc/>
        public string Info => $"Накопительная – {Points} баллов";

        /// <inheritdoc/>
        public double Calculate(List<Item> items)
        {
            double amount = items.Sum(item => item.Cost);
            return Math.Min(Points, Math.Floor(amount * 0.30));
        }

        /// <inheritdoc/>
        public double Apply(List<Item> items)
        {
            int discount = (int)Calculate(items);
            Points -= discount;
            return discount;
        }

        /// <inheritdoc/>
        public void Update(List<Item> items)
        {
            double amount = items.Sum(item => item.Cost);
            Points += (int)Math.Ceiling(amount * 0.10);
        }
    }
}
