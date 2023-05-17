using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo1 : MonoBehaviour
{

    public float StoppingDistance;
    public float Speed;
    public Transform Target;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector2.Distance(transform.position, Target.position) > StoppingDistance) 
        {

            transform.position = Vector2.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime);

        }

        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("tiroPlayer"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        } 
        
    }
















    //void OnCollisionEnter2D(Collision2D collisior)


    //{

    //if (collisior.gameObject.tag == "inimigo")
    //{
    // Destroy(gameObject);
}


   // }


//