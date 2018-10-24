using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class King : MonoBehaviour {

    public GameObject cameracon;//선택된 오브젝트
    public GameObject movep;//무브 박스    
    public GameObject selp;//선텍 인팩트
    public GameObject whoObj;//오브젝트를 담을곳
    //위치값정하기
    public float my;
    public float mx;
    public float mz;
    public bool pOnOff;//말 선택확인
    public bool moveObj;//말 움직임 확인
    public GameObject forObj;
    public bool fust;
    public GameObject lck;
    public GameObject rck;  
    public GameObject lcas;
    public GameObject rcas;
    public GameObject lcbox;
    public GameObject rcbox;
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
            mx = whoObj.transform.position.x + 0.5f;
            mz = whoObj.transform.position.z + 0.5f;
            Instantiate(movep, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));//1
            my = whoObj.transform.position.y + 0.15f;
            mx = whoObj.transform.position.x - 0.5f;
            mz = whoObj.transform.position.z + 0.5f;
            Instantiate(movep, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));//2
            my = whoObj.transform.position.y + 0.15f;
            mx = whoObj.transform.position.x - 0.5f;
            mz = whoObj.transform.position.z - 0.5f;
            Instantiate(movep, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));//3
            my = whoObj.transform.position.y + 0.15f;
            mx = whoObj.transform.position.x + 0.5f;
            mz = whoObj.transform.position.z - 0.5f;
            Instantiate(movep, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));//4
            my = whoObj.transform.position.y + 0.15f;
            mx = whoObj.transform.position.x;
            mz = whoObj.transform.position.z - 0.5f;
            Instantiate(movep, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));//5
            my = whoObj.transform.position.y + 0.15f;
            mx = whoObj.transform.position.x;
            mz = whoObj.transform.position.z + 0.5f;
            Instantiate(movep, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));//6
            my = whoObj.transform.position.y + 0.15f;
            mx = whoObj.transform.position.x - 0.5f;
            mz = whoObj.transform.position.z;
            Instantiate(movep, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));
            my = whoObj.transform.position.y + 0.15f;
            mx = whoObj.transform.position.x + 0.5f;
            mz = whoObj.transform.position.z;
            Instantiate(movep, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));
            if (fust == false)
            {
                Cas();
            }
            pOnOff = false;
        }
        if (moveObj == true)
        {            
            whoObj = cameracon.GetComponent<CON1>().tagetObj;
            my = transform.position.y;
            mx = whoObj.transform.position.x;
            mz = whoObj.transform.position.z;
            transform.position = new Vector3(mx, my, mz);
            moveObj = false;
            fust = true;
        }
    }
    public void Cas()
    {
        lcas = lck.GetComponent<Enemyck>().forObj;
        rcas = rck.GetComponent<Enemyck>().forObj;        
        if (lcas.gameObject.tag == "rook" || lcas.gameObject.tag == "brook")
        {
            if (lcas.GetComponent<Rook>().tun == false)
            {
                my = whoObj.transform.position.y + 0.15f;
                mx = whoObj.transform.position.x - 1f;
                mz = whoObj.transform.position.z;
                Instantiate(lcbox, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));
            }
        }
        if (rcas.gameObject.tag == "rook" || rcas.gameObject.tag == "brook")
        {
            if (rcas.GetComponent<Rook>().tun == false)
            {
                my = whoObj.transform.position.y + 0.15f;
                mx = whoObj.transform.position.x + 1f;
                mz = whoObj.transform.position.z;
                Instantiate(rcbox, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));
            }
        }
    }
}
