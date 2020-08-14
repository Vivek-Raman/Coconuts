using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public static UnityAction<Transform, Transform> onHealthModified;
    
    private const int MaximumHealth = 5;
    private const int InitialHealth = 3;

    private int currentHealth = 0;
    
    private void Awake()
    {
        currentHealth = InitialHealth;
    }

    public int CurrentHealth
    {
        get => currentHealth;
        private set
        {
            if (value <= 0)
            {
                Respawn();
            }
        
            if (value > MaximumHealth)
            {
                value = MaximumHealth;
            }
            currentHealth = value;
        }
    }

    public void ModifyHealth(int modifier, Transform sourceOfModification = null)
    {
        CurrentHealth += modifier;
        if (sourceOfModification != null)
            onHealthModified.Invoke(sourceOfModification, this.transform);
    }

    public void Respawn()
    {
        // TODO: move to any one spawn
        currentHealth = InitialHealth;
    }
}