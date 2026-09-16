namespace ECommerceAPI.Enums
{

    /// <summary>
    /// Initial Data for PaymentMethodMaster
    /// We will initially store the following payment methods:
    ///1 - Cash on Delivery - RequiresOnlinePayment: false - Active
    ///2 - Card             - RequiresOnlinePayment: true  - Active
    ///3 - UPI              - RequiresOnlinePayment: true  - Active
    /// </summary>

    public enum PaymentMethod
    {
        CashOnDelivery = 1,
        Card = 2,
        Upi = 3
    }
}
