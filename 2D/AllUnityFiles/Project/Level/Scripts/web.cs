using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class web : MonoBehaviour {
    public float speed;

    public Transform target;

    void Update ()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
