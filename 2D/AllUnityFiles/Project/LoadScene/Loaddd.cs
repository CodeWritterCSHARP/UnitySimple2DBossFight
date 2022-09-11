using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loaddd : MonoBehaviour {
    public int i;
    private void Update()
    {
        Application.LoadLevel(i);
    }
}
