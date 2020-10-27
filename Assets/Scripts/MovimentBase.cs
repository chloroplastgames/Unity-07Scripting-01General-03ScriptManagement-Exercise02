using UnityEngine; 
public abstract class MovimentBase
{
    protected Transform _player;
    public MovimentBase(Transform player)
    {
        _player = player;
    }

    public abstract void Move(IInputMoviment input);
}