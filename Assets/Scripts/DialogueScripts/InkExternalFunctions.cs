using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using Ink.Runtime;

public class InkExternalFunctions
{
	public GameObject temp;

	public void Bind(Story story)
	{
		story.BindExternalFunction("StartHostility", (bool activate) => StartHostility(activate));
		story.BindExternalFunction("StopHostility", (bool activate) => StopHostility(activate));
		//story.BindExternalFunction("StartQuest", (string questID) => StartQuest(questID));

	}

	public void Unbind(Story story)
	{
		story.UnbindExternalFunction("StartHostility");
		story.UnbindExternalFunction("StopHostility");
		//story.BindExternalFunction("StartQuest", (string questID) => StartQuest(questID));

	}

    private void StartHostility(bool activate)
	{
		//Debug.Log("Miracle");
		GameEventsManager.instance.dialogueEvents.StartHostility();
	}

    private void StopHostility(bool activate)
	{
		//Debug.Log("Miracle");
		GameEventsManager.instance.dialogueEvents.StopHostility();
	}
}
