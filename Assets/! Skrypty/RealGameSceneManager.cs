using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealGameSceneManager : MonoBehaviour
{
    public GameObject[] coWylaczycNaStart;
    public GameObject[] coWlaczycNaStart;
    public float ileSekund;
    // kamera
    public GameObject Cam;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject item in coWlaczycNaStart)
        {
            item.SetActive(false);
        }
        foreach (GameObject item in coWylaczycNaStart)
        {
            item.SetActive(true);
        }
        StartCoroutine(NaStart());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator NaStart()
    {
        yield return new WaitForSeconds(ileSekund);
        foreach (GameObject item in coWylaczycNaStart)
        {
            item.SetActive(false);
        }
        foreach (GameObject item in coWlaczycNaStart)
        {
            item.SetActive(true);
        }
        Cam.SetActive(false);
    }
 }
