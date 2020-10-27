using UnityEngine; 
public class PlayerController : MonoBehaviour
{
    #region PROPERTIES
    public Rigidbody Projectil { get => _projectil; } 

    public GameData GameData { get => _gameData; }

    #endregion

    #region PRIVATES

    [SerializeField] private Rigidbody _projectil;

    [SerializeField] private GameData _gameData; 

    private MovimentBase _movimento;

    #endregion

    #region INTERFACES 

    private IInputMoviment _input;


    private IAction _btnFire;

    #endregion


    private void Awake()
    {
        _movimento = new StandardMoviment(transform);

        _input = new StandardInputMoviment(_gameData);

        _btnFire = new ActionFire(this);

    } 

    private void Update()
    {
        
        if (_gameData == null) return;

        _movimento.Move(_input);

        if (Input.GetButtonDown("Fire1"))
        { 
            _btnFire.Execute();
        }
    }

}
