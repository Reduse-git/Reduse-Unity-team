using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{   public Text mytext;
    public Rigidbody2D rb;
    NPC_1 npc;
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        npc = GameObject.FindObjectOfType<NPC_1>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        

        if(npc.active)
        {
            mytext.text = "Hi there";
        }
        if (!npc.active)
        {
            mytext.text = "";
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Portal")
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
