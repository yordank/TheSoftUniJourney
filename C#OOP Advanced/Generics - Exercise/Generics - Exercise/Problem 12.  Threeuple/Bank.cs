using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Bank
{
    public Bank(string bankName)
    {
        this.BankName = bankName;
    }

    private string bankName;

    public string BankName
    {
        get { return bankName; }
        set { bankName = value; }
    }

    public override string ToString()
    {
        return this.BankName;
    }

}

