using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuManager : MonoBehaviour
{
    public GameObject nick;
    public GameObject graj;
    public bool oszukaj;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetString("nick", "null") == "null" && !oszukaj)
        {
            Debug.Log(PlayerPrefs.GetString("nick", "null"));
            nick.SetActive(true);
            graj.SetActive(false);
        }
        Debug.Log(PlayerPrefs.GetString("nick", "null"));
        if (oszukaj)
        {
            Debug.Log(PlayerPrefs.GetString("nick", "null"));
            nick.SetActive(true);
            graj.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
