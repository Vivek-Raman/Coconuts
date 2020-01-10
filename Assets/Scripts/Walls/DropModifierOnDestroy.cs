using UnityEngine;

public class DropModifierOnDestroy : MonoBehaviour
{
    private const float DropClipThreshold = 0.7f;
    
    [SerializeField] private ModifierTable modifiers = null;
    
    private Transform modifierParentTransform = null;

    private void Awake()
    {
        GameObject temp = GameObject.Find("Bombs");
        if (temp == null)
        {
            temp = new GameObject("Bombs");
            temp.transform.position = Vector3.zero;
        }
        modifierParentTransform = temp.transform;
    }

    private void OnDestroy()
    {
        if (modifiers == null)
        {
            return;
        }
        
        if (IsDrop())
        {
            DropModifier(modifiers.GetRandomModifier());
        }
    }

    private bool IsDrop()
    {
        return Random.Range(1, 100) < DropClipThreshold * 100;
    }
    private void DropModifier(GameObject modifier)
    {
        Instantiate(modifier, this.transform.position, Quaternion.identity, modifierParentTransform);
    }
}