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
    public float whitetun;
    public bool pw;
    public bool bs;
    public bool rk;
    public bool q;
    public bool kn;
    public bool k;
    public float limt;
    public float wklog;
    public float wqlog;
    public float wblog;
    public float wnlog;
    public float wrlog;
    public float wplog;
    public float bklog;
    public float bqlog;
    public float bblog;
    public float bnlog;
    public float brlog;
    public float bplog;

    void Start()
    {
        came = GetComponent<Camera>();
        whitetun = 1;
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
                if (tagetObj.tag == "pawn"&& tep == true&&whitetun==1)
                {                    
                    pw = true;
                    tep = false;
                    tagetObj.GetComponent<Pawn>().pOnOff = true;
                    selObj = tagetObj;                    
                }
                if (tagetObj.tag == "pointmove"&&pw==true && whitetun == 1)
                {
                    pw = false;
                    selObj.GetComponent<Pawn>().moveObj = true;
                    tep = true;
                    whitetun *= -1;
                }
                if (tagetObj.tag == "atbox" && pw == true && whitetun == 1)
                {
                    whitetun *= -1;
                    pw = false;
                    selObj.GetComponent<Pawn>().moveObj = true;
                    tep = true;
                    tagetObj.GetComponent<ATboxp>().Delete();
                }
                if (tagetObj.tag == "bishop" && tep == true && whitetun == 1)
                {
                    bs = true;
                    tep = false;
                    tagetObj.GetComponent<Bishop>().pOnOff = true;
                    selObj = tagetObj;                    
                }
                if (tagetObj.tag == "pointmove"&&bs==true && whitetun == 1)
                {
                    whitetun *= -1;
                    bs = false;
                    selObj.GetComponent<Bishop>().moveObj = true;
                    tep = true;                   
                }
                if (tagetObj.tag == "atbox" && bs == true && whitetun == 1)
                {
                    whitetun *= -1;
                    pw = false;
                    selObj.GetComponent<Bishop>().moveObj = true;
                    tep = true;
                    tagetObj.GetComponent<ATboxp>().Delete();
                }
                if (tagetObj.tag == "queen" && tep == true && whitetun == 1)
                {
                    q = true;
                    limt = 0;
                    tep = false;
                    tagetObj.GetComponent<Queen>().pOnOff = true;
                    selObj = tagetObj;
                }
                if (tagetObj.tag == "pointmove" && q == true && whitetun == 1)
                {
                    q = false;
                    selObj.GetComponent<Queen>().moveObj = true;
                    tep = true;
                    whitetun *= -1;
                }
                if (tagetObj.tag == "atbox" && q == true && whitetun == 1)
                {
                    whitetun *= -1;
                    q = false;
                    selObj.GetComponent<Queen>().moveObj = true;
                    tep = true;
                    tagetObj.GetComponent<ATboxp>().Delete();
                }
                if (tagetObj.tag == "knight" && tep == true && whitetun == 1)
                {
                    kn = true;
                    limt = 0;
                    tep = false;
                    tagetObj.GetComponent<Knight>().pOnOff = true;
                    selObj = tagetObj;                    
                }
                if (tagetObj.tag == "pointmove" && kn == true && whitetun == 1)
                {
                    kn = false;
                    selObj.GetComponent<Knight>().moveObj = true;
                    tep = true;
                    whitetun *= -1;
                }
                if (tagetObj.tag == "atbox" && kn == true && whitetun == 1)
                {
                    whitetun *= -1;
                    kn = false;
                    selObj.GetComponent<Knight>().moveObj = true;
                    tep = true;
                    tagetObj.GetComponent<ATboxp>().Delete();
                }
                if (tagetObj.tag == "rook" && tep == true && whitetun == 1)
                {
                    rk = true;
                    tep = false;
                    tagetObj.GetComponent<Rook>().pOnOff = true;
                    selObj = tagetObj;                    
                }
                if (tagetObj.tag == "pointmove" && rk == true && whitetun == 1)
                {
                    rk = false;
                    selObj.GetComponent<Rook>().moveObj = true;
                    tep = true;
                    whitetun *= -1;
                }
                if (tagetObj.tag == "atbox" && rk == true && whitetun == 1)
                {
                    whitetun *= -1;
                    rk = false;
                    selObj.GetComponent<Rook>().moveObj = true;
                    tep = true;
                    tagetObj.GetComponent<ATboxp>().Delete();
                }
                if (tagetObj.tag == "king" && tep == true && whitetun == 1)
                {
                    k = true;
                    tep = false;
                    tagetObj.GetComponent<King>().pOnOff = true;
                    selObj = tagetObj;                    
                }
                if (tagetObj.tag == "lcbox" && k == true && whitetun == 1)
                {
                    k = false;
                    selObj.GetComponent<King>().moveObj = true;
                    selObj.GetComponent<King>().lcas.GetComponent<Rook>().csObj1 = true;                  
                    whitetun *= -1;
                    tep = true;
                }
                if (tagetObj.tag == "rcbox" && k == true && whitetun == 1)
                {
                    k = false;
                    selObj.GetComponent<King>().moveObj = true;
                    selObj.GetComponent<King>().rcas.GetComponent<Rook>().csObj = true;                   
                    whitetun *= -1;
                    tep = true;
                }
                if (tagetObj.tag == "pointmove" && k == true && whitetun == 1)
                {
                    k = false;
                    selObj.GetComponent<King>().moveObj = true;
                    tep = true;
                    whitetun *= -1;
                }
                if (tagetObj.tag == "atbox" && k == true && whitetun == 1)
                {
                    whitetun *= -1;
                    k = false;
                    selObj.GetComponent<King>().moveObj = true;
                    tep = true;
                    tagetObj.GetComponent<ATboxp>().Delete();
                }
                if (tagetObj.tag == "Board")
                {
                    tep = true;
                }
                if (tagetObj.tag == "bpawn" && tep == true && whitetun == -1)
                {
                    pw = true;
                    tep = false;
                    tagetObj.GetComponent<Bpawn>().pOnOff = true;
                    selObj = tagetObj;
                }
                if (tagetObj.tag == "pointmove" && pw == true&&whitetun == -1)
                {
                    pw = false;
                    selObj.GetComponent<Bpawn>().moveObj = true;
                    tep = true;
                    whitetun *= -1;
                }
                if (tagetObj.tag == "atbox" && pw == true && whitetun == -1)
                {
                    whitetun *= -1;
                    pw = false;
                    selObj.GetComponent<Bpawn>().moveObj = true;
                    tep = true;
                    tagetObj.GetComponent<ATboxb>().Delete();
                }
                if (tagetObj.tag == "bbishop" && tep == true && whitetun == -1)
                {
                    bs = true;
                    tep = false;
                    tagetObj.GetComponent<Bishop>().pOnOff = true;
                    selObj = tagetObj;
                }
                if (tagetObj.tag == "pointmove" && bs == true && whitetun == -1)
                {
                    bs = false;
                    selObj.GetComponent<Bishop>().moveObj = true;
                    tep = true;
                    whitetun *= -1;
                }
                if (tagetObj.tag == "atbox" && bs == true && whitetun == -1)
                {
                    whitetun *= -1;
                    bs = false;
                    selObj.GetComponent<Bishop>().moveObj = true;
                    tep = true;
                    tagetObj.GetComponent<ATboxb>().Delete();
                }
                if (tagetObj.tag == "bqueen" && tep == true && whitetun == -1)
                {
                    q = true;
                    tep = false;
                    tagetObj.GetComponent<Queen>().pOnOff = true;
                    selObj = tagetObj;
                }
                if (tagetObj.tag == "pointmove" && q == true && whitetun == -1)
                {
                    q = false;
                    selObj.GetComponent<Queen>().moveObj = true;
                    tep = true;
                    whitetun *= -1;
                }
                if (tagetObj.tag == "atbox" && q == true && whitetun == -1)
                {
                    whitetun *= -1;
                    q = false;
                    selObj.GetComponent<Queen>().moveObj = true;
                    tep = true;
                    tagetObj.GetComponent<ATboxb>().Delete();
                }
                if (tagetObj.tag == "bknight" && tep == true && whitetun == -1)
                {
                    kn = true;
                    tep = false;
                    tagetObj.GetComponent<Knight>().pOnOff = true;
                    selObj = tagetObj;
                }
                if (tagetObj.tag == "pointmove" && kn == true && whitetun == -1)
                {
                    kn = false;
                    selObj.GetComponent<Knight>().moveObj = true;
                    tep = true;
                    whitetun *= -1;
                }
                if (tagetObj.tag == "atbox" && kn == true && whitetun == -1)
                {
                    whitetun *= -1;
                    kn = false;
                    selObj.GetComponent<Knight>().moveObj = true;
                    tep = true;
                    tagetObj.GetComponent<ATboxb>().Delete();
                }
                if (tagetObj.tag == "brook" && tep == true && whitetun == -1)
                {
                    rk = true;
                    tep = false;
                    tagetObj.GetComponent<Rook>().pOnOff = true;
                    selObj = tagetObj;
                }
                if (tagetObj.tag == "pointmove" && rk == true && whitetun == -1)
                {
                    rk = false;
                    selObj.GetComponent<Rook>().moveObj = true;
                    tep = true;
                    whitetun *= -1;
                }
                if (tagetObj.tag == "atbox" && rk == true && whitetun == -1)
                {
                    whitetun *= -1;
                    rk = false;
                    selObj.GetComponent<Rook>().moveObj = true;
                    tep = true;
                    tagetObj.GetComponent<ATboxb>().Delete();
                }
                if (tagetObj.tag == "bking" && tep == true && whitetun == -1)
                {
                    k = true;
                    tep = false;
                    tagetObj.GetComponent<King>().pOnOff = true;
                    selObj = tagetObj;
                }
                if (tagetObj.tag == "pointmove" && k == true && whitetun == -1)
                {
                    k = false;
                    selObj.GetComponent<King>().moveObj = true;
                    tep = true;
                    whitetun *= -1;
                }
                if (tagetObj.tag == "lcbox" && k == true && whitetun == -1)
                {
                    k = false;
                    selObj.GetComponent<King>().moveObj = true;
                    selObj.GetComponent<King>().lcas.GetComponent<Rook>().csObj1 = true;                    
                    whitetun *= -1;
                    tep = true;
                }
                if (tagetObj.tag == "rcbox" && k == true && whitetun == -1)
                {
                    k = false;
                    selObj.GetComponent<King>().moveObj = true;
                    selObj.GetComponent<King>().rcas.GetComponent<Rook>().csObj = true;                   
                    whitetun *= -1;
                    tep = true;
                }
                if (tagetObj.tag == "atbox" && k == true && whitetun == -1)
                {
                    whitetun *= -1;
                    k = false;
                    selObj.GetComponent<King>().moveObj = true;                    
                    tep = true;
                    tagetObj.GetComponent<ATboxb>().Delete();
                }
            }
        }        
    }
    public void WQin()
    {
        selObj.GetComponent<Pawn>().Qn();
    }
    public void WBin()
    {
        selObj.GetComponent<Pawn>().Bs();
    }
    public void WRin()
    {
        selObj.GetComponent<Pawn>().Rk();
    }
    public void WNin()
    {
        selObj.GetComponent<Pawn>().Nk();
    }
    public void BQin()
    {
        selObj.GetComponent<Bpawn>().Qn();
    }
    public void BBin()
    {
        selObj.GetComponent<Bpawn>().Bs();
    }
    public void BRin()
    {
        selObj.GetComponent<Bpawn>().Rk();
    }
    public void BNin()
    {
        selObj.GetComponent<Bpawn>().Nk();
    }
}
