using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset; // Décalage
    // Update is called once per frame
    void Update()
    {
        offset = new Vector3(0, 3, 10);
        transform.position = player.position + offset;
    }
}