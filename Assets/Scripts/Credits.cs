using UnityEngine;
using UnityEngine.SceneManagement;
public class Credits : MonoBehaviour
{
    // I needed a screen at the end of my game to allow the player to quit or try again
    // to do so i made a seperate scene and added to buttons
    public void Quit()
    {
        Debug.Log("Quit"); // This is to test that it works in the unity editor
        Application.Quit();
    }

    public void TryAgain()
    {
        Debug.Log("Try Again"); //This is to test that it works in the unity editor
        SceneManager.LoadScene("Welcome"); //this is the opening scene
    }
   
}
