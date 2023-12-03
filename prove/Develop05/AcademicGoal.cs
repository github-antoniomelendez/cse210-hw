using System;

namespace goals
{
    public abstract class AcademicGoal : Goal
    {
        protected bool _isComplete = true;

        public override int RecordEvent()
        {
            throw new NotImplementedException();
        }

        public override bool IsComplete()
        {
            throw new NotImplementedException();
        }

        public override string GetStringRepresentation()
        {
            throw new NotImplementedException();
        }
    }

}