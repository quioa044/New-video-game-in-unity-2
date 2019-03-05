using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody rb;

    public float fowardForce = 2000f;
    public float sidewaysForce = 500f; 
    
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 200, 500);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Add a foward force
        rb.AddForce(0, 0, fowardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce* Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
