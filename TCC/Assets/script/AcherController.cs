using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AcherController : MonoBehaviour
{

    public Transform posicaoPlayer;
    public float velocidadeMovimento;
    public float distancia;
    public GameObject projetil;
    public bool tempoTiro;
    public GameObject tiroInimigo;
    public Transform posicaoTiro;
    public Transform posicaoTiroInimigo;
    // Start is called before the first frame update
    void Start()
    {
        tempoTiro = false;
    }

    // Update is called once per frame
    void Update()
    {

      //  distancia = Vector3.Distance(transform.position, posicaoPlayer.transform.position);

       

        if (tempoTiro == false)
        {
            Instantiate(projetil, posicaoTiroInimigo.position, Quaternion.identity);

           

            tempoTiro = true;

            StartCoroutine(tiroNovo());

        }

       

       // transform.position = Vector3.MoveTowards(transform.position, posicaoTiro.position, velocidadeMovimento * Time.deltaTime);

        

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
