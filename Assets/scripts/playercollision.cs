using UnityEngine;

public class playercollision : MonoBehaviour {

    public playermovement movement;
    public Gamemanager gameManager;
     void OnCollisionEnter (Collision collisioninfo)
    {
        if(collisioninfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<Gamemanager>().EndGame();
        }


    }

}
