using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Scene2CutsceneManger : MonoBehaviour
{
    public Canvas canvas;
    public NpcCharacteristics npc1;
    public NpcCharacteristics npc2;
    bool cutsceneStarted = false;
    public PlayableDirector cutsceneDirector;

    // Update is called once per frame
    private void Start()
    {
        canvas.enabled = false;
    }

    void Update()
    {
        if (!cutsceneStarted && npc1.guidelineRead && npc2.guidelineRead && !npc1.dialogueManager.isActive && !npc2.dialogueManager.isActive) {
            cutsceneStarted = true;
            StartCoroutine(StartCutscene());
        }
    }

    IEnumerator StartCutscene()
    {
        Debug.Log("Cutscene");
        canvas.enabled = true;
        if (cutsceneDirector != null)
        {
            cutsceneDirector.Play();
        }
        yield return new WaitForSeconds((float)cutsceneDirector.duration);
        canvas.enabled = false;
    }
}
