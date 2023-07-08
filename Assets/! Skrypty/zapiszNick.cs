using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class zapiszNick : MonoBehaviour
{
    public TMP_InputField nick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Zapisz()
    {
        PlayerPrefs.SetString("nick", nick.text);
        PlayerPrefs.Save();
    }
}
