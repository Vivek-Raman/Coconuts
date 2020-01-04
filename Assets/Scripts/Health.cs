using UnityEngine;

public class Health : MonoBehaviour
{
    private const int maximumHealth = 5;
    private const int initialHealth = 3;

    private int currentHealth = 0;

    private void Awake()
    {
        currentHealth = initialHealth;
    }

    public int CurrentHealth
    {
        get => currentHealth;
        set
        {
            if (value <= 0)
            {
                //dead
                Debug.Log(this.name + " dead");
                Destroy(this.gameObject);
            }
        
            if (value > maximumHealth)
            {
                value = maximumHealth;
            }

            currentHealth = value;
        }
    }
}