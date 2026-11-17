using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Накопительная процентная скидка на одну категорию товаров.
    /// </summary>
    public class PercentDiscount : IDiscount
    {
        /// <summary>Возвращает категорию, на которую действует скидка.</summary>
        public Category Category { get; }

        /// <summary>Возвращает накопленную сумму покупок данной категории.</summary>
        public double PurchasedAmount { get; private set; }

        /// <summary>Возвращает действующий процент скидки от 1 до 10.</summary>
        public int Percent { get; private set; } = 1;

        /// <inheritdoc/>
        public string Info => $"Процентная «{Category}» - {Percent}%";

        /// <summary>Создаёт скидку на выбранную категорию.</summary>
        /// <param name="category">Категория товаров.</param>
        public PercentDiscount(Category category)
        {
            Category = category;
        }

        /// <inheritdoc/>
        public double Calculate(List<Item> items)
        {
            return GetCategoryAmount(items) * Percent / 100.0;
        }

        /// <inheritdoc/>
        public double Apply(List<Item> items)
        {
            return Calculate(items);
        }

        /// <inheritdoc/>
        public void Update(List<Item> items)
        {
            PurchasedAmount += GetCategoryAmount(items);
            Percent = (int)Math.Min(10, 1 + Math.Floor(PurchasedAmount / 1000));
        }

        /// <summary>Суммирует стоимость товаров категории скидки.</summary>
        /// <param name="items">Товары заказа.</param>
        /// <returns>Сумма товаров нужной категории.</returns>
        private double GetCategoryAmount(List<Item> items)
        {
            return items.Where(item => item.Category == Category).Sum(item => item.Cost);
        }
    }
}
