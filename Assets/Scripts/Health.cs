using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int maximumHealth = 5;
    [SerializeField] private int initialHealth = 3;

    [SerializeField] private int currentHealth = 0;

    private void Awake()
    {
        currentHealth = initialHealth;
    }

    // Adds modifier to health of the object
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