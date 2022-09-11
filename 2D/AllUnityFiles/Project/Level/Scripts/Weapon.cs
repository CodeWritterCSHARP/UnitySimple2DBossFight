using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {
    public float of;

    private float m_timer;
    public float stimer;

    public Transform shoot;

    public GameObject bullet;

    public Animator cam;

    void Update ()
    {
        Vector3 d = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rz = Mathf.Atan2(d.y, d.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rz +of);

        if (m_timer <= 0)
        {
            if (Input.GetMouseButton(0))
            {
                cam.Play("Shake");
                Instantiate(bullet, shoot.transform.position, transform.rotation);
                m_timer = stimer;
            }
        }
        else
        {
            m_timer -= Time.deltaTime;
        }
	}
}
