using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullScript : MonoBehaviour
{

    public Rigidbody2D rigidbody;
    public float flapStength = 6;
    public LogicManager logicManager;
    public bool alive = true;

    private string[] soundNames = new string[] { "jump1", "jump2", "jump3" };
    
    // Start is called before the first frame update
    void Start()
    {
        // retrive logicManagerScript
        this.logicManager = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetKeyDown(KeyCode.Space) && alive)
        {
            SkullJump();
        }


        if(gameObject.transform.position.y < -10)
        {
            this.rigidbody.simulated = false;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicManager.GameOver();
        alive = false;
    }

    private void SkullJump()
    {

        this.rigidbody.velocity = Vector2.up * this.flapStength;

       
        // play jump sound
        string[] soundNames = new string[] { "jump1", "jump2", "jump3" };
        var randomIndex = UnityEngine.Random.Range(0, this.soundNames.Length);

        FindObjectOfType<AudioManagerScript>().PlayAudio(this.soundNames[randomIndex]);

    }

}
