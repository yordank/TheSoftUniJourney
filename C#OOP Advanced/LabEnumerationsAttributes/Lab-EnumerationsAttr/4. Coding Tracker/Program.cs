using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


[SoftUni("Ventsi")]
class StartUp
{
    [SoftUni("Gosho")]
    static void Main()
    {
        
        var tracker = new Tracker();
        tracker.PrintMethodsByAuthor();
    }
    [SoftUni("Yordan")]
    public override string ToString()
    {
        return base.ToString();
    }
}


