using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    // very simple character movement script due to time

    public float speed;
    public Rigidbody2D rb;
    public GameObject fairy;

    private float input;
    private bool activateFairy;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void GetInputs()
    {
        input = Input.GetAxisRaw("Horizontal");
        activateFairy = Input.GetKeyDown(KeyCode.Space);
    }

    private void Update()
    {
        GetInputs();
        if(activateFairy && fairy.activeSelf == false)
        {
            fairy.SetActive(true);
        }
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        rb.velocity = new Vector2(input * speed, rb.velocity.y);
    }
}
