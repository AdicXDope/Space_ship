using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufo_movements : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce;
    public logic logic;
    public bool playerIsAlive = true;
    [SerializeField] AudioSource jumpSound;
    [SerializeField] AudioSource deadSound;

    // Start is called before the first frame update
    void Start()
    {
         
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && playerIsAlive ==true)
        {
          rb.velocity = Vector2.up*jumpForce;
          jumpSound.Play();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        playerIsAlive=false;
        deadSound.Play();
        
    }

}    
