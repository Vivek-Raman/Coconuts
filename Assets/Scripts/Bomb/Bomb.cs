using System.Collections.Generic;
using UnityEngine; 

public class Bomb : MonoBehaviour
{
    [HideInInspector] public int layerMask = 7681;

    private List<Vector3> directions;
    private float timeToExplode = 3f;
    private Transform player = null;
    private float distance = 10f;

    public void SetPlayerAndAttributes(Transform bombOwner, float bombRange = 10f)
    {
        this.player = bombOwner;
        distance = bombRange;
    }
    
    private void Awake()
    {
        // defaultLayerMask = LayerMask.GetMask("Default", "Wall", "Explodable", "Bomb", "Player");
        directions = new List<Vector3>
        {
            Vector3.forward, Vector3.left, Vector3.back, Vector3.right
        };
        
    }
    
    private void Start()
    {
        // on init, start Explode() after timeToExplode seconds
        Invoke(nameof(Explode), timeToExplode);
    }

    public void Explode()
    {
        foreach (Vector3 direction in directions)
        {
            Ray ray = new Ray(this.transform.position, direction);

            if (Physics.Raycast(ray, out RaycastHit hit, distance, layerMask))
            {
                if (hit.transform.TryGetComponent(out IExplosionHandler explodedObject))
                {
                    explodedObject.OnExplode(player);
                }
                //RaycastHitHandler(hit);
            }
        }
        
        Destroy(this.gameObject);
    }
    
    private void OnDestroy()
    {
        // spawn explosion FX
    }
}