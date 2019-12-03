using System;


namespace labathird
{
    abstract class Checks : ICheck
    {
        private ICheck nextCheck;

        public virtual void Check(Hero request, IMonster monster)
        {
            if (nextCheck != null)
            {
                nextCheck.Check(request, monster);
            }
        }

        public ICheck SetNext(ICheck handler)
        {
            this.nextCheck = handler;

            return handler;
        }
    }
}
