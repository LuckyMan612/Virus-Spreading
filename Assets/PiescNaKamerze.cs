using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiescNaKamerze : MonoBehaviour
{
    public bool czyPatrzec;
    public GameObject piesc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (czyPatrzec) transform.LookAt(piesc.transform);
    }
}
