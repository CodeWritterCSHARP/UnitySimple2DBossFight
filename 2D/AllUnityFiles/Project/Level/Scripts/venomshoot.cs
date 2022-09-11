using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class venomshoot : MonoBehaviour {
    public GameObject s;

    private void Update()
    {
        Instantiate(s, transform.position, Quaternion.identity);
    }
}
