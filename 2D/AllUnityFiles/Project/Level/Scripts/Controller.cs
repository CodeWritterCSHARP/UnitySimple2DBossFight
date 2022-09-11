using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Controller : MonoBehaviour {
    [SerializeField]
    int loadingLevel;
    public int h = 3;

    public float speed;
    public float jump;
    public float moveInput;

    private Rigidbody2D rb;

    public bool rotate = true;
    private bool isG;

    public Transform GroundCheck;

    public float radius;

    public LayerMask isGr;

    public TextMesh txt;

    public AudioClip au;
    public AudioSource au1;

    public GameObject ground;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        au1.clip = au;
    }
    void FixedUpdate () {
        isG = Physics2D.OverlapCircle(GroundCheck.position, radius, isGr);
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (rotate == false && moveInput > 0)
        {
            Turn();
        }
        else
        {
            if (rotate == true && moveInput < 0)
            {
                Turn();
            }
        }
	}
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)&&isG ==true)
        {
            rb.velocity = Vector2.up * jump;
            au1.Play();
            ground.SetActive(true);
        }

        if (isG == true) ground.SetActive(true);
        else ground.SetActive(false);

        if (h <= 0) Application.LoadLevel(loadingLevel);

        txt.text = h.ToString();
    }
    void Turn()
    {
        rotate = !rotate;
        transform.Rotate(0f, 180f, 0f);
    }
}
