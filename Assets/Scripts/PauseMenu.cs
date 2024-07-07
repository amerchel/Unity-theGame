using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public void PauseGame()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 0;
    }

    public void UnpauseGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void EndGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
