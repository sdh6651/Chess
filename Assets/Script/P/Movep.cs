using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movep : MonoBehaviour
{
    GameObject con;
    public bool despoint;
    public GameObject inObj;

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
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "bqueen" || col.gameObject.tag == "bpawn")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "bbishop" || col.gameObject.tag == "brook")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "king" || col.gameObject.tag == "knight")
        {            
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "queen" || col.gameObject.tag == "pawn")
        {         
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "bishop" || col.gameObject.tag == "rook")
        {           
            Destroy(gameObject);
        }
    }
}
