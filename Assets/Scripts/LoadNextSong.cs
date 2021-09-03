using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class LoadNextSong : MonoBehaviour
{
	public void ChangeScene()
	{
		string sceneName = "Song ";
		string temp = SceneManager.GetActiveScene().name;
		string str = temp.Substring(temp.Length - 1);
		int num = Int32.Parse(str);
		num++;
		string incNum = num.ToString();
		sceneName += incNum;

		if (num >= 8)
		{
			SceneManager.LoadScene("SampleScene");
		}
		else
		{
			SceneManager.LoadScene(sceneName);
		}
	}

	public void PreviousScene()
    {
		string sceneName = "Song ";
		string temp = SceneManager.GetActiveScene().name;
		string str = temp.Substring(temp.Length - 1);
		int num = Int32.Parse(str);
		num--;
		string incNum = num.ToString();
		sceneName += incNum;

		if (num <1)
		{
			SceneManager.LoadScene("SampleScene");
		}
		else
		{
			SceneManager.LoadScene(sceneName);
		}
	}
}
