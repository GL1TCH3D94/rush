using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnManager : MonoBehaviour {
    public GameObject canvas;

    public void NewgameBtn(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
    }
	public void ExitGameBtn()
    {
        Application.Quit();
    }
    public void Resume()
    {
        Time.timeScale = 1;
        canvas.SetActive(false);
            

    }
}
