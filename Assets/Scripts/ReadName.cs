using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReadName : MonoBehaviour
{
    public static string playerName = "PlayerName";

    public void readNameInput(string name)
    {
        playerName = name;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Intro Cutscene", LoadSceneMode.Single);
    }
}
