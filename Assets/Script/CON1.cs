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
    void Start()
    {
        came = GetComponent<Camera>();
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
                if (tagetObj.tag == "pawn")
                {
                    tep = false;
                    tagetObj.GetComponent<Pawn>().pOnOff = true;
                    selObj = tagetObj;
                }
                if (tagetObj.tag == "pointmove")
                {
                    selObj.GetComponent<Pawn>().moveObj = true;
                    tep = true;
                }                
            }
        }        
    }
}
