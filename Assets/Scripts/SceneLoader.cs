using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] float waitSceneTime = 1.5f;
 
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void LoadGameOver()
    {
        StartCoroutine(LoadAfterTimer());
    }

    private IEnumerator LoadAfterTimer()
    {
   
        yield return new WaitForSeconds(waitSceneTime);

        SceneManager.LoadScene("GameOver");
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
            EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }


}
