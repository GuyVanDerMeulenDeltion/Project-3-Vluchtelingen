using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour {

    public List<GameObject> opslot = new List<GameObject>();
    public GameObject Sleutel1;
    public GameObject Sleutel2;
    public GameObject Sleutel3;

    void Start()
    {


    }


    void Update()
    {


    }

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == ("Sleutel1"))
        {
            Destroy(c.gameObject);
            opslot.Add(Sleutel1);
        }

        if (c.gameObject.tag == ("Sleutel2"))
        {
            Destroy(c.gameObject);
            opslot.Add(Sleutel2);
        }

        if (c.gameObject.tag == ("Sleutel3"))
        {
            Destroy(c.gameObject);
            opslot.Add(Sleutel3);
        }

        if (opslot[2] != null)
        {
            Destroy(GameObject.Find("Muur"));
        }
    }
}
