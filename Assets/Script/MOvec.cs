using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOvec : MonoBehaviour {
    public GameObject con;   
    public bool up;
    public bool bk;
    private void Start()
    {
        con = GameObject.Find("Main Camera");
    }
    public void Update()
    {
        up = con.GetComponent<CON1>().tep;
        bk = con.GetComponent<CON1>().ckobjc;
        if (up==true)
        {
            transform.Translate(0.01f, 0, 0.07f);
            Destroy(gameObject, 2.5f);            
        }
        if (bk == true)
        {
            cdMove();
        }
    }
    public void cdMove()
    {
        Destroy(gameObject);
    }
   
}
