using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Aaaaahhh : MonoBehaviour
{

    public Rigidbody2D rb;
    public float speed;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Finish"))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(new Vector2(0f,-200f));
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        rb.AddForce(new Vector2(horizontal *Time.deltaTime*speed, 0f));
    }
}
