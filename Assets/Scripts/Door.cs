using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Transform openPosition, closedPosition;
    bool isOpen;
    public void Toggle()
    {
        isOpen = !isOpen;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (isOpen)
        {
            Vector2 newPosition = Vector2.Lerp(this.transform.position, openPosition.position, .01f);
            this.transform.position = newPosition;
        }
        else
        {
            Vector2 newPosition = Vector2.Lerp(this.transform.position, closedPosition.position, .01f);
            this.transform.position = newPosition;
        }
    }
}
