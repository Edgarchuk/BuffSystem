using System;
using System.Collections.Generic;
using BuffSystem.Buff;
using BuffSystem.Buff.Visitor;

namespace BuffSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffs buffs = new Buffs()
            {
                new AddSubHeal(),
                new AddSubHeal()
            };
            
            AddBuffVisitorImpl addBuffVisitor = new AddBuffVisitorImpl();
            buffs.Accept(addBuffVisitor);
            
            HealCalculateVisitorImpl healCalculateVisitor = new HealCalculateVisitorImpl(new State());
            addBuffVisitor.AddBuffs.Accept(healCalculateVisitor);
            
            Console.WriteLine(healCalculateVisitor.State.Heal);
        }
    }
}