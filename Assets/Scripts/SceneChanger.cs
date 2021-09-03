﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
	public static void ChangeScene(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
	}
	public void Exit()
	{
		Application.Quit();
	}

	public static void GoBack()
    {
		SceneManager.LoadScene("SampleScene");
    }
}