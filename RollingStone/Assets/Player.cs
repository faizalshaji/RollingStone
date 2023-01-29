using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody2D Rigidbody;
    public bool OnGround;
    public LayerMask GroundLayer;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        OnGround = Physics2D.Raycast(transform.position, Vector2.down, 2, GroundLayer);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Rigidbody.AddForce(Vector2.right, ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Rigidbody.AddForce(Vector2.left, ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.Space) &&  OnGround)
        {
            Rigidbody.velocity = Vector2.up * 5;
        }
    }
}
