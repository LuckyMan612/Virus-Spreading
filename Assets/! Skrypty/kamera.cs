using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kamera : MonoBehaviour
{
    public bool czyKoniec;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (czyKoniec) ZmienScene(3);
    }
    public void ZmienScene(int scena)
    {
        SceneManager.LoadScene(scena);
    }
}
