using UnityEngine;

public class addCollision : MonoBehaviour
{
    public playerMovement movement;

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle") {
            movement.enabled = false;
            FindObjectOfType<gameManager>().EndGame();
            Debug.Log("HIT");
        }
    }
}
