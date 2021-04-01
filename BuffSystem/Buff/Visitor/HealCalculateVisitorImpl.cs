namespace BuffSystem.Buff.Visitor
{
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

        public override void VisitStateModify(IStateModify buff)
        {
            buff.Modify(_state);
        }

        public override void VisitBuffAdd(IBuffAdd buff)
        {
            
        }
    }
}