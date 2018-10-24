using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bpawn : MonoBehaviour {
    public GameObject cameracon;//선택된 오브젝트
    public GameObject movep;//무브 인팩트  
    public GameObject selp;//선텍 인팩트
    public GameObject whoObj;//오브젝트를 담을곳
    //위치값정하기
    public float my;
    public float mx;
    public float mz;
    public bool fust;//첫행동 구분
    public bool level;//승급 구분
    public bool pOnOff;
    public bool moveObj;
    public GameObject guilevel;
    public float rayf;
    public GameObject atbox;
    public GameObject qObj;
    public GameObject bObj;
    public GameObject nObj;
    public GameObject rObj;
    void Start()
    {
        cameracon = GameObject.Find("Main Camera");
    }

    void Update()
    {
        if (pOnOff == true)
        {
            Instantiate(selp, transform.position, transform.rotation);
            whoObj = cameracon.GetComponent<CON1>().tagetObj;
            my = whoObj.transform.position.y + 0.15f;
            mx = whoObj.transform.position.x;
            mz = whoObj.transform.position.z - 0.5f;
            Instantiate(movep, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));
            my = whoObj.transform.position.y + 0.15f;
            mx = whoObj.transform.position.x + 0.5f;
            mz = whoObj.transform.position.z - 0.5f;
            Instantiate(atbox, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));
            my = whoObj.transform.position.y + 0.15f;
            mx = whoObj.transform.position.x - 0.5f;
            mz = whoObj.transform.position.z - 0.5f;
            Instantiate(atbox, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));            
            pOnOff = false;
        }        
        if (moveObj == true)
        {
            fust = true;
            whoObj = cameracon.GetComponent<CON1>().tagetObj;
            my = transform.position.y;
            mx = whoObj.transform.position.x;
            mz = whoObj.transform.position.z;
            transform.position = new Vector3(mx, my, mz);
            moveObj = false;
        }
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "level")
        {
            Levelp();
        }
    }
    public void Levelp()
    {
        guilevel.SetActive(true);
    }
    public void Qn()
    {
        guilevel.SetActive(false);
        Instantiate(qObj, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));
        Destroy(gameObject);
    }
    public void Bs()
    {
        guilevel.SetActive(false);
        Instantiate(bObj, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));
        Destroy(gameObject);
    }
    public void Rk()
    {
        guilevel.SetActive(false);
        Instantiate(rObj, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));
        Destroy(gameObject);
    }
    public void Nk()
    {
        guilevel.SetActive(false);
        Instantiate(nObj, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));
        Destroy(gameObject);
    }
}
