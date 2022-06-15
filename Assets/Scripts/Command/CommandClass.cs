namespace Command
{
    public abstract class CommandClass
    {
        public abstract bool isFinished { get; }
        
        public abstract void Execute();
    }
}