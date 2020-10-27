using UnityEngine; 

[CreateAssetMenu(fileName = "gameData", menuName = "Prototipo/Data")]
public class GameData : ScriptableObject
{
    #region PROPERTIES 
    public float SpeedPlayer { get => _speedPlayer;} 

    public float ProjectileForce { get => _projectilForce; }

    public float LifeTime { get => _lifeTime; }

    #endregion

    #region PRIVATES

    [SerializeField] private float _speedPlayer;

    [SerializeField] private float _projectilForce;

    [SerializeField] private float _lifeTime;

    #endregion
}