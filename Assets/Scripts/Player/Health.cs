using UnityEngine;

public class Health : MonoBehaviour
{
    private const int MaximumHealth = 5;
    private const int InitialHealth = 3;

    private int currentHealth = 0;
    private Lives lives = null;
    
    private void Awake()
    {
        lives = this.GetComponent<Lives>();
        currentHealth = InitialHealth;
    }

    public int CurrentHealth
    {
        get => currentHealth;
        set
        {
            if (value <= 0)
            {
                lives.NumberOfLives--;
            }
        
            if (value > MaximumHealth)
            {
                value = MaximumHealth;
            }

            currentHealth = value;
        }
    }
}