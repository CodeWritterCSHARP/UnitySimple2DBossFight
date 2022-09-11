using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acyive3 : MonoBehaviour
{
    public GameObject f1;
    public Transform em;
    void Update()
    {
        Instantiate(f1, em.transform.position, f1.transform.rotation);
    }
}
