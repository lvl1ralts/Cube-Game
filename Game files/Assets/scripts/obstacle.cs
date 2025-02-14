
using UnityEngine;

public class obstacle : MonoBehaviour
{
    public Player1BehaviourScript movement;

    void OnCollisionEnter (Collision collisioninfo)
    {
        if(collisioninfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit an Obstacle!");
            movement.enabled = false;
            FindObjectOfType<GameManager>().Endgame();
            
        }
    }
}
