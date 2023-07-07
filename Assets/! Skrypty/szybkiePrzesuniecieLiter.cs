using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class szybkiePrzesuniecieLiter : MonoBehaviour
{
    public bool zniknij;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (zniknij) Zniknij();
    }
    public void Zniknij()
    {
        Destroy(gameObject);
    }
}
