using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseUI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PauseMenu; 
    public bool isPaused;

	private void Awake()
    {
    }
    public void ExitGame(){
        Application.Quit();
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
    }    
    public void ResumeGame()
    {
		Cursor.lockState = CursorLockMode.Locked;
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    
    public void PauseGame()
    {
		Cursor.lockState = CursorLockMode.None;
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }    

    public void BackMenu(string menuScene)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(menuScene);
    }

}
