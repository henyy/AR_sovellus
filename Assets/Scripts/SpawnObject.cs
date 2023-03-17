using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARObjectSpawner : MonoBehaviour
{
    public GameObject prefab;
    public ARCameraManager arSessionOrigin;

    public void SpawnObject()
    {
        GameObject newObject = Instantiate(prefab);

        Vector3 worldPosition = arSessionOrigin.transform.TransformPoint(new Vector3(0, 0, 0.5f)); // Place the object 1 meter in front of the camera
        Quaternion worldRotation = arSessionOrigin.transform.rotation;

        newObject.transform.SetPositionAndRotation(worldPosition, worldRotation);
    }
}

