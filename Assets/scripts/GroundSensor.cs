using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    public bool isGrounded;

    void OnTriggerEnter2D(Collider2D collision)

    {
        if(collision.gameObject.layer == 6)
        {
            isGrounded = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)

    {
        if(collision.gameObject.layer == 6)
        {
            isGrounded = false;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
