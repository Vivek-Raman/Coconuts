
class IncreasePlayerHealth : Modifier
{
    protected override void Modify()
    {
        playerAttributes.health.ModifyHealth(+1);
    }
}