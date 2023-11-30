using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelSwapper : MonoBehaviour
{
    [SerializeField] Image[] cellsToBeCheckedColor;
    private bool levelCleared = false;
    // Start is called before the first frame update
    public GameObject panelHome;
    public GameObject panelExcel;
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
        
        
        if(!levelCleared){
        panelHome.SetActive(true);
        panelExcel.SetActive(false);
        }
        else
        {
            Debug.Log("Level Cleared");
        }
    }

    public void showExcelPanel()
    {
        panelExcel.SetActive(true);
        panelHome.SetActive(false);
    }
}
