
using UnityEngine;

    public class EndTrigger : MonoBehaviour
{
    public GameManager GM; // i realised that i couldn't make the end trigger work from this code so i referenced the gamemanager which contains the code.

    void OnTriggerEnter()
    {
        GM.CompleteLevel();// 'CompleteLevel' is a script inside of the game manager that triggers the the next level.
    }

}
