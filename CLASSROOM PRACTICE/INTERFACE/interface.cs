// Q. Design an interface IBank with methods Deposit() and withdrawal(). Accept that implements the interface and performs baisc banking operation based on user input.
using System;

interface IBank
{
    double Deposit();
    double Withdrawal();
}

class User(double depMoney, double withMoney) : IBank
{
    public double balance = 100000;
    private double depMoney = depMoney;
    private double withMoney = withMoney;

    public double Deposit()
    {
        return balance + this.depMoney;
    }

    public double Withdrawal()
    {
        return balance - this.withMoney;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter The Money To Deposite: ");
        double depo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter The Money To Withdrawal: ");
        double withdrawal = Convert.ToDouble(Console.ReadLine());

        User obj = new(depo, withdrawal);
        Console.WriteLine("Deposit Money: " + obj.Deposit());
        Console.WriteLine("Withdrawal Money: " + obj.Withdrawal());
    }
}