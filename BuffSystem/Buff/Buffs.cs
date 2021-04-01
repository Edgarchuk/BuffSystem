using System.Collections.ObjectModel;
using BuffSystem.Buff.Visitor;

namespace BuffSystem.Buff
{
    public class Buffs : Collection<Buff>
    {
        public void Accept(BuffVisitor buffVisitor)
        {
            foreach (var buff in this)
            {
                buff.Accept(buffVisitor);
            }
        }
    }
}