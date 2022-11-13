using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public Rigidbody rb;
    public float forwardForce = 300f;
    public float sidewaysForce = 600f;
    // Update is called once per frame
    void FixedUpdate()
    {
     rb.AddForce(0, 0, forwardForce * Time.deltaTime);
     if(Input.GetKey("d")) {
      rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
     }
     if(Input.GetKey("a")) {
      rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
     }

     if(rb.position.y < -1f) {
      rb.velocity = Vector3.zero;
      rb.angularVelocity = Vector3.zero;
      FindObjectOfType<GameManager>().EndGame();
     }

    }
}
