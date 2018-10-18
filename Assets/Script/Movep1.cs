using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movep1 : MonoBehaviour
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
            Destroy(gameObject, 0.2f);
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "enemy")
        {
            con.GetComponent<CON1>().tep = true;
        }
    }
}
