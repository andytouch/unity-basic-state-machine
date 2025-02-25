using System;

public class CharacterData
{
    private string _displayName;
    public string DisplayName
    {
        get => _displayName;
        set => _displayName = value;
    }

    private int _level;
    public int Level
    {
        get => _level;
        set => _level = value;
    }

    private float _movementSpeed;
    public float MovementSpeed
    {
        get => _movementSpeed;
        set => _movementSpeed = value;
    }
}
