using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LosowaTapeta : MonoBehaviour
{
    public Texture[] tapety;
    // Start is called before the first frame update
    void Start()
    {
        ustawTapete();
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void ustawTapete()
    {
        GetComponent<RawImage>().texture = tapety[Random.Range(0, tapety.Length)];
    }
}
