using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyck : MonoBehaviour {
    public GameObject forObj;       
    public float ex;
    public float ey;
    public float ez;    
    void Update ()
    {       
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            forObj = hit.transform.gameObject;           
        }        
    }    

}
