namespace BuffSystem.Buff.Visitor
{
    public abstract class BuffVisitor
    {

        public abstract void VisitStateModify(IStateModify buff);
        public abstract void VisitBuffAdd(IBuffAdd buff);
    }
}