using ChainOfResponsibiltyPattern.Handlers;
using ChainOfResponsibiltyPattern.Model;
using System;

namespace ChainOfResponsibiltyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new HundressRupeesNoteHandler();
            var c2 = new TenRupeesNoteHandler();
            var c5 = new FiveHundressRupeesNoteHandler();
            var c10 = new ThousandRupeesNoteHandler();

            c1.SetSuccessor(c2);
            c2.SetSuccessor(c5);
            c5.SetSuccessor(c10);

            var HundreesRupees = new Note { Length = 100F, Weight = 100F };
            var fiveHundressRupees = new Note { Length = 500F, Weight = 500F };
            var thousandRupees = new Note { Length = 1000F, Weight = 1000F };
            var counterFietNote = new Note { Length = 1005F, Weight = 1005F };

            Console.WriteLine(c1.EvaluateNote(HundreesRupees));
            Console.WriteLine(c1.EvaluateNote(fiveHundressRupees));
            Console.WriteLine(c1.EvaluateNote(thousandRupees));
            Console.WriteLine(c1.EvaluateNote(counterFietNote));
            Console.ReadLine();
        }
    }
}
