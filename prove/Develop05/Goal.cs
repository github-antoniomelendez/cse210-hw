using System;

namespace goals
{
    public abstract class Goal
    {
        protected string _shortName;
        protected string _description;
        protected int _points = 0;

        public int GetPoints()
        {
            return _points;
        }

        public void SetPoints(int points)
        {
            _points = points;
        }

        public abstract int RecordEvent();


        public abstract bool IsComplete();

        public abstract string GetDetailsString();
        
        

        public abstract string GetStringRepresentation();




    }
}