using BoressoStudio.Core;
using UnityEngine;

public class CharacterStateIdle : State
{
    private CharacterBrain _brain;
    public CharacterStateIdle(CharacterBrain brain) => _brain = brain;

    public override void ExecuteEnter()
    {
        Debug.Log("Character " + _brain.Data.DisplayName + " is now Idling.");
    }
    public override void ProcessUpdate() { }
    public override void ProcessFixedUpdate() { }
    public override void ProcessLateUpdate() { }
    public override void ExecuteExit() { }
}
