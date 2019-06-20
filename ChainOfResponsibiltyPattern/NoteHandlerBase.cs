using ChainOfResponsibiltyPattern.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibiltyPattern
{
    public abstract class NoteHandlerBase
    {
        protected NoteHandlerBase _successor;

        public void SetSuccessor(NoteHandlerBase successor)
        {
            _successor = successor;
        }

        public abstract NoteEvaluationResult EvaluateNote(Note note);
    }
}
