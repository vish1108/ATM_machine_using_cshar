// using System;
// using System.Linq;
// using System.Collections.Generic;

// public class cardHolder
// {
//     string cardNum;
//     int pin;
//     string firstName;
//     string lastName;
//     double balance; 

//     public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
//     {
//         this.cardNum = cardNum;
//         this.pin = pin;
//         this.firstName = firstName;
//         this.lastName = lastName;   
//         this.balance = balance;

//     }

//     public string getNum()
//     {
//         return cardNum;
//     }

//     public int getpin()
//     {
//         return pin;
//     }

//     public string getfirstName()
//     {
//         return firstName;
//     }

//     public string getlastName()
//     {
//         return lastName;
//     }

//     public double getbalance()
//     {
//         return balance;
//     }

//     public void setnum(string newcardNum)
//     {
//         cardNum = newcardNum;
//     }

//     public void setpin(int newpin)
//     {
//         pin = newpin;
//     }

//     public void setfirstName(string newfirstName)
//     {
//         firstName = newfirstName;
//     }
//     public void setlastName(string newlastName)
//     {
//         lastName = newlastName;
//     }

//     public void setbalance(double newbalance)
//     {
//         balance = newbalance;
//     }

//     public static void Main(string[] args)
//     {
//         void printOptions()
//         {
//             System.Console.WriteLine("Please choose from one of the options....");
//             System.Console.WriteLine("1. Deposit");
//             System.Console.WriteLine("2. Withdraw");
//             System.Console.WriteLine("3. Show Balance");
//             System.Console.WriteLine("4. Exit");
//         }

//         void deposit(cardHolder currentuser)
//         {
//             System.Console.WriteLine("How much INR would like to deposit? ");
//             double deposit = Double.Parse(System.Console.ReadLine());
//             currentuser.setbalance(currentuser.getbalance() + deposit);
//             System.Console.WriteLine("Thank you for your $$. Your new balance is: " + currentuser.getbalance());
//         }

//         void Withdraw(cardHolder currentuser)
//         {
//             System.Console.WriteLine("how much $$ would you like to Withdraw: ");
//             double Withdraw = Double.Parse(System.Console.ReadLine());
//             //Check if the user has enough money
//             if(currentuser.getbalance() < Withdraw)
//             {
//                 System.Console.WriteLine("Insufficient balance :(");
//             }
//             else
//             {
//                 currentuser.setbalance(currentuser.getbalance() - Withdraw);
//                 System.Console.WriteLine("You're good to go! Thank you :)");
//             }

//         }

//         void balance(cardHolder currentuser)
//         {
//             Console.WriteLine("Current balance: " + currentuser.getbalance());
//         }

//         List<cardHolder> cardHolders = new List<cardHolder>();
//         cardHolders.Add(new cardHolder("8080178719", 1234, "Vishal", "Waghmare", 150.67));
//         cardHolders.Add(new cardHolder("8080178720", 7861, "Nitin", "Iyenger", 800.67));
//         cardHolders.Add(new cardHolder("8080178721", 8080, "Akash", "pal", 176.67));
//         cardHolders.Add(new cardHolder("8080178722", 1111, "Nilesh", "Garkal", 180.67));
//         cardHolders.Add(new cardHolder("8080178723", 5050, "Ravi", "Zanke", 148.67));

//         //Prompt user
//         System.Console.WriteLine("Welcome to the SimpleATM");
//         System.Console.WriteLine("Please insert your dabit card Number: ");
//         string debitcardNum = "";
//         cardHolder currentuser;

//         while(true)
//         {
//             try
//             {
//                 debitcardNum = Console.ReadLine();
//                 //Check against our DB
//                 currentuser = cardHolders.FirstOrDefault(a => a.cardNum == debitcardNum);
//                 if (currentuser != null) { break; }
//                 else { System.Console.WriteLine("card Not recongnized. Please try again"); }

//             }
//             catch { System.Console.WriteLine("card Not recongnized. Please try again"); }
//         }

//         Console.WriteLine("Please Enter a pin: ");
//         int userpin = 0;
//          while(true)
//         {
//             try
//             {
//                 userpin = int.Parse(Console.ReadLine());
//                 //Check against our DB
//                 if (currentuser.getpin() == userpin) { break; }
//                 else { System.Console.WriteLine("Incorrect Pin. Please try again"); }

//             }
//             catch { System.Console.WriteLine("Incorrect Pin. Please try again"); }
//         }

//         Console.WriteLine("Welcome" + currentuser.getfirstName() + ":");
//         int option = 0;
//         do
//         {
//             printOptions();

//             try
//             {
//                 option = int.Parse(Console.ReadLine());
//             }
//             catch
//             {
//                 option = 0;
//             }
//             if (option ==  1)
//             {
//                 deposit(currentuser); 
//             }
//             else if (option == 2)
//             {
//                 Withdraw(currentuser);
//             }
//             else if (option == 3)
//             {
//                 balance(currentuser); 

//             }
//         }while (option != 4);

//     System.Console.WriteLine("(Thank you! have a nice day  :)");

// }


    