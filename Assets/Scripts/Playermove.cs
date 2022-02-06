using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    public float speed = 10.0f;
    public float horizontalInput;
    public GameObject projectilePrefabs;
    private float xRange = 19;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(projectilePrefabs, transform.position, projectilePrefabs.transform.rotation);
        }
    }
}
