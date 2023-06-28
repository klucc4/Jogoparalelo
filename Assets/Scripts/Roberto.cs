using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roberto : MonoBehaviour
{
     public float velocroberto;
      public float entradaHorizontal;
   
    void Start()
    {
         velocroberto = 2.0f;
        
    }
    // Update is called once per frame
    void Update()
    {
        entradaHorizontal = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.right * velocroberto * Time.deltaTime);

          if (transform.position.x > 14.74){
            Destroy(this.gameObject);
            }



    }


}

