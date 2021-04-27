using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float moveForce = 1000f;
    public float sideWaysForce = 500f;


    // Start is called before the first frame update
    // Update is called once per frame
    
    void FixedUpdate()
    {
        rb.AddForce(0,0,moveForce * Time.deltaTime);

        if(Input.GetKey("d")){
            rb.AddForce(sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if( Input.GetKey("a")){
            rb.AddForce(-sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
            return;
        }
    }
}
