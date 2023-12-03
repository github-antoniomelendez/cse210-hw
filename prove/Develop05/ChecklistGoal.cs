using System;

namespace goals
{
    public abstract class ChecklistGoal : Goal
    {

        protected int _amountCompleted = 0;
        protected int _target = 0;
        protected int _bonus = 0;

        public int GetAmountCompleted()
        {
            return _amountCompleted;
        }

        public void SetAmountCompleted(int amountCompleted)
        {
            _amountCompleted = amountCompleted;
        }

        public int GetTarget()
        {
            return _target;
        }

        public void SetTarget(int target)
        {
            _target = target;
        }

        public int GetBonus()
        {
            return _bonus;
        }

        public void SetBonus(int bonus)
        {
            _bonus = bonus;
        }
        public override int RecordEvent()
        {
            throw new NotImplementedException();
        }

        public override bool IsComplete()
        {
            throw new NotImplementedException();
        }

        public override string GetDetailsString()
        {
            throw new NotImplementedException();
        }

        public override string GetStringRepresentation()
        {
            throw new NotImplementedException();
        }
    }

}