using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class venom : MonoBehaviour {
    public float speed;

    public Transform pl;

    private Vector2 target;

	void Start ()
    {
        pl = GameObject.FindGameObjectWithTag("GameController").transform;
        target = new Vector2(pl.transform.position.x, pl.position.y);
    }

	void Update ()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if(transform.position.x==target.x && transform.position.y == target.y)
        {
            Destroy(gameObject);
        }
	}
}
