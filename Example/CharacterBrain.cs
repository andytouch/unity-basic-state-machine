using BoressoStudio.Core;
using System.Collections.Generic;

public class CharacterBrain
{
    public enum CharacterStateID
    {
        Construct,
        Idle,
        Walking
    }
    
    private StateMachine _stateMachine;

    private Dictionary<CharacterStateID, State> _states = new Dictionary<CharacterStateID, State>();

    private CharacterData _data;
    public CharacterData Data => _data;
    
    public CharacterBrain(CharacterData newData)
    {
        _data = newData;
        
        _stateMachine = new StateMachine();
        InitStates();
        
        //Starting State
        ChangeCharacterState(CharacterStateID.Construct);
    }

    private void InitStates()
    {
        _states[CharacterStateID.Construct] = new CharacterStateConstruct(this);
        _states[CharacterStateID.Idle] = new CharacterStateIdle(this);
        _states[CharacterStateID.Walking] = new CharacterStateWalking(this);
    }

    //Using Enum Lookup for simplicity, you could also reference the initialized state instead.
    public void ChangeCharacterState(CharacterStateID newState)
    {
        if (_states.ContainsKey(newState))
        {
            _stateMachine.ChangeState(_states[newState]);
        }
    }

    /*
     These updates are called from the core game loop manager
     But you could also make this script a MonoBehaviour and use Update(), FixedUpdate(), LateUpdate() directly to then iterate on the CurrentState
    */
    public void ProcessUpdate() => _stateMachine.CurrentState.ProcessUpdate();
    public void ProcessFixedUpdate() => _stateMachine.CurrentState.ProcessFixedUpdate();
    public void ProcessLateUpdate() => _stateMachine.CurrentState.ProcessLateUpdate();
}
