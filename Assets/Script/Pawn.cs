using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour {
    public bool pOnOff;
    public GameObject movep;
    public GameObject sel;
    GameObject whoObj;
    public float my;
    public float mx;
    public float mz;
    public GameObject cameracon;
   
	void Update ()
    {
        if (pOnOff == true)
        {
            Instantiate(sel, transform.position,transform.rotation);
            whoObj = cameracon.GetComponent<CON1>().tagetObj;
            my = whoObj.transform.position.y+0.15f;
            mx = whoObj.transform.position.x;
            mz = whoObj.transform.position.z+0.5f;
            Instantiate(movep,new Vector3(mx,my,mz),Quaternion.Euler(0,0,0));
            mz = whoObj.transform.position.z + 1;
            Instantiate(movep,new Vector3(mx, my, mz),Quaternion.Euler(0, 0, 0));
            pOnOff = false;
        }
	}
}
