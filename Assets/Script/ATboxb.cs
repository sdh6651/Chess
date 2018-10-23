using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATboxb : MonoBehaviour
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
        if (col.gameObject.tag == "bking" || col.gameObject.tag == "bknight" && wtun == 1)
        {
            Destroy(gameObject, 0.1f);
            ineObj = col.gameObject;
        }
        if (col.gameObject.tag == "bqueen" || col.gameObject.tag == "bpawn" && wtun == 1)
        {
            Destroy(gameObject, 0.1f);
            ineObj = col.gameObject;
        }
        if (col.gameObject.tag == "bbishop" || col.gameObject.tag == "brook" && wtun == 1)
        {
            Destroy(gameObject, 0.1f);
            ineObj = col.gameObject;
        }
        if (col.gameObject.tag == "king" || col.gameObject.tag == "knight" && wtun == -1f)
        {
            enck = true;
            ineObj = col.gameObject;
        }
        if (col.gameObject.tag == "queen" || col.gameObject.tag == "pawn" && wtun == -1)
        {
            enck = true;
            ineObj = col.gameObject;
        }
        if (col.gameObject.tag == "bishop" || col.gameObject.tag == "rook" && wtun == -1)
        {
            enck = true;
            ineObj = col.gameObject;
        }

    }
    public void Delete()
    {
        if (ineObj.gameObject.tag == "king")
        {
            con.GetComponent<CON1>().wklog = +1;
        }
        if (ineObj.gameObject.tag =="bking")
        {
            con.GetComponent<CON1>().bklog=+1;
        }
        if (ineObj.gameObject.tag == "bqueen")
        {
            con.GetComponent<CON1>().bqlog= +1;
        }
        if (ineObj.gameObject.tag == "queen")
        {
            con.GetComponent<CON1>().wqlog= +1;
        }
        if (ineObj.gameObject.tag == "bbishop")
        {
            con.GetComponent<CON1>().bblog= +1;
        }
        if (ineObj.gameObject.tag == "bishop")
        {
            con.GetComponent<CON1>().wblog = +1;
        }
        if (ineObj.gameObject.tag == "rook")
        {
            con.GetComponent<CON1>().wrlog= +1;
        }
        if (ineObj.gameObject.tag =="brook")
        {
            con.GetComponent<CON1>().brlog = +1;
        }
        if (ineObj.gameObject.tag == "knight")
        { 
            con.GetComponent<CON1>().wklog = +1;
        }
        if (ineObj.gameObject.tag =="bknight")
        {
            con.GetComponent<CON1>().bklog = +1;
        }
        if (ineObj.gameObject.tag == "bpawn")
        {
            con.GetComponent<CON1>().bplog = +1;
        }
        if (ineObj.gameObject.tag == "pawn")
        {
            con.GetComponent<CON1>().wplog = +1;
        }
        Destroy(ineObj);
    }
    public void MyDelete()
    {
        if (enck == false)
            Destroy(gameObject);
    }
    IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        MyDelete();
    }
}