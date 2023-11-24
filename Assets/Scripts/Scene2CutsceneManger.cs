using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2CutsceneManger : MonoBehaviour
{
    public NpcCharacteristics npc1;
    public NpcCharacteristics npc2;
    bool cutsceneStarted = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!cutsceneStarted && npc1.guidelineRead && npc2.guidelineRead && !npc1.dialogueManager.isActive && !npc2.dialogueManager.isActive) {
            cutsceneStarted = true;
            Debug.Log("Cutscene");
        }
    }
}
