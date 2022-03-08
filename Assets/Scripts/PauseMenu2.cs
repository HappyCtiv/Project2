using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu2 : MonoBehaviour
{
    public static bool gameIsPaused = false;
  
	public KeyCode PauseKey = KeyCode.Escape;

    public GameObject pauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(PauseKey))
        {
            Debug.LogError("SUKABLYAT");
            if (gameIsPaused == true)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        gameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        gameIsPaused = true;
    }
}
