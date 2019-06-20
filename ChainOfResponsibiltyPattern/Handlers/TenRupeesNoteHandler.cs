using ChainOfResponsibiltyPattern.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibiltyPattern.Handlers
{
    public class TenRupeesNoteHandler : NoteHandlerBase
    {
        public override NoteEvaluationResult EvaluateNote(Note note)
        {
            if (note.Length == 10 && note.Weight == 10)
            {
                Console.WriteLine("Captured 10 Rupees note");
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
