
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void startGame()
    {
        Debug.Log("Start");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
