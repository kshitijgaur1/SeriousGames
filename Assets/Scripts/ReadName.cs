using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReadName : MonoBehaviour
{
    public string platerName;

    public void readNameInput(string name)
    {
        platerName = name;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Intro Cutscene", LoadSceneMode.Single);
    }
}
