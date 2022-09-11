using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MonsterAttack : MonoBehaviour {
    public int h = 100;

    public float i;
    public float f;
    private float r;

    public Animator anim;

    public GameObject lastmonster;
    public GameObject s;

    public Slider sl;

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
        s.SetActive(true);
        StartCoroutine(t());
    }

	void Update ()
    {
        r = -1;

        if (i <= 0)
        {
            r = Random.Range(1, 4);
            Debug.Log(r);
            switch (r)
            {
                case 1: anim.Play("SecondAttack"); break;
                case 2: anim.Play("BB"); break;
                case 3: anim.Play("FirstAttack"); break;
                default: break;
            }
            i += f;
        }

        if (h <= 0)
        {
            lastmonster.SetActive(true);

            Destroy(gameObject);
            Destroy(s);
        }
        sl.value = h;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            h -= 1;
        }
    }
}
