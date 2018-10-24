using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movep1 : MonoBehaviour
{
    GameObject con;
    public bool despoint;     
        
    void Start()
    {
        con = GameObject.Find("Main Camera");        
    }
    void Update()
    {
        despoint = con.GetComponent<CON1>().tep;
        if (despoint == true)
        {
            Destroy(gameObject, 0.1f);
        }        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "bking" || col.gameObject.tag == "bknight")
        {           
            Destroy(gameObject, 0.2f);
        }
        if (col.gameObject.tag == "bqueen" || col.gameObject.tag == "bpawn")
        {
            Destroy(gameObject, 0.2f);
        }
        if (col.gameObject.tag == "bbishop" || col.gameObject.tag == "brook")
        {
            Destroy(gameObject, 0.2f);
        }
        if (col.gameObject.tag == "king" || col.gameObject.tag == "knight")
        {
            Destroy(gameObject, 0.2f);
        }
        if (col.gameObject.tag == "queen" || col.gameObject.tag == "pawn")
        {
            Destroy(gameObject, 0.2f);
        }
        if (col.gameObject.tag == "bishop" || col.gameObject.tag == "rook")
        {
            Destroy(gameObject, 0.2f);
        }
    }
}


