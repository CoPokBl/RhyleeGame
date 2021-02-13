using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aaaaahhh : MonoBehaviour
{

    public Rigidbody2D rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        rb.AddForce(new Vector2(horizontal *Time.deltaTime*speed, 0f));
    }
}
