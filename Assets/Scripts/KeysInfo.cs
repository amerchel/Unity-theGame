using UnityEngine;
using UnityEngine.SceneManagement;

public class KeysInfo : MonoBehaviour
{
    public void Show()
    {
        SceneManager.LoadScene(4);
        Time.timeScale = 0;
    }

    public void Close()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
}
