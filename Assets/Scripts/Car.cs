using UnityEngine;

public class Car : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        if(transform.position.x <= -0.91f)
            transform.position = new Vector2(-0.91f,transform.position.y);
        if (transform.position.x >= 0.91f)
            transform.position = new Vector2(0.91f, transform.position.y);
    }


}
