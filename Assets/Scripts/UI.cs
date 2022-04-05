using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject InstruksiMenu; 
    public bool instruksi;
    public void ExitGame(){
        Application.Quit();
    }

    public void ChangeScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }

	private void Awake()
    {
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
    }    
    public void InstruksiOut()
    {
		Cursor.lockState = CursorLockMode.None;
        InstruksiMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    
    public void InstruksiIn()
    {
		Cursor.lockState = CursorLockMode.None;
        InstruksiMenu.SetActive(true);
        Time.timeScale = 0f;
    }    

}
