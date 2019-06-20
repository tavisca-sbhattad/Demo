using System;
using System.Collections.Generic;
using System.Text;
using ChainOfResponsibiltyPattern.Model;

namespace ChainOfResponsibiltyPattern.Handlers
{
    public class HundressRupeesNoteHandler : NoteHandlerBase
    {
        public override NoteEvaluationResult EvaluateNote(Note note)
        {
            if (note.Length == 100 && note.Weight == 100)
            {
                Console.WriteLine("Captured 100 Rupees note");
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
