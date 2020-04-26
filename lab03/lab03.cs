using System;

public class lab03
{	
public static void Main(string[] args)
{

double curBal = 45.32;
string amount;
double actAmount = 0.0;
Console.WriteLine("Please enter a amount to update account by $");
amount = Console.ReadLine();
Console.Write("\n");
Console.Write("Customer's Balance (before transaction)=$ ");
Console.WriteLine(curBal +"\n");
Console.Write("Requested update amount = $");
Console.WriteLine(double.Parse(amount) + "\n");
curBal = curBal + actAmount;

Console.Write("Actual update amount = $");
Console.WriteLine(actAmount + "\n");
Console.Write("Customer's Balance (after transaction)=$ ");
Console.WriteLine(curBal + "\n");

Console.Write("\nThank you and good-bye!\n");
	

}

public static double transaction(double balance, double amount)
{
   double updateBalance= 0.0;
	updateBalance = balance - amount;
// if amount is negative and less than balance or amount is positive, do the transaction
  if ((updateBalance) < 0)
  {
  return amount;
  }
	else{
  return updateBalance ;
	}
}
}
