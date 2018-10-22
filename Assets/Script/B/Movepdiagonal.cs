using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movepdiagonal : MonoBehaviour {
    GameObject con;
    public bool despoint;
    public GameObject atmoveObj;
    public GameObject moveclon;
    public float my;
    public float mx;
    public float mz;
    public float limt;
    

    void Start()
    {
        con = GameObject.Find("Main Camera");
        StartCoroutine(WaitAndPrint(0.2F));

    }

    void Update()
    {
        despoint = con.GetComponent<CON1>().tep;       
        if (despoint == true)
        {
            Destroy(gameObject);
        }
        if (limt == 1)
        {
            Inmovecolonobj();
        }
        
    }

    void Inmovecolonobj()
    {
        if (limt == 1)
        {
            limt = 0;
            my = transform.position.y;
            mx = transform.position.x + 0.5f;
            mz = transform.position.z + 0.5f;
            Instantiate(moveclon, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));
        }
    }
    void Inatobj()
    {
        my = transform.position.y;
        mx = transform.position.x;
        mz = transform.position.z;
        Instantiate(atmoveObj, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "enemy")
        {
            limt = 0;
            Inatobj();
            Debug.Log("적감지");           
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "wall")
        {
            limt = 0;
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "king" || col.gameObject.tag == "knight")
        {
            limt = 0;
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "queen" || col.gameObject.tag == "pawn")
        {
            limt = 0;
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "bishop" || col.gameObject.tag == "rook")
        {
            limt = 0;
            Destroy(gameObject);
        }       

    }
    IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        limt = 1;
    }
}
