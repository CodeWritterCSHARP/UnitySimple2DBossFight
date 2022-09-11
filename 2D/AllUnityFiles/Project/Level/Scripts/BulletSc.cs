using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSc : MonoBehaviour {
    public float speed;
    public float destr;
    public float dista;

    public Rigidbody2D rb;

    public GameObject ex;

    public LayerMask l;

	void Start ()
    {
        Invoke("DestrP", destr);
        rb.velocity = transform.right * speed;
	}

    void Update()
    {
        RaycastHit2D h = Physics2D.Raycast(transform.position, transform.right, dista, l);

        if (h.collider != null)
            DestrP();

        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    void DestrP()
    {
        Instantiate(ex, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
