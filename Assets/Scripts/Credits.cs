using UnityEngine;
using UnityEngine.SceneManagement;
public class Credits : MonoBehaviour
{

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void TryAgain()
    {
        Debug.Log("Try Again");
        SceneManager.LoadScene("Welcome");
    }
   
}
