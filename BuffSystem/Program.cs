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
                new AddHeal(),
                new AddHeal(),
                new SubHeal()
            };

            HealCalculateVisitorImpl buffVisitor = new HealCalculateVisitorImpl(new State());
            buffs.Accept(buffVisitor);
            Console.WriteLine(buffVisitor.State.Heal);
        }
    }
}