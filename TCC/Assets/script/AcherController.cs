using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AcherController : MonoBehaviour
{
    public float velocidadeMovimento;
    public GameObject projetil;
    public bool tempoTiro;
    public Transform posicaoTiroInimigo;
   
    void Start()
    {
        tempoTiro = false;
    }

    void Update()
    {

         if (tempoTiro == false)
        {
            Instantiate(projetil, posicaoTiroInimigo.position, Quaternion.identity);

           

            tempoTiro = true;

            StartCoroutine(tiroNovo());

        }


    }

    IEnumerator tiroNovo()
    {
        
        yield return new WaitForSeconds(2f);
        tempoTiro = false;


    }

    void OnCollisionEnter2D(Collision2D collisior)
    {
        /*

        if (collisior.gameObject.tag == "inimigo")
        {
            Destroy(gameObject);
        }


        */



    }







}
