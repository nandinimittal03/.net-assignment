/*using System;
public class Student
{
    // Non-static data members
    public string Name { get; set; }
    public int RollNo { get; set; }
    public int[] Marks { get; set; } = new int[5];
    public int TotalMarks { get; private set; }
    public double Percentage { get; private set; }
  
    public static string UniversityName { get; private set; }
    
    static Student()
    {
        UniversityName = "XYZ University"; 
    }
    public Student()
    {
        Name = "Unknown";
        RollNo = 0;
        TotalMarks = 0;
        Percentage = 0.0;
    }
    
    public Student(string name, int rollNo, int[] marks)
    {
        Name = name;
        RollNo = rollNo;
        Marks = marks;
        CalculateResult(); 
    }
    
    public void ReadData()
    {
        Console.Write("Enter Name: ");
        Name = Console.ReadLine();
        Console.Write("Enter Roll Number: ");
        RollNo = int.Parse(Console.ReadLine());
        for (int i = 0; i < Marks.Length; i++)
        {
            Console.Write($"Enter marks for subject {i + 1}: ");
            Marks[i] = int.Parse(Console.ReadLine());
        }
        CalculateResult(); 
    }
    
    public void CalculateResult()
    {
        TotalMarks = 0;
        for (int i = 0; i < Marks.Length; i++)
        {
            TotalMarks += Marks[i];
        }
        Percentage = (double)TotalMarks / Marks.Length;
    }
    
    public void Display()
    {
        Console.WriteLine($"University Name: {UniversityName}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Roll Number: {RollNo}");
        Console.WriteLine("Marks: " + string.Join(", ", Marks));
        Console.WriteLine($"Total Marks: {TotalMarks}");
        Console.WriteLine($"Percentage: {Percentage}%");
    }
}*/
//Q2
using System;
public interface Account
{
    void OpenAccount();
    void CloseAccount();
}
public interface Customer
{
    void DisplayCustomerDetail();
}
public class SavingAccount : Account, Customer
{

    public string CustomerName { get; set; }
    public int AccountNumber { get; set; }
    public double Balance { get; private set; }

    public static string BankName { get; private set; }

    static SavingAccount()
    {
        BankName = "ABC Bank";
    }

    public SavingAccount()
    {
        CustomerName = "Unknown";
        AccountNumber = 0;
        Balance = 0.0;
    }

    public SavingAccount(string customerName, int accountNumber, double initialBalance)
    {
        CustomerName = customerName;
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }
    public void OpenAccount()
    {
        Console.WriteLine($"Account opened successfully for {CustomerName} at {BankName}.");
    }

    public void CloseAccount()
    {
        Console.WriteLine($"Account {AccountNumber} for {CustomerName} has been closed.");
    }

    public void DisplayCustomerDetail()
    {
        Console.WriteLine($"Customer Name: {CustomerName}");
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Bank Name: {BankName}");
    }

    public void Withdraw(double amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Insufficient balance.");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawal of {amount:C} successful. Remaining Balance: {Balance:C}");
        }
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposit of {amount:C} successful. New Balance: {Balance:C}");
    }

    public void CheckAndDisplayBalance()
    {
        Console.WriteLine($"Current Balance: {Balance:C}");
    }
}