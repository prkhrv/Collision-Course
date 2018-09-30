
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float ForwardForce = 4000f;
    public float SideForce = 500f;
    public float newForce = 0.1f;

	// Use this for initialization
	void Start () {

        
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        //Add a forward Force

        newForce = newForce + 0.01f;

        rb.AddForce(0, 0, ForwardForce * Time.deltaTime + newForce);


        if (Input.GetKey("d")){
            rb.AddForce(SideForce * Time.deltaTime , 0, 0, ForceMode.VelocityChange);

        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
