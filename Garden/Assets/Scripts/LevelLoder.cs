using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelLoder : MonoBehaviour
{
    int currentScreenIndex;
    [SerializeField] int timeToWait=4;
    // Start is called before the first frame update
    void Start()
    {
        currentScreenIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentScreenIndex == 0)
        {
            StartCoroutine(WaitForTime());
            
        }
    }
    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(timeToWait);
        LoadMeau();
    }
    public void LoadMeau()
    {
        SceneManager.LoadScene(1);
        //    SceneManager.LoadScene(currentScreenIndex + 1);
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(2);
    //    SceneManager.LoadScene(currentScreenIndex + 1);
    }
    
    public void LoadLoseScene()
    {
        SceneManager.LoadScene("Lose Screen");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
