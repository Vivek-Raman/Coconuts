using System;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public LayerMask mask;
    private List<Vector3> directions;
    private float timeToExplode = 3f;
    private Transform player = null;
    private Collider bombCollider = null;
    
    public void SetPlayer(Transform owner)
    {
        this.player = owner;
    }
    
    private void Awake()
    {
        // Populate directions
        directions = new List<Vector3>
        {
            Vector3.forward, Vector3.left, Vector3.back, Vector3.right
        };
        bombCollider = this.GetComponent<Collider>();
    }
    
    private void Start()
    {
        // on init, start Explode() after timeToExplode seconds
        Invoke(nameof(Explode), timeToExplode);
    }

    private void Explode()
    {
        foreach (Vector3 direction in directions)
        {
            Ray ray = new Ray(this.transform.position, direction);
            
            if (bombCollider.Raycast(ray, out RaycastHit hit, 10f))
            {
                RaycastHitHandler(hit);
            }
        }
        
        Destroy(this.gameObject);
    }

    // TODO: SiNgLe rEsPoNsIBiLItY pRiNcIpLe
    private void RaycastHitHandler(RaycastHit hit)
    {
        Transform other = hit.transform;
        if (other.CompareTag("Player"))
        {
            Health health = other.GetComponent<Health>();
            health.Modify(-1);
        }
        else if (other.CompareTag("Explodable"))
        {
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Wall"))
        {
        }
        else if (other.CompareTag("Bomb"))
        {
        }
        else
        {
            Debug.LogError("Unhandled collision case");
        }
    }

    private void OnDestroy()
    {
        // spawn explosion FX
    }
}