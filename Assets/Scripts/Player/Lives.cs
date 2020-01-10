using System;
using UnityEngine;

public class Lives : MonoBehaviour
{
    public int numberOfLives = 3;

    public Vector3 SpawnPosition { get; set; } = Vector3.zero;

    public int NumberOfLives
    {
        get => numberOfLives;
        set
        {
            if (value <= 0)
            {
                Kill();
            }
            numberOfLives = value;
        }
    }

    private void Kill()
    {
        Debug.Log(this.name + " dead");
        Destroy(this.gameObject);
    }
}