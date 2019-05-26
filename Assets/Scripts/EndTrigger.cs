using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class EndTrigger : MonoBehaviour
{
    public GameManager GM;

    void OnTriggerEnter()
    {
        GM.CompleteLevel();
    }

}
