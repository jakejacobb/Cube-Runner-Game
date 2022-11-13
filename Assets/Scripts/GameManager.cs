using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    bool gameHasEnded = false;

    public float restartDelay = 2f;

    public GameObject completeLevelUI;

    public PlayerMovement movement;

    public Rigidbody rb;

    public void CompleteLevel() {
        completeLevelUI.SetActive(true);
        movement.enabled = false;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }

    public void EndGame() {

        if(gameHasEnded == false) {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
