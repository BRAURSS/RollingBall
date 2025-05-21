using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement; // On gere les mouvement du player grace à cette propriété

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false; // On désacive les mouvement du player comme ça
        }
    }
}