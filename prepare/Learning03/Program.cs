using System;

class Program{

static void Main(string[] args)
{
    var savings = new Account();
    savings.Deposit(500);
    savings.Deposit(1000);
}
    public class Account{
        // private means that it can only be used inside of this class. If it is tried to be used outside 
        // of the class then an error stating that it is not accessible because of it's level
        private List<int> _transactions = new List<int>();

        public void Deposit(int amount){
            _transactions.Add(amount);
        }

        public int Balance(){
            var balance = 0;
            foreach (var transaction in _transactions){
                balance += transaction;
            }

            return balance;
        }
    }
}