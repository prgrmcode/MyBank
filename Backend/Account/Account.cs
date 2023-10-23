using System.Text.Json;
using Backend.Cards;
using Backend.Customer;

namespace Backend.Accounts;

public abstract class Account
{
    String _accountNumber;
    const int LENGTH = 10;

    protected Account()
    {
    }

    public String AccountNumber { 
        get { return _accountNumber; }
        set {
            if (value.Length == 10)
            {
                _accountNumber = value;                
            } else
            {
                System.Console.WriteLine("account number must be 10 digits");
            }

        } 
    }

    public static bool IsValidAccountNumber(int _number) {
        if (_number == LENGTH)
        {
            return true;
        } else
        {
            return false;
        }

    }

    public double Balance { get; set; }
    public List<Customer.Customer> Customers { get; set; } = new List<Customer.Customer>();
    public List<Card> Cards { get; set; } = new List<Card>();

    public Customer.Customer this[int index]
    {
        get {
            foreach (Customer.Customer cust in Customers)
            {
                if (cust.Id == index)
                {
                    return cust;
                    
                }
                
            }
            return null;
          }

    }

    

    
    public void AddCustomer(Customer.Customer _customer) {
        if (!Customers.Contains(_customer))
        {
            Customers.Add(_customer);
            Console.WriteLine($"Customer added to account: {this.ToString()}");
        }
        else
        {
            Console.WriteLine($"Customer is already existing in account");
        }
    }

    public void AddCard(Card _card) {
        if (!Cards.Contains(_card))
        {
            Cards.Add(_card);
            Console.WriteLine($"Card added to account: {this.ToString()}");
        }
        else
        {
            Console.WriteLine($"Card is already existing in account");
        }
    }

    public void RemoveAccount(List<Account> _accounts, Account _account) {
        if (_accounts.Contains(_account))
        {
            if (Balance == 0)
            {
                _accounts.Remove(_account);
                Console.WriteLine($"Account removed from accounts: {this.ToString()}");
            } else
            {
                Console.WriteLine($"Account has balance: {Balance}");
            }
        }
        else
        {
            Console.WriteLine($"Account is not existing in accounts");
        }
    }


    new public string ToString()
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true, // Format the JSON for readability
            };

            // Serialize the current instance to JSON
            string json = JsonSerializer.Serialize(this, options);

            return json;
        }



}
