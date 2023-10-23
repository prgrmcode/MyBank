using Backend.Cards;

namespace Backend.Cards;

public class BankCard : Card
{
    public BankCard(Customer.Customer _customer) : base(_customer)
    {
        Customer = _customer;
    }
}
