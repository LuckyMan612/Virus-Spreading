using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class RealGameSceneManager : MonoBehaviour
{
    public GameObject[] coWylaczycNaStart;
    public GameObject[] coWlaczycNaStart;
    public float ileSekund;
    // kamera
    public GameObject Cam;
    // wyrzutnie
    public List<GameObject> wyrzutnie;
    // gracz
    public Transform player;
    [Header("Koniec mapy")]
    public GameObject piesc;
    public GameObject fps;
    public GameObject[] coUsunac;
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
        yield return new WaitForSeconds(3);

        StartCoroutine(WystrzalZWyrzutni());
    }
    IEnumerator WystrzalZWyrzutni()
    {
        yield return new WaitForSeconds(2);
        if (wyrzutnie.Count == 0)
        {
            piesc.GetComponent<Animator>().Play("zniszSciany");
            Cam.SetActive(true);
            Cam.GetComponent<PiescNaKamerze>().czyPatrzec = true;
            Cam.GetComponent<Camera>().clearFlags = CameraClearFlags.Skybox;
            fps.SetActive(false);
            foreach (GameObject item in coUsunac)
            {
                item.SetActive(false);
            }
            //SceneManager.LoadScene(4);
        }
        int wygenerowany = Random.Range(0, wyrzutnie.Count - 1);
        GameObject wylosowana = wyrzutnie[wygenerowany];
        GameObject child = wylosowana.transform.GetChild(1).gameObject;
        //child.GetComponent<Rigidbody>().AddForce(new Vector3(child.transform.position.x, child.transform.position.y - 150, -60000), ForceMode.Acceleration);
        child.GetComponent<NavMeshAgent>().SetDestination(player.transform.position);
        wyrzutnie.Remove(wylosowana);

        StartCoroutine(WystrzalZWyrzutni());
    }
 }
