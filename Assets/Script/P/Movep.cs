using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movep : MonoBehaviour
{
    GameObject con;
    public bool despoint;
    public GameObject inObj;
    public bool enp;
    public bool fustt;
    public float my;
    public float mx;
    public float mz;
    public GameObject inmove2;
    public bool limt;  
    void Start()
    {
        con = GameObject.Find("Main Camera");
        inObj = con.GetComponent<CON1>().selObj;
        if (con.GetComponent<CON1>().whitetun == 1)
        {
            fustt = inObj.GetComponent<Pawn>().fust;
        }
        if (con.GetComponent<CON1>().whitetun == -1)
        {
            fustt = inObj.GetComponent<Bpawn>().fust;
        }        
    }

    void Update()
    {        
        despoint = con.GetComponent<CON1>().tep;
        if (despoint == true)
        {
            Destroy(gameObject,0.1f);
        }        
        if (con.GetComponent<CON1>().whitetun == 1 && fustt == false && enp == false&&limt==false)
        {
            my = transform.position.y;
            mx = transform.position.x;
            mz = transform.position.z + 0.5f;
            Instantiate(inmove2, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));
            limt = true;
        }
        if (con.GetComponent<CON1>().whitetun == -1 && fustt == false && enp == false && limt == false)
        {
            my = transform.position.y;
            mx = transform.position.x;
            mz = transform.position.z - 0.5f;
            Instantiate(inmove2, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));
            limt = true;
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "bking" || col.gameObject.tag == "bknight")
        {
            enp = true;
            Destroy(gameObject, 0.2f);
        }
        if (col.gameObject.tag == "bqueen" || col.gameObject.tag == "bpawn")
        {
            enp = true;
            Destroy(gameObject, 0.2f);
        }
        if (col.gameObject.tag == "bbishop" || col.gameObject.tag == "brook")
        {
            enp = true;
            Destroy(gameObject, 0.2f);
        }
        if (col.gameObject.tag == "king" || col.gameObject.tag == "knight")
        {
            enp = true;
            Destroy(gameObject, 0.2f);
        }
        if (col.gameObject.tag == "queen" || col.gameObject.tag == "pawn")
        {
            enp = true;
            Destroy(gameObject, 0.2f);
        }
        if (col.gameObject.tag == "bishop" || col.gameObject.tag == "rook")
        {
            enp = true;
            Destroy(gameObject, 0.2f);
        }
    }
}
    

