using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

	public float timing;
	public bool isPaused;
	public GameObject menu;

	void Start()
	{
	}

	void Update()
	{
		Time.timeScale = timing;
		if (Input.GetKeyDown(KeyCode.Escape) && isPaused == false)
		{
			isPaused = true;
		}
		else if (Input.GetKeyDown(KeyCode.Escape) && isPaused == true)
		{
			isPaused = false;
		}

		if (isPaused == true)
		{
			timing = 0;
			menu.SetActive(true);
		}
		else if (isPaused == false)
		{
			timing = 1;
			menu.SetActive(false);
		}
	}

	public void QuitButton()
	{
		Application.Quit();
	}
}
