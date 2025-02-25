using BoressoStudio.Core;

public class CharacterStateWalking : State
{
    private CharacterBrain _brain;
    public CharacterStateWalking(CharacterBrain brain) => _brain = brain;
    public override void ExecuteEnter() { }

    public override void ProcessUpdate() { }
    public override void ProcessFixedUpdate() { }
    public override void ProcessLateUpdate() { }
    public override void ExecuteExit() { }
}
