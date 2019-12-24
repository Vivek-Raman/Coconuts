using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int maximumHealth = 5;
    [SerializeField] private int initialHealth = 3;

    private int currentHealth = 0;

    private void Awake()
    {
        currentHealth = initialHealth;
    }

    private void OnGUI()
    {
        GUILayout.TextField(this.name + ": " + currentHealth);
    }

    // Adds modifier to health of the object
    public void Modify(int modifier)
    {
        int newHealth = currentHealth + modifier;
        if (newHealth <= 0)
        {
            //dead
            Debug.Log(this.name + " dead");
            Destroy(this.gameObject);
        }
        
        if (newHealth > maximumHealth)
        {
            newHealth = maximumHealth;
        }

        currentHealth = newHealth;
    }
}