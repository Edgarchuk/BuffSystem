namespace BuffSystem.Buff.Visitor
{
    public abstract class BuffVisitor
    {

        public abstract void VisitStateModify(IStateModify visitorElement);
    }

    class HealCalculateVisitorImpl : BuffVisitor
    {
        private State _state;

        public State State
        {
            get
            {
                return _state;
            }
        }

        public HealCalculateVisitorImpl(State state)
        {
            _state = state;
        }

        public override void VisitStateModify(IStateModify visitorElement)
        {
            visitorElement.Modify(_state);
        }
    }
}