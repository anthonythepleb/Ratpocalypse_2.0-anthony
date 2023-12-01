using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu_script : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject settingScreen;
    [SerializeField] private AudioSource MainMenuSFX;
    void Start(){
        MainMenuSFX.Play();
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void OpenSetting()
    {
        settingScreen.SetActive(true);
    }
    public void CloseSetting()
    {
        settingScreen.SetActive(false);
    }
    public void ExitGame()
    {
        Debug.Log("EXITTT!!!!!");
        Application.Quit();
    }

    public void Credits()
    {
        SceneManager.LoadScene(12);
    }
}
