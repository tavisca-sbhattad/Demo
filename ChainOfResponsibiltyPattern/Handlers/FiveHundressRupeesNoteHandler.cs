using ChainOfResponsibiltyPattern.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibiltyPattern.Handlers
{
    public class FiveHundressRupeesNoteHandler : NoteHandlerBase
    {
        public override NoteEvaluationResult EvaluateNote(Note note)
        {
            if (note.Length == 500 && note.Weight == 500)
            {
                Console.WriteLine("Captured 500 Rupees note");
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
