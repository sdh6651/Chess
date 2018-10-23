using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moven : MonoBehaviour {

    GameObject con;
    public bool despoint;
    public GameObject inObj;
    public GameObject ineObj;
    public float mx;
    public float my;
    public float mz;
    public GameObject atmoveObj;
    public float wtun;
    void Start()
    {
        con = GameObject.Find("Main Camera");
        wtun = con.GetComponent<CON1>().whitetun;
    }

    void Update()
    {
        despoint = con.GetComponent<CON1>().tep;
        if (despoint == true)
        {
            Destroy(gameObject, 0.1f);
        }
    }
    void Inatobj()
    {
        my = transform.position.y;
        mx = transform.position.x;
        mz = transform.position.z;
        Instantiate(atmoveObj, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));
        Debug.Log("생성");
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "bking" || col.gameObject.tag == "bknight")
        {
            
            if (wtun == 1)
            {
                Inatobj();
            }
            Destroy(gameObject, 0.1f);
        }
        if (col.gameObject.tag == "bqueen" || col.gameObject.tag == "bpawn")
        {
            
            if (wtun == 1)
            {
                Inatobj();
            }
            Destroy(gameObject, 0.1f);
        }
        if (col.gameObject.tag == "bbishop" || col.gameObject.tag == "brook")
        {
           
            if (wtun == 1)
            {
                Inatobj();
            }
            Destroy(gameObject, 0.1f);

        }
        if (col.gameObject.tag == "wall")
        {
            
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "king" || col.gameObject.tag == "knight")
        {
            
            if (wtun == -1)
            {
                Inatobj();
            }
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "queen" || col.gameObject.tag == "pawn")
        {
            
            if (wtun == -1)
            {
                Inatobj();
            }
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "bishop" || col.gameObject.tag == "rook")
        {
           
            if (wtun == -1)
            {
                Inatobj();
            }
            Destroy(gameObject);
        }
    }
}

