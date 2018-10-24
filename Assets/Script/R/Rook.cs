using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rook : MonoBehaviour {
    public GameObject cameracon;//선택된 오브젝트
    public GameObject movep;//무브 박스
    public GameObject movep1;
    public GameObject movep2;
    public GameObject movep3;
    public GameObject selp;//선텍 인팩트
    public GameObject whoObj;//오브젝트를 담을곳
    //위치값정하기
    public float my;
    public float mx;
    public float mz;
    public bool pOnOff;//말 선택확인
    public bool moveObj;//말 움직임 확인
    public GameObject forObj;
    public bool csObj;
    public bool csObj1;
    public bool tun;
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
            mz = whoObj.transform.position.z + 0.5f;
            Instantiate(movep, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));
            my = whoObj.transform.position.y + 0.15f;
            mx = whoObj.transform.position.x;
            mz = whoObj.transform.position.z - 0.5f;
            Instantiate(movep1, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));
            my = whoObj.transform.position.y + 0.15f;
            mx = whoObj.transform.position.x - 0.5f;
            mz = whoObj.transform.position.z;
            Instantiate(movep2, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));
            my = whoObj.transform.position.y + 0.15f;
            mx = whoObj.transform.position.x + 0.5f;
            mz = whoObj.transform.position.z;
            Instantiate(movep3, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));
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
            tun = true;
        }
        if (csObj == true)
        {
            whoObj = cameracon.GetComponent<CON1>().tagetObj;
            my = transform.position.y;
            mx = whoObj.transform.position.x-0.5f;
            mz = whoObj.transform.position.z;
            transform.position = new Vector3(mx, my, mz);
            csObj = false;
        }
        if (csObj1 == true)
        {
            whoObj = cameracon.GetComponent<CON1>().tagetObj;
            my = transform.position.y;
            mx = whoObj.transform.position.x +0.5f;
            mz = whoObj.transform.position.z;
            transform.position = new Vector3(mx, my, mz);
            csObj1 = false;
        }
    }
}
