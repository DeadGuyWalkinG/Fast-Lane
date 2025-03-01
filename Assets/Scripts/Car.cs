using UnityEngine;

public class Car : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "LSL")
            transform.position = new Vector2(-0.91f, transform.position.y);
        if (collision.collider.tag == "LSR")
            transform.position = new Vector2(0.91f, transform.position.y);
    }
}
