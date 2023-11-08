using System;
class bank
{
    private string accountHolder;
    private decimal balance;
    public bank(string holder, decimal initialBalance)
    {
        accountHolder = holder;
        balance = initialBalance;
    }
    public void deposit(decimal amount)
    {
        balance += amount;
        Console.WriteLine("{0} deposited.\nNew Balance : {1}", amount, balance);
    }
    public void withdrawn(decimal amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("{0} Withdrawn.\nNew Balance : {1}", amount, balance);
        }
        else
        {
            Console.WriteLine("Insufficent Balance");
        }
    }
    public void getAccDetails(){
        Console.WriteLine("Account Holder : "+accountHolder);
        Console.WriteLine("Balance : "+balance);
    }
}
class program{
    static void Main(string[] args){
        bank myAcc = new bank("Astle",10000);
        myAcc.getAccDetails();
        myAcc.deposit(1005);
        myAcc.withdrawn(505);
    }
}