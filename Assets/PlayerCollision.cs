using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter()
    {
        Debug.Log("We hit something !"); // Affiche un log a chaque collision du Player
    }
}
