using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInfo : MonoBehaviour
{
  public void Show()
  {
      SceneManager.LoadScene("GameInfo");
  }

  public void Close()
  {
      SceneManager.LoadScene("MainMenu");
  }
}
