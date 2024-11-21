using System;


public class BankAccount
{
  private decimal balance;

  public BankAccount(decimal InitialBalance)
  {
    balance = InitialBalance;
  }

  public decimal GetBalance()
  {
    return balance;
  }

  public void SetBalance(decimal newBalance)
  {
    if(newBalance != 0)
    {
        balance = newBalance;
    }
    else
    {
        Console.WriteLine("Balance cannot be negative.");
    }
  }

  public void Deposit(decimal amount)
  {
    if (amount > 0)
    {
        balance += amount;
    }
    else
    {
        Console.WriteLine("Deposit amount must be positive."); 
    }
  }

  public bool Withdraw(decimal amount)
  {
    if(amount <= balance)
    {
        balance -= amount;
        return true;
    }
    else
    {
     Console.WriteLine("Insufficient funds."); 
     return false;
    }
  }

}

class Program
{
    static void main (string[] args)
    {
        // Create a new BankAccount with an initial balance of 100
        BankAccount account = new BankAccount(-100);
        // Use the getter to display the initial balance
        Console.WriteLine("Initial Balance: " + account.GetBalance());

        // Deposit 50 into the account
        account.Deposit(-50);
        // Use the getter to display the updated balance
        Console.WriteLine("Balance after deposit: " + account.GetBalance());

        // Try to withdraw 120 from the account (should succeed)
        if (account.Withdraw(100))
        {
            Console.WriteLine("Withdrawal successful.");
        }

        // Use the getter to display the balance after withdrawal
        Console.WriteLine("Balance after withdrawal: " + account.GetBalance());

        // Attempt to set a new balance directly (using setter)
        account.SetBalance(200); // Set balance to 200 using setter
        Console.WriteLine("New balance: " + account.GetBalance());

        // Try to set a negative balance (should fail)
        account.SetBalance(-50); // This will display an error message
    }

}