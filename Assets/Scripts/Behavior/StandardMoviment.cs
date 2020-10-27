using UnityEngine; 
internal class StandardMoviment : MovimentBase
{
    public StandardMoviment(Transform player) : base(player) { }

    public override void Move(IInputMoviment input)
    {
        _player.Translate(input.Direction * Time.deltaTime);
    }
}