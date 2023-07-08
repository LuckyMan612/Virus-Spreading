using Dan.Main;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zapiszLeaderboard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LeaderboardCreator.UploadNewEntry("d0ced8abd3dbbee4f7a8a3c671d137c4815d5cf71a36a0085b9b6430d73353af", PlayerPrefs.GetString("nick", ""), PlayerPrefs.GetInt("ktoryLevel", 1) + 1, Callback);
        PlayerPrefs.SetInt("ktoryLevel", PlayerPrefs.GetInt("ktoryLevel", 1) + 1);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Callback(bool success)
    {
        if (success)
        {

        }
    }
}
