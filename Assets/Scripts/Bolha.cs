using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolha : MonoBehaviour
{
     public float velocbolha;
      public float entradaVertical;
   
    void Start()
    {
         velocbolha = 2.0f;
        
    }
    // Update is called once per frame
    void Update()
    {
        entradaVertical = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.up * velocbolha * Time.deltaTime);

          if (transform.position.y > 6.96){
            Destroy(this.gameObject);
            }


    }


}