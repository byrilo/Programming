# Лаба 4. Наследование — краткие заметки

## Термины

**Наследование** — новый класс (производный) берёт члены существующего (базового) и добавляет свои.
`class PriorityOrder : Order` — `Order` базовый, `PriorityOrder` производный.

- Отношение *is-a*: приоритетный заказ **является** заказом. В UML — обобщение (сплошная линия, пустой треугольник у `Order`).
  Не путать с агрегацией и композицией (*has-a*, «имеет»).
- Объект наследника можно хранить в переменной базового типа: `Order order = new PriorityOrder(...)` (полиморфизм).
  Поэтому в одном `List<Order>` лежат и `Order`, и `PriorityOrder`.
- Реальный тип проверяют через `is` / `as`: `order as PriorityOrder` даёт `null`, если заказ обычный.
- Конструкторы **не наследуются**, но базовый можно вызвать: `: base(address, items)`.
  Сначала выполняется конструктор `Order`, потом тело конструктора `PriorityOrder`.
- Наследуются все члены, но доступ зависит от модификатора:
  `private` — не виден в наследнике (поля `_id`, `_status` и др. есть в объекте, но доступны только через публичные свойства),
  `protected` — виден в наследнике, `public` — виден везде.
- Вид наследования в C# один (публичный), `: private Order` как в C++ нет.

## Что нового в лабе

Приоритетный заказ: обычный заказ плюс желаемая дата и время доставки.
Приоритетным заказ становится, если покупатель помечен как приоритетный.

| Файл | Что нового |
|---|---|
| `Model/PriorityOrder.cs` | Класс `PriorityOrder : Order`, поля доставки (подробнее ниже) |
| `Model/Customer.cs` | Свойство `IsPriority` (по умолчанию `false`) |
| `View/Tabs/CustomersTab` | Флажок **Is Priority**, меняет `IsPriority` выбранного покупателя |
| `View/Tabs/CartsTab.cs` | **Create Order** создаёт `PriorityOrder` для приоритетного покупателя, иначе `Order` |
| `View/Tabs/OrdersTab` (+ `Designer`) | Панель **Priority Options** с временем доставки; видна только для `PriorityOrder` (определяется через `as`) |
| `View/Tabs/PriorityOrdersTab` | Учебная вкладка с одним приоритетным заказом (Add/Remove Item, Clear Order); из главного меню убрана, класс оставлен |
| `MainForm.cs`, `MainForm.Designer.cs` | Убрана вкладка Priority Orders |
| `doc/.../Lab4/Practics4.eapx`, `.png` | UML: `PriorityOrder` с наследованием от `Order`, `IsPriority` в `Customer`, связь Store–Customer — агрегация |

## Как это работает

1. Customers: отмечаем покупателя флажком **Is Priority**.
2. Cart: **Create Order** смотрит на `IsPriority` и создаёт нужный класс; заказ попадает в `Customer.Orders`.
3. Orders: выбираем заказ в таблице. Если это `PriorityOrder`, справа появляется панель с временем доставки, выбранное время пишется в заказ.

## Как хранятся и передаются данные

- Покупатели лежат в `Store.Customers` (`List<Customer>`). Во вкладки список передаётся по ссылке, это один и тот же объект.
- `Address` — объект в `Customer.Address` и `Order.Address`. `AddressControl` получает ссылку и правит объект напрямую.
- При создании заказа адрес передаётся **по ссылке** (изменение адреса покупателя изменит и адрес в заказе),
  а список товаров **копируется** (очистка корзины на заказ не влияет).

## Файл `PriorityOrder.cs`

- `class PriorityOrder : Order`: от `Order` берёт `Id`, `Created`, `Address`, `Items`, `Status`, `Amount`.
- Свои члены:
  - `AvailableDeliveryTimes` — шесть допустимых интервалов (`9:00 - 11:00` … `19:00 - 21:00`).
  - `DesiredDate` — желаемая дата (`DateTime`).
  - `DesiredTime` — желаемое время; в сеттере проверка по `AvailableDeliveryTimes`, иначе `ArgumentException`.
- Конструктор `PriorityOrder(address, items, desiredDate, desiredTime)` вызывает `: base(address, items)` и задаёт только свои поля.
- Время сделано строкой, а не enum (оба варианта разрешены в п. 5 задания). Поэтому нужно поле `_desiredTime` для проверки в сеттере; в UI это `ComboBox` в режиме `DropDownList`.
- Поле `_desiredDate` не обязательно: проверки у даты нет, хватило бы автосвойства.
