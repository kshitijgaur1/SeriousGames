using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PanelSwapper : MonoBehaviour
{
    [SerializeField] Image[] cellsToBeCheckedColor;
    private bool levelCleared = false;
    // Start is called before the first frame update
    public GameObject panelHome;
    public GameObject panelExcel;
    public string str1, str2;
    [SerializeField]UIControllerGuideline uIControllerGuideline;
    void Start()
    {
        panelHome.SetActive(true);
        panelExcel.SetActive(false);
    }

    public void showHomePanel()
    {
        for(int index = 0; index < cellsToBeCheckedColor.Length; index++)
        {
            if(cellsToBeCheckedColor[index].color != new Color(0.38f, 1f, 0.7f))
            {
                levelCleared = false;
                break;
            }
            levelCleared = true;
        }
        
            panelHome.SetActive(true);
            panelExcel.SetActive(false);
        
        if(levelCleared) {
            Debug.Log("Level Cleared");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            uIControllerGuideline.ShowCanvas(str1, str2);
        }
    }

    public void showExcelPanel()
    {
        panelExcel.SetActive(true);
        panelHome.SetActive(false);
    }

    public void NextSceneLoader()
    {
        SceneManager.LoadScene("End Scene", LoadSceneMode.Single);
    }
}
