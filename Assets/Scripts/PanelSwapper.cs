using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelSwapper : MonoBehaviour
{
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
        panelHome.SetActive(true);
        panelExcel.SetActive(false);
    }

    public void showExcelPanel()
    {
        panelExcel.SetActive(true);
        panelHome.SetActive(false);
    }
}
