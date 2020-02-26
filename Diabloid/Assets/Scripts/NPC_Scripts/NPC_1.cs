using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_1: MonoBehaviour
{
    
    public bool active;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            active = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            active = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public bool getActive()
    {
        return active;
    }
}
