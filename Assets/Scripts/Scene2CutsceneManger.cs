using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Scene2CutsceneManger : MonoBehaviour
{
    public Canvas canvas;
    public NpcCharacteristics npc1;
    public NpcCharacteristics npc2;
    public bool cutsceneStarted = false;
    public bool cutsceneEnded = false;
    public PlayableDirector cutsceneDirector;
    public PlayerMovement playerMovement;
    // private float timeWhen2TaskOver;

    // Update is called once per frame
    private void Start()
    {
        canvas.enabled = false;
        playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    void Update()
    {
        if (!cutsceneStarted && npc1.guidelineRead && npc2.guidelineRead && !npc1.dialogueManager.isActive && !npc2.dialogueManager.isActive)
        {
            // timeWhen2TaskOver = TimeTillScene.GetTime();
            cutsceneStarted = true;
            StartCoroutine(StartCutscene());
        }
        
        // Debug.Log("Time: " + (TimeTillScene.GetTime() - timeWhen2TaskOver));
        
        // if (!cutsceneStarted && npc1.guidelineRead && npc2.guidelineRead && !npc1.dialogueManager.isActive && !npc2.dialogueManager.isActive && TimeTillScene.GetTime() - timeWhen2TaskOver > 4f)
        // {
        //     cutsceneStarted = true;
        //     StartCoroutine(StartCutscene());
        // }
    }

    IEnumerator StartCutscene()
    {
        yield return new WaitForSeconds(10f);
        Debug.Log("Cutscene");
        canvas.enabled = true;
        playerMovement.enabled = false;
        if (cutsceneDirector != null)
        {
            cutsceneDirector.Play();
        }
        yield return new WaitForSeconds((float)cutsceneDirector.duration);
        playerMovement.enabled = true;
        canvas.enabled = false;
        cutsceneEnded = true;
    }
}
