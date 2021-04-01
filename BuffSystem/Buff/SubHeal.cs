using BuffSystem.Buff.Visitor;

namespace BuffSystem.Buff
{
    public class SubHeal : Buff, IStateModify
    {

        public override void Accept(BuffVisitor visitor)
        {
            visitor.VisitStateModify(this);
        }

        public State Modify(State state)
        {
            state.Heal -= 20;
            return state;
        }
    }
}