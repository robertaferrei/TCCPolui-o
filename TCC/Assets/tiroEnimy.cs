using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiroEnimy : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 6);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-1, 0, 0) * 5 * Time.deltaTime);
    }
    /*
    IEnumerator Tiro()
    {
        
    }*/
}
