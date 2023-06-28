using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robertinhos : MonoBehaviour
{
     public float velocrobertinhos;
      public float entradaHorizontal;
   
    void Start()
    {
         velocrobertinhos = 2.5f;
        
    }
    // Update is called once per frame
    void Update()
    {
        entradaHorizontal = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.right * velocrobertinhos * Time.deltaTime);

          if (transform.position.x > 14.74){
            Destroy(this.gameObject);
            }



    }


}