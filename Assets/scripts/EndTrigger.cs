
using UnityEngine;

public class EndTrigger : MonoBehaviour {
    public Gamemanager gameManager;
    void OnTriggerEnter ()
    {
        gameManager.CompleteLevel();
    }


}
