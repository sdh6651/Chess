using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyck : MonoBehaviour {
    public GameObject forObj;
    public GameObject enemyp;
    public GameObject momObj;
    public float ex;
    public float ey;
    public float ez;
    bool onoff;
    void Update ()
    {
        onoff =momObj.GetComponent<Pawn>().pOnOff;
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            forObj = hit.transform.gameObject;
            if (forObj.tag == "enemy" && onoff == true)
            {
                Movep();
            }
        }        
    }
    public void Movep()
    {
        ex = forObj.transform.position.x;
        ey = forObj.transform.position.y + 0.15f;
        ez = forObj.transform.position.z;
        Instantiate(enemyp, new Vector3(ex, ey, ez), Quaternion.Euler(0, 0, 0));
    }

}
