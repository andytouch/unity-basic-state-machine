using UnityEngine;

public class GameLoop : MonoBehaviour
{
    public CharacterBrain _playerCharacter;

    void Awake()
    {
        CreatePlayer();
    }

    private void CreatePlayer()
    {
        _playerCharacter = new CharacterBrain(new CharacterData()
        {
            DisplayName = "Chappell Roan",
            Level = 28,
            MovementSpeed = 10
        });
    }
    
    // Obviously, only actually use the built-in methods if they are required. This is just an example!
    private void Update()
    {
        _playerCharacter.ProcessUpdate();
    }

    private void FixedUpdate()
    {
        _playerCharacter.ProcessFixedUpdate();
    }

    private void LateUpdate()
    {
        _playerCharacter.ProcessLateUpdate();
    }
}
