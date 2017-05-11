using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_script : MonoBehaviour {

    public void LoadPlay()
    {
        SceneManager.LoadScene("Play");
    }

	public void LoadHelp()
	{
		SceneManager.LoadScene ("Help");
	}

	public void LoadOptions()
	{
		SceneManager.LoadScene("Options");
	}


    public void LoadQuit()
    {
        SceneManager.LoadScene("Quit");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
