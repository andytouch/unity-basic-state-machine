using BoressoStudio.Core;
using UnityEngine;

public class CharacterStateConstruct : State
{
    private CharacterBrain _brain;
    public CharacterStateConstruct(CharacterBrain brain) => _brain = brain;

    public override void ExecuteEnter()
    {
        //An example of accessing the Character Brain to do something. This could be accessing Data or other references like configs or components (if it is an MB)
        Debug.Log("Character " + _brain.Data.DisplayName + " created!");
        
        //Example of then transitioning to another State using an Enum
        _brain.ChangeCharacterState(CharacterBrain.CharacterStateID.Idle);
    }
    public override void ProcessUpdate() { }
    public override void ProcessFixedUpdate() { }
    public override void ProcessLateUpdate() { }
    public override void ExecuteExit() { }
}
