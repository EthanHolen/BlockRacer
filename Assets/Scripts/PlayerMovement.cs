using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float ForwardForce = 4000f;

    public float SidewaysForce = 60f;

    // Update is called once per frame
    void FixedUpdate () {
        rb.AddForce (0 , 0, ForwardForce * Time.deltaTime);
        //rb.AddForce (SidewaysForce * Time.deltaTime, 0, 0);

        if (Input.GetKey ("a")) {
            rb.AddForce (-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey ("d")) {
            rb.AddForce (SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}