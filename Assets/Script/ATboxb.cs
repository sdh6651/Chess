using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATboxb : MonoBehaviour
{    
        GameObject con;
        public bool despoint;
        public GameObject inObj;
        public GameObject ineObj;
        void Start()
        {
            con = GameObject.Find("Main Camera");
            despoint = false;
        }
        void Update()
        {
            despoint = con.GetComponent<CON1>().tep;
            if (despoint == true)
            {
                Destroy(gameObject, 1f);
            }
        }

        private void OnTriggerEnter(Collider col)
        {
            if (col.gameObject.tag == "enemy")
            {
                ineObj = col.gameObject;
            }
        }
        public void Delete()
        {
            Destroy(ineObj);
        }
}

