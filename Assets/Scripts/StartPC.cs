using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartPC : MonoBehaviour
{
    
    // Start is called before the first frame update
    [SerializeField] float interactionDistance = 4;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (interactionDistance >= Vector2.Distance(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("PC Scene Started");
                SceneManager.LoadScene("LAPTOP SCREEN");
            }
        }
    }
}
