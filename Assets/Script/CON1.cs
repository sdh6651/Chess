using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CON1 : MonoBehaviour
{
    static CON1 _instance;
    public static CON1 Instance()
    {
        return _instance;
    }
    Camera came;
    public GameObject tagetObj;
    public GameObject selObj;
    public bool tep;
    public bool whitetun;
    public bool pw;
    public bool bs;
    public bool rk;
    public bool q;
    public bool kn;
    public bool k;
    public float limt;

    void Start()
    {
        came = GetComponent<Camera>();
        whitetun = true;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray ray = came.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.name);
                tagetObj = hit.transform.gameObject;                
                if (tagetObj.tag == "pawn"&& tep == true)
                {                    
                    pw = true;
                    tep = false;
                    tagetObj.GetComponent<Pawn>().pOnOff = true;
                    selObj = tagetObj;                    
                }
                if (tagetObj.tag == "pointmove"&&pw==true)
                {
                    pw = false;
                    selObj.GetComponent<Pawn>().moveObj = true;
                    tep = true;
                    whitetun = false;
                }
                if (tagetObj.tag == "atbox" && pw == true)
                {
                    pw = false;
                    selObj.GetComponent<Pawn>().moveObj = true;
                    tep = true;
                    tagetObj.GetComponent<ATboxp>().Delete();
                }
                if (tagetObj.tag == "bishop" && tep == true)
                {
                    bs = true;
                    tep = false;
                    tagetObj.GetComponent<Bishop>().pOnOff = true;
                    selObj = tagetObj;                    
                }
                if (tagetObj.tag == "pointmove"&&bs==true)
                {
                    bs = false;
                    selObj.GetComponent<Bishop>().moveObj = true;
                    tep = true;
                    whitetun = false;
                }
                if (tagetObj.tag == "atbox" && bs == true)
                {
                    pw = false;
                    selObj.GetComponent<Bishop>().moveObj = true;
                    tep = true;
                    tagetObj.GetComponent<ATboxb>().Delete();
                }
                if (tagetObj.tag == "queen" && tep == true)
                {
                    q = true;
                    limt = 0;
                    tep = false;
                    tagetObj.GetComponent<Queen>().pOnOff = true;
                    selObj = tagetObj;
                }
                if (tagetObj.tag == "pointmove" && q == true)
                {
                    q = false;
                    selObj.GetComponent<Queen>().moveObj = true;
                    tep = true;
                    whitetun = false;
                }
                if (tagetObj.tag == "atbox" && q == true)
                {
                    q = false;
                    selObj.GetComponent<Queen>().moveObj = true;
                    tep = true;
                    tagetObj.GetComponent<ATboxb>().Delete();
                }
                if (tagetObj.tag == "knight" && tep == true)
                {
                    kn = true;
                    limt = 0;
                    tep = false;
                    tagetObj.GetComponent<Knight>().pOnOff = true;
                    selObj = tagetObj;                    
                }
                if (tagetObj.tag == "pointmove" && kn == true)
                {
                    kn = false;
                    selObj.GetComponent<Knight>().moveObj = true;
                    tep = true;
                    whitetun = false;
                }
                if (tagetObj.tag == "atbox" && kn == true)
                {
                    kn = false;
                    selObj.GetComponent<Knight>().moveObj = true;
                    tep = true;
                    tagetObj.GetComponent<ATboxb>().Delete();
                }
                if (tagetObj.tag == "rook" && tep == true)
                {
                    rk = true;
                    tep = false;
                    tagetObj.GetComponent<Rook>().pOnOff = true;
                    selObj = tagetObj;                    
                }
                if (tagetObj.tag == "pointmove" && rk == true)
                {
                    rk = false;
                    selObj.GetComponent<Rook>().moveObj = true;
                    tep = true;
                    whitetun = false;
                }
                if (tagetObj.tag == "atbox" && rk == true)
                {
                    rk = false;
                    selObj.GetComponent<Rook>().moveObj = true;
                    tep = true;
                    tagetObj.GetComponent<ATboxb>().Delete();
                }
                if (tagetObj.tag == "king" && tep == true)
                {
                    k = true;
                    tep = false;
                    tagetObj.GetComponent<King>().pOnOff = true;
                    selObj = tagetObj;                    
                }
                if (tagetObj.tag == "pointmove" && k == true)
                {
                    k = false;
                    selObj.GetComponent<King>().moveObj = true;
                    tep = true;
                    whitetun = false;
                }
                if (tagetObj.tag == "atbox" && k == true)
                {
                    k = false;
                    selObj.GetComponent<King>().moveObj = true;
                    tep = true;
                    tagetObj.GetComponent<ATboxb>().Delete();
                }
                if (tagetObj.tag == "Board")
                {
                    tep = true;
                }
            }
        }        
    }    
}
