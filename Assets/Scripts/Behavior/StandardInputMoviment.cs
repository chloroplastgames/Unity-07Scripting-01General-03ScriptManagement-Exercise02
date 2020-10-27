using UnityEngine; 
public class StandardInputMoviment : IInputMoviment
{
    private GameData _gameData; 
    public Vector3 Direction { get => new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),0) * _gameData.SpeedPlayer;}

    public StandardInputMoviment(GameData gameData)
    {
        _gameData = gameData;
    } 
}