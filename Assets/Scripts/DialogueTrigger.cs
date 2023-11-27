using DefaultNamespace;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class DialogueTrigger : MonoBehaviour {

	public Message[] messages;
	public Message[] messages2;
	public Actor[] actors;
    // public bool taskDone=false;
    [FormerlySerializedAs("controller")] public UIControllerGuideline controllerGuideline;

    public void StartDialog()
    {
		NpcCharacteristics nc = GetComponent<NpcCharacteristics>();
		if (!nc.taskDone)
		{
			FindObjectOfType<DialogueManager>().OpenDialogue(messages, actors, nc);
		}
		else
		{
			if (!nc.guidelineRead)
			{
				FindObjectOfType<DialogueManager>().OpenDialogue(messages2, actors, nc);
            }
            else
			{
                controllerGuideline = FindObjectOfType<UIControllerGuideline>();
                controllerGuideline.ShowCanvas(nc);
            }
        }
    }

}

[System.Serializable]
public class Message
{
	public int actorId;
	public string message;
}

[System.Serializable]
public class Actor
{
	public string name;
	public Sprite sprite;
}
