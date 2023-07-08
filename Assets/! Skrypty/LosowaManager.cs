using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LosowaManager : MonoBehaviour
{
    public Slider sl;
    public TextMeshProUGUI pam;
    // Start is called before the first frame update
    void Start()
    {
        generujPamiec();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void generujPamiec()
    {
        int ileMaMiejsca = Random.Range(16, 126);
        sl.value = ileMaMiejsca;
        pam.text = sl.value.ToString() + " / 128 GB";
    }
}
