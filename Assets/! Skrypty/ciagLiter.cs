using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ciagLiter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(-0.2000008f, 0, -5555), ForceMode.Acceleration);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
