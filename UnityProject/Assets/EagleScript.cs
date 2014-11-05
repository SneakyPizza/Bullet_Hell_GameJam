using UnityEngine;
using System.Collections;

public class EagleScript : MonoBehaviour
{
    public float minimumRange = 10;
    public float maximumRange = 200;
    Transform child;
    // Use this for initialization
    void Start()
    {
        child = transform.GetChild(0);
        transform.position = new Vector3(Screen.width / 4 + child.renderer.bounds.size.x, Random.Range(-50.0f, 50.0f), transform.position.z);

        float randX = Random.Range(minimumRange, maximumRange);
        float randY = Random.Range(minimumRange, maximumRange);
        child.rigidbody2D.AddForce(new Vector2(-randX, -randY));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
