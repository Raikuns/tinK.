using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void BackGame()
    {
        SceneManager.LoadScene(0);
    }

    public void PlaySound()
    {
        FindObjectOfType<AudioManager>().Play("Button");
    }

    public void PlayMenuEerst()
    {
        FindObjectOfType<AudioManager>().Play("EersteSlide");
    }

    public void PlayMenuTweede()
    {
        FindObjectOfType<AudioManager>().Play("TweedeSlide");
    }

    public void PlayMenuDerde()
    {
        FindObjectOfType<AudioManager>().Play("DerdeSlide");
    }

    public void StopPlayDialoog()
    {
        FindObjectOfType<AudioManager>().StopPlay("EersteSlide");
        FindObjectOfType<AudioManager>().StopPlay("TweedeSlide");
        FindObjectOfType<AudioManager>().StopPlay("DerdeSlide");
    }
}
