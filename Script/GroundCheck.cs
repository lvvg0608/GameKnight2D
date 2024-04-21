using UnityEngine;
using System;
using System.Collections;

public class GroundCheck : MonoBehaviour
{

    public Player player;
    public MovingPlat mov;
    public float sp;
    public Vector3 movep;
    // Use this for initialization
    void Start()
    {
        try
        {
            mov = GameObject.FindGameObjectWithTag("MovingPlat").GetComponent<MovingPlat>();
            player = gameObject.GetComponentInParent<Player>();
        }
        catch(NullReferenceException){}      
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.isTrigger == false)
            player.grounded = true;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {        
        if (collision.isTrigger == false && collision.CompareTag("MovingPlat"))
        {
            player.grounded = true;
        }
    }
 
}