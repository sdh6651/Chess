using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour {

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
    void Update()
    {
        if (pOnOff == true)
        {
            Instantiate(selp, transform.position, transform.rotation);
            whoObj = cameracon.GetComponent<CON1>().tagetObj;
            my = whoObj.transform.position.y + 0.15f;
            mx = whoObj.transform.position.x + 0.5f;
            mz = whoObj.transform.position.z + 1f;
            Instantiate(movep, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));//1
            my = whoObj.transform.position.y + 0.15f;
            mx = whoObj.transform.position.x - 0.5f;
            mz = whoObj.transform.position.z + 1f;
            Instantiate(movep, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));//2
            my = whoObj.transform.position.y + 0.15f;
            mx = whoObj.transform.position.x - 1f;
            mz = whoObj.transform.position.z - 0.5f;
            Instantiate(movep, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));//3
            my = whoObj.transform.position.y + 0.15f;
            mx = whoObj.transform.position.x + 1f;
            mz = whoObj.transform.position.z - 0.5f;
            Instantiate(movep, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));//4
            my = whoObj.transform.position.y + 0.15f;
            mx = whoObj.transform.position.x + 1f;
            mz = whoObj.transform.position.z + 0.5f;
            Instantiate(movep, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));//5
            my = whoObj.transform.position.y + 0.15f;
            mx = whoObj.transform.position.x - 1f;
            mz = whoObj.transform.position.z + 0.5f;
            Instantiate(movep, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));//6
            my = whoObj.transform.position.y + 0.15f;
            mx = whoObj.transform.position.x - 0.5f;
            mz = whoObj.transform.position.z - 1f;
            Instantiate(movep, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));
            my = whoObj.transform.position.y + 0.15f;
            mx = whoObj.transform.position.x + 0.5f;
            mz = whoObj.transform.position.z - 1f;
            Instantiate(movep, new Vector3(mx, my, mz), Quaternion.Euler(0, 0, 0));
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
        }
    }
}