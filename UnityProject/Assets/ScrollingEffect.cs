using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScrollingEffect : MonoBehaviour
{
    float actualSpeed;
    public float chunkSpeed = 0.0f;
    public Transform outOfScreenPosition;
    Vector3 previousPosition;
    float scrollSpeed;
    void Start()
    {
        scrollSpeed = transform.parent.GetComponent<ParallaxEffect>().actualSpeed;
        previousPosition = transform.position;
        previousPosition.x += scrollSpeed * 3.0f;
    }

    void Update()
    {
        scrollSpeed = transform.parent.GetComponent<ParallaxEffect>().actualSpeed;
        previousPosition.x -= 1.0f + scrollSpeed;
        
        if (transform.position.x < -Screen.width / 4)
        {
            Debug.Log("sidyfoidsahfoiudsaf fuck unity");
            previousPosition = new Vector3(outOfScreenPosition.position.x - (scrollSpeed * 3.0f), transform.position.y, transform.position.z);
        }

        transform.position = previousPosition;
    }
}
