using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinder : MonoBehaviour
{
    public Vector3 pozycjaNaStart;
    // Start is called before the first frame update
    void Start()
    {
        pozycjaNaStart = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, pozycjaNaStart.y, transform.position.z);
    }
}
