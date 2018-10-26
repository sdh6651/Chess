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
    public GameObject soundObj;
    public GameObject selobj1;
    void Start()
    {
        soundObj = GameObject.Find("Sound");
        con = GameObject.Find("Main Camera");
        despoint = false;
        wtun = con.GetComponent<CON1>().whitetun;
        StartCoroutine(WaitAndPrint(0.2F));
    }
    void Update()
    {
        selobj1 = con.GetComponent<CON1>().selObj;
        despoint = con.GetComponent<CON1>().tep;
        if (despoint == true)
        {
            Destroy(gameObject,0.1f);
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "bking" || col.gameObject.tag == "bknight" && wtun == 1)
        {
            Destroy(gameObject, 0.3f);
            ineObj = col.gameObject;
        }
        if (col.gameObject.tag == "bqueen" || col.gameObject.tag == "bpawn" && wtun == 1)
        {
            Destroy(gameObject, 0.3f);
            ineObj = col.gameObject;
        }
        if (col.gameObject.tag == "bbishop" || col.gameObject.tag == "brook" && wtun == 1)
        {
            Destroy(gameObject, 0.3f);
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
            soundObj.GetComponent<SoundMain>().kdiesep.Play();
            con.GetComponent<CON1>().wklog += 1;
            con.GetComponent<CON1>().Logui();
        }
        if (ineObj.gameObject.tag == "bking")
        {
            soundObj.GetComponent<SoundMain>().kdiesep.Play();
            con.GetComponent<CON1>().bklog += 1;
            con.GetComponent<CON1>().Logui();
        }
        if (ineObj.gameObject.tag == "bqueen")
        {
            soundObj.GetComponent<SoundMain>().qdiesep.Play();
            con.GetComponent<CON1>().bqlog += 1;
            con.GetComponent<CON1>().Logui();
        }
        if (ineObj.gameObject.tag == "queen")
        {
            soundObj.GetComponent<SoundMain>().qdiesep.Play();
            con.GetComponent<CON1>().wqlog += 1;
            con.GetComponent<CON1>().Logui();
        }
        if (ineObj.gameObject.tag == "bbishop")
        {
            soundObj.GetComponent<SoundMain>().bdiesep.Play();
            con.GetComponent<CON1>().bblog += 1;
            con.GetComponent<CON1>().Logui();
        }
        if (ineObj.gameObject.tag == "bishop")
        {
            soundObj.GetComponent<SoundMain>().bdiesep.Play();
            con.GetComponent<CON1>().wblog += 1;
            con.GetComponent<CON1>().Logui();
        }
        if (ineObj.gameObject.tag == "rook")
        {
            soundObj.GetComponent<SoundMain>().rdiesep.Play();
            con.GetComponent<CON1>().wrlog += 1;
            con.GetComponent<CON1>().Logui();
        }
        if (ineObj.gameObject.tag == "brook")
        {
            soundObj.GetComponent<SoundMain>().rdiesep.Play();
            con.GetComponent<CON1>().brlog += 1;
            con.GetComponent<CON1>().Logui();
        }
        if (ineObj.gameObject.tag == "knight")
        {
            soundObj.GetComponent<SoundMain>().ndiesep.Play();
            con.GetComponent<CON1>().wnlog += 1;
            con.GetComponent<CON1>().Logui();
        }
        if (ineObj.gameObject.tag == "bknight")
        {
            soundObj.GetComponent<SoundMain>().ndiesep.Play();
            con.GetComponent<CON1>().bnlog += 1;
            con.GetComponent<CON1>().Logui();
        }
        if (ineObj.gameObject.tag == "bpawn")
        {
            soundObj.GetComponent<SoundMain>().pdiesep.Play();
            con.GetComponent<CON1>().bplog += 1;
            con.GetComponent<CON1>().Logui();
        }
        if (ineObj.gameObject.tag == "pawn")
        {
            soundObj.GetComponent<SoundMain>().pdiesep.Play();
            con.GetComponent<CON1>().wplog += 1;
            con.GetComponent<CON1>().Logui();
        }
        selobj1.GetComponent<EpCon>().ATEp();
        ineObj.GetComponent<EpCon>().DieEp();
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