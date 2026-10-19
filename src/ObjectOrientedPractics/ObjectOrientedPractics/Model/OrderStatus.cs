namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Состояние заказа в процессе его выполнения.
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// Новый заказ.
        /// </summary>
        New,

        /// <summary>
        /// Заказ обрабатывается.
        /// </summary>
        Processing,

        /// <summary>
        /// Заказ собирается на складе.
        /// </summary>
        Assembly,

        /// <summary>
        /// Заказ отправлен.
        /// </summary>
        Sent,

        /// <summary>
        /// Заказ доставлен.
        /// </summary>
        Delivered,

        /// <summary>
        /// Возврат заказа.
        /// </summary>
        Returned,

        /// <summary>
        /// Заказ отменён со стороны магазина.
        /// </summary>
        Abandoned
    }
}
