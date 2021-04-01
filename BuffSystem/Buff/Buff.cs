namespace BuffSystem.Buff
{
    public abstract class Buff
    {
        public abstract State Moodify(State state);
    }

    class BuffImpl : Buff
    {
        public override State Moodify(State state)
        {
            state.Heal += 20;
            return state;
        }
    }
}