using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerMonster : MonoBehaviour {
    public GameObject m1;
    public GameObject m2;

    public float i;

    IEnumerator t()
    {
        while (true)
        {
            i -= 1;
            yield return new WaitForSeconds(1);
        }
    }

	void Start ()
    {
        StartCoroutine(t());
	}

	void Update ()
    {
        if (i <= 0)
        {
            Destroy(m1);
            m2.SetActive(true);
        }
	}
}
