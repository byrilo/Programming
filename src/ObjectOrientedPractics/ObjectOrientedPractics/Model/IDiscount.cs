namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Описывает расчёт, применение и накопление скидки покупателя.
    /// </summary>
    public interface IDiscount
    {
        /// <summary>Возвращает описание скидки.</summary>
        string Info { get; }

        /// <summary>Вычисляет скидку без изменения накоплений.</summary>
        /// <param name="items">Товары заказа.</param>
        /// <returns>Возможная скидка в рублях.</returns>
        double Calculate(List<Item> items);

        /// <summary>Применяет скидку и при необходимости списывает накопления.</summary>
        /// <param name="items">Товары заказа.</param>
        /// <returns>Применённая скидка в рублях.</returns>
        double Apply(List<Item> items);

        /// <summary>Обновляет накопления после покупки.</summary>
        /// <param name="items">Купленные товары.</param>
        void Update(List<Item> items);
    }
}
