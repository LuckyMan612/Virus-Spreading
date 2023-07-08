using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WlaczProgram : MonoBehaviour
{
    public GameObject aplikacje;
    public GameObject fileExplorer;
    public GameObject steam;
    public GameObject chrome;
    public AudioSource klik;
    public AudioSource mouse_click;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetMouseClick();
    }
    public void wlaczProgram(string program)
    {
        if (!aplikacje.activeInHierarchy)
        {
            if (program == "File Explorer")
            {
                fileExplorer.SetActive(true);
                aplikacje.SetActive(true);
            }
            if (program == "Steam")
            {
                steam.SetActive(true);
                aplikacje.SetActive(true);
            }
            if (program == "Chrome")
            {
                chrome.SetActive(true);
                aplikacje.SetActive(true);
            }
        }

    }
    public void zamknijProgram()
    {
        klik.Play();
        aplikacje.SetActive(false);
        steam.SetActive(false);
        chrome.SetActive(false);
        fileExplorer.SetActive(false);
    }

    void GetMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouse_click.Play();
        }
    }
}
