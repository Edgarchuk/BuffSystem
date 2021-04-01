using System.Collections.Generic;

namespace BuffSystem.Buff.Visitor
{
    class AddBuffVisitorImpl : BuffVisitor
    {
        private Buffs _addBuff = new Buffs();

        public Buffs AddBuffs => _addBuff;

        public override void VisitStateModify(IStateModify buff)
        {
            
        }

        public override void VisitBuffAdd(IBuffAdd buff)
        {
            _addBuff.Add(buff.GetBuff());
        }
        
    }
}