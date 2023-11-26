using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    // Start is called before the first frame update
    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }
    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
    }
}
