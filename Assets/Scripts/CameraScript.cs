using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform Pepe;

    void Update()
    {
        if (Pepe != null)
        {
            Vector3 position = transform.position;
            position.x = Pepe.position.x;
            transform.position = position;
        }
    }
}
