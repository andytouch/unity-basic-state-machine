namespace BoressoStudio.Core
{
    public class StateMachine
    {
        private State _currentState = null;

        public State CurrentState => _currentState;

        public void ChangeState(State newState)
        {
            if (_currentState != null)
                _currentState.ExecuteExit();
            
            _currentState = newState;
            _currentState.ExecuteEnter();
        }

        private void ProcessUpdate()
        {
            if(_currentState != null)
                _currentState.ProcessUpdate();
        }
        
        private void ProcessFixedUpdate()
        {
            if(_currentState != null)
                _currentState.ProcessFixedUpdate();
        }
        
        private void ProcessLateUpdate()
        {
            if(_currentState != null)
                _currentState.ProcessLateUpdate();
        }
    }
}