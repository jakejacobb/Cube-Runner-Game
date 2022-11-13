using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    public Rigidbody rb;

    void OnCollisionEnter(Collision collisionInfo) {
        if(collisionInfo.collider.tag == "Obstacle") {
            movement.enabled = false;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
