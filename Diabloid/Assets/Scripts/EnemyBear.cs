using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBear : MonoBehaviour
{
    
    public Rigidbody2D rb;
    public PlayerController player;
    public float speed;
    public int hp;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindObjectOfType<PlayerController>();

    }
    private void FixedUpdate()
    {
        while(Mathf.Abs(player.transform.position.x - rb.transform.position.x) < 3)
        {
            rb.AddForce(transform.up * speed,ForceMode2D.Force);
                


        }
    }

    // Update is called once per frame
    void Update()
    {
        

        
    }
}
