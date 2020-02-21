using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBear : MonoBehaviour
{
    
    public Rigidbody2D rb;
    EnemyBear bear;
    public PlayerController player;
    public float speed;
    public int hp;
    bool alive = true;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindObjectOfType<PlayerController>();
        bear = GameObject.FindObjectOfType<EnemyBear>();

    }
    private void FixedUpdate()
    {
        if (alive)
        {
            Vector3 heading = player.transform.position - bear.transform.position;

            if (Mathf.Abs(player.transform.position.x - bear.transform.position.x) < 5 & Mathf.Abs(player.transform.position.y - bear.transform.position.y) < 5)
            {
                rb.AddForce(heading * speed, ForceMode2D.Force);

            }
            else
            {

                rb.Sleep();
            }
            if (rb.velocity.magnitude > speed)
            {
                rb.velocity = rb.velocity.normalized * speed;
            }
        }

        if(hp == 0)
        {
            rb.Sleep();
            Destroy(bear.gameObject, 0.1f);
            alive = false;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            hp--;
        }
    }
    // Update is called once per frame
    void Update()
    {
        

        
    }
}
