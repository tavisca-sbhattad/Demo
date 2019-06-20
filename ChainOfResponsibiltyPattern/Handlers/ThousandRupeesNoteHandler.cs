using ChainOfResponsibiltyPattern.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibiltyPattern.Handlers
{
    public class ThousandRupeesNoteHandler : NoteHandlerBase
    {
        public override NoteEvaluationResult EvaluateNote(Note note)
        {
            if (note.Length == 1000 && note.Weight == 1000)
            {
                Console.WriteLine("Captured 1000 Rupees note");
                return NoteEvaluationResult.Accepted;
            }
            if (_successor != null)
            {
                return _successor.EvaluateNote(note);
            }
            return NoteEvaluationResult.Rejected;
        }

    }
}
