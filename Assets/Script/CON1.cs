using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CON1 : MonoBehaviour
{
    Camera camera;
    public GameObject tagetObj;
    void Start()
    {
        camera = GetComponent<Camera>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.name);
                tagetObj = hit.transform.gameObject;
                tagetObj.GetComponent<Pawn>().pOnOff = true;
            }
        }
    }
}
