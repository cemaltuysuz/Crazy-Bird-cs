using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyHead : MonoBehaviour
{
    
    public float velocity = 1;
    private Rigidbody2D rb;
    public bool isDead;
    public GameObject DeathScreen;    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
        }
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathArea")
        {
            isDead = true;
            Time.timeScale = 0;
            DeathScreen.SetActive(true);
        }
    }
}
