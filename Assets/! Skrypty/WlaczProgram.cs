using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WlaczProgram : MonoBehaviour
{
    public GameObject aplikacje;
    public GameObject fileExplorer;
    public GameObject steam;
    public GameObject chrome;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
        aplikacje.SetActive(false);
        steam.SetActive(false);
        chrome.SetActive(false);
        fileExplorer.SetActive(false);
    }
}
