namespace BoressoStudio.Core
{
    public abstract class State
    {
        public abstract void ExecuteEnter();
        public abstract void ProcessUpdate();
        public abstract void ProcessFixedUpdate();
        public abstract void ProcessLateUpdate();
        public abstract void ExecuteExit();
    }
}