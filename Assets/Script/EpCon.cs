using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EpCon : MonoBehaviour {
    public GameObject moveEp;
    public GameObject atEp;
    public GameObject dieEp;
    public GameObject con;
    public GameObject pos;
    private void Start()
    {
        con=GameObject.Find("Main Camera");       
    }
    private void Update()
    {
        pos = con.GetComponent<CON1>().tagetObj;
    }
    public void MoveEp()
    {
        Instantiate(moveEp, pos.transform);
    }
    public void ATEp()
    {
        Instantiate(atEp, pos.transform);
    }
    public void DieEp()
    {
        Instantiate(dieEp, pos.transform);
    }
}
