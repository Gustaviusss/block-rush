using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool hasEnded = false;
    public float restartDelay = 2f;
    public GameObject completeLevelUI;
    
    public void EndGame()
    {
        if (hasEnded == false)
        {
            hasEnded = true;
            Invoke("Restart", restartDelay);
            
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void WinLevel()
    {
        completeLevelUI.SetActive(true);
    }
}
