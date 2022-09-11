using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadTrigZone : MonoBehaviour {
    public int i;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "GameController")
        {
            Application.LoadLevel(i);
        }
    }
}
