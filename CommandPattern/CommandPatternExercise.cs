using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    // Implement the Account.Process() method to process different account commands.The rules are obvious:

    // - Success indicates whether the operation was successful
    // - You can only withdraw money if you have enough in your account

    public class Command
    {
        public enum Action
        {
            Deposit,
            Withdraw
        }

        public Action TheAction;
        public int Amount;
        public bool Success;
    }

    public class Account
    {
        public int Balance { get; set; }

        public void Process(Command c)
        {
            switch(c.TheAction)
            {
                case Command.Action.Deposit:
                    this.Balance += c.Amount;
                    c.Success = true;
                    break;
                case Command.Action.Withdraw:
                    if(this.Balance <= c.Amount)
                    {
                        c.Success = false;
                    }
                    else
                    {
                        c.Success = true;
                        this.Balance -= c.Amount;
                    }
                    break;
                default:
                    return;
            }
        }
    }

    class CommandPatternExercise
    {
    }
}
