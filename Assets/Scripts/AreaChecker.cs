using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaChecker : MonoBehaviour
{
    public Collider[] colliders;
    public LayerMask layerMask;

    private void Awake()
    {
        colliders = Physics.OverlapBox(transform.position, transform.localScale / 2, transform.rotation, layerMask);
    }

    // Draw the area in the editor for debugging purposes
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(transform.position, transform.localScale);
    }

    // Check if the area is filled with game objects
    public bool IsAreaFilled()
    {
        return colliders.Length == 4;
    }
}
