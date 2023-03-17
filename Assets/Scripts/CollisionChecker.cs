using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CollisionChecker : MonoBehaviour
{
    private List<Collider> pillarCollision = new();
    public AreaChecker areaChecker;

    void Update()
    {
        if (areaChecker.IsAreaFilled())
        {
            if (pillarCollision.Distinct().Count() == 4)
            {
                Debug.Log("Game is Over");
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("block"))
        {
            pillarCollision.Add(other);
            Debug.Log(pillarCollision.Count);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("block"))
        {
            pillarCollision.Remove(other);
            Debug.Log(pillarCollision.Count);
        }
    }
}
