using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float cameraFollow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = Vector3.Lerp(this.transform.position, target.transform.position, cameraFollow);
        newPosition.z = -10;
        this.transform.position = newPosition;
    }
}
