using UnityEngine;

public class DropModifierOnDestroy : MonoBehaviour
{
    private void OnDestroy()
    {
        if (IsDrop())
        {
            SelectModifier();
            DropModifier();
        }
    }

    private bool IsDrop()
    {
        return true;
    }

    private void SelectModifier()
    {
        
    }
    
    private void DropModifier()
    {
    }
}