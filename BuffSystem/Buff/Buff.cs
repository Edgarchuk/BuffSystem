using BuffSystem.Buff.Visitor;

namespace BuffSystem.Buff
{
    public abstract class Buff
    {
        public abstract void Accept(BuffVisitor visitor);
    }

    public interface IStateModify
    {
        public State Modify(State state);
    }
    
}