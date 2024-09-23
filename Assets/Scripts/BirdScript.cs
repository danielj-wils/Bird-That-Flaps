using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float flapStrength;
    public Logic logic;
    public bool birdIsAlive = true;

    public float topYborder = 10f;
    public float bottomYborder = -9f;
    
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            rb.velocity = Vector2.up * flapStrength; 
        }

        CheckGameBorders();
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        logic.GameOver();  
        birdIsAlive = false;
    }

    private void CheckGameBorders()
    {
        if (rb.position.y > topYborder || rb.position.y < bottomYborder)
        {
            logic.GameOver();
            birdIsAlive = false;
        }
    }
}
