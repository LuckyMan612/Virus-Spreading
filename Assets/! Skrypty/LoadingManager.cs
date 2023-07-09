using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingManager : MonoBehaviour
{
    public GameObject przesunieciePrawo;
    public GameObject przesuniecieLewo;
    public float[] _lewo;
    public float[] _prawo;
    // Start is called before the first frame update
    void Start()
    {
        foreach (float t in _lewo)
        {
            StartCoroutine(lewo(t));
        }
        foreach (float t in _prawo)
        {
            StartCoroutine(prawo(t));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(3);
        }
    }
    IEnumerator lewo(float poJakimCzasie)
    {
        yield return new WaitForSeconds(poJakimCzasie);
        Instantiate(przesuniecieLewo);
    }
    IEnumerator prawo(float poJakimCzasie)
    {
        yield return new WaitForSeconds(poJakimCzasie);
        Instantiate(przesunieciePrawo);
    }

}
