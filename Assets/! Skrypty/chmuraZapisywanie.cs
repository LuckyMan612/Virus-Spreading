using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chmuraZapisywanie : MonoBehaviour
{
    public GameObject komputer;
    public GameObject loading;
    public GameObject slider;
    public TextMeshProUGUI tekst;
    public List<string> teksty;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Rozpocznij()
    {
        komputer.SetActive(false);
        loading.SetActive(true);
        StartCoroutine(Wystartowano());
    }
    IEnumerator Wystartowano()
    {
        foreach (string t in teksty)
        {
            tekst.text = t;
            slider.GetComponent<Animator>().Play("SliderAnim");
            yield return new WaitForSeconds(3.5f);
        }
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(6);
    }
}
