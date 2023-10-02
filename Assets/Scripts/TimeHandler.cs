using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TimeHandler : MonoBehaviour
{
    public float timeStamp = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (!(Time.time - timeStamp > 1)) return;
        timeStamp = Time.time;
        Debug.Log(timeStamp);
    }
}