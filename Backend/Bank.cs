namespace Backend;

using Backend.Accounts;
using Backend.Cards;
using Backend.Customer;

public class Bank
{
    public List<Customer.Customer> Customers { get; } = new ();
    public List<CurrentAccount> CurrentAccounts { get; } = new List<CurrentAccount>();
    public List<SavingAccount> SavingsAccounts { get; } = new List<SavingAccount>();
    

    public Bank()
    {
    }

    public Customer.Customer AddCustomer(Customer.Customer _customer)
    {
        if (!Customers.Contains(_customer))
        {
            Customers.Add(_customer);
            Console.WriteLine($"Customer added to bank: {_customer.ToJson()}");
            return _customer;
        }
        else
        {
            Console.WriteLine($"Customer is already existing in bank");
            return null;
        }
    }

    public Customer.Customer AddCustomer(String _name, String _phone, DateTime _birthday)
    {
        Customer.Customer _customer = new (_name, _phone, _birthday); //

        if (!Customers.Contains(_customer))
        {
            Customers.Add(_customer);
            Console.WriteLine($"Customer added to bank: {_customer.ToJson()}");
            return _customer;
        }
        else
        {
            Console.WriteLine($"Customer is already existing in bank");
            return null;
        }
    }

    public Customer.Customer AddCustomer()
    {
        Customer.Customer _customer = new ();
        if (!Customers.Contains(_customer))
        {
            Customers.Add(_customer);
            Console.WriteLine($"Customer added to bank: {_customer.ToJson()}");
            return _customer;
        }
        else
        {
            Console.WriteLine($"Customer is already existing in bank");
            return null;
        }
    }

    public CurrentAccount CreateCurrentAccount()
    {
        CurrentAccount _currentAccount = new ();
        
        CurrentAccounts.Add(_currentAccount);
        Console.WriteLine($"Current Account created: {_currentAccount.ToString()}");
        return _currentAccount;
    }

    public SavingAccount CreateSavingAccount()
    {
        SavingAccount _savingAccount = new ();
        
        SavingsAccounts.Add(_savingAccount);
        Console.WriteLine($"Saving Account created: {_savingAccount.ToString()}");
        return _savingAccount;
    }

    public void AddCustomerToAccount(Account _account, Customer.Customer _customer)
    {
        _account.AddCustomer(_customer);
    }


    public void AddBankCardToCurrentAccount(CurrentAccount _currentAccount, BankCard _bankCard)
    {
        _currentAccount.AddBankCard(_bankCard);
    }

    public void RemoveBankCardFromCurrentAccount(CurrentAccount _currentAccount, BankCard _bankCard)
    {
        _currentAccount.RemoveBankCard(_bankCard);
    }

    
}
