using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class piescColider : MonoBehaviour
{
    public bool sciana1;
    public bool sciana2;
    public bool podloga;
    public bool czyKoniec;
    public GameObject _sciana1;
    public GameObject _sciana2;
    public GameObject _podloga;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (sciana1) _sciana1.GetComponent<Animator>().Play("sciana1");
        if (sciana2) _sciana2.GetComponent<Animator>().Play("sciana2");
        if (podloga) _podloga.GetComponent<Animator>().Play("podloag");
        if (czyKoniec) StartCoroutine(Koniec());
        sciana1 = false;
        sciana2 = false;
        podloga = false;
    }
    IEnumerator Koniec()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(4);
    }

}
