using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATboxp : MonoBehaviour
{
    GameObject con;
    public bool despoint;    
    public bool enck;
    public GameObject ineObj;
    public float wtun;
    void Start()
    {
        con = GameObject.Find("Main Camera");       
        despoint = false;
        wtun = con.GetComponent<CON1>().whitetun;
        StartCoroutine(WaitAndPrint(0.2F));
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
        if (col.gameObject.tag == "bking" || col.gameObject.tag == "bknight"&&wtun==1)
        {
            enck = true;
            ineObj = col.gameObject;
        }
        if (col.gameObject.tag == "bqueen" || col.gameObject.tag == "bpawn" && wtun == 1)
        {
            enck = true;
            ineObj = col.gameObject;
        }
        if (col.gameObject.tag == "bbishop" || col.gameObject.tag == "brook" && wtun == 1)
        {
            enck = true;
            ineObj = col.gameObject;
        }
        if (col.gameObject.tag == "king" || col.gameObject.tag == "knight" && wtun ==- 1f)
        {
            Destroy(gameObject, 0.1f);
            ineObj = col.gameObject;
        }
        if (col.gameObject.tag == "queen" || col.gameObject.tag == "pawn" && wtun == -1)
        {
            Destroy(gameObject, 0.1f);
            ineObj = col.gameObject;
        }
        if (col.gameObject.tag == "bishop" || col.gameObject.tag == "rook" && wtun == -1)
        {
            Destroy(gameObject, 0.1f);
            ineObj = col.gameObject;
        }

    }
    public void Delete()
    {
        Destroy(ineObj);
    }
    public void MyDelete()
    {
        if (enck==false)
            Destroy(gameObject);
    }
IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        MyDelete();
    }
}
