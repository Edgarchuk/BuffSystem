using BuffSystem.Buff.Visitor;

namespace BuffSystem.Buff
{
    class AddSubHeal : Buff, IBuffAdd
    {
        public override void Accept(BuffVisitor visitor)
        {
            visitor.VisitBuffAdd(this);
        }

        public Buff GetBuff()
        {
            return new SubHeal();
        }
    }
}