using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    public float speed = 45.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(0, 0, speed);
    }
}