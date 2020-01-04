
class DecreaseBombCooldown : Modifier
{
    protected override void Modify()
    {
        playerAttributes.BombCooldown--;
    }
}