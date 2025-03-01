using System.Collections;
using UnityEngine;

public class ControlButtons : MonoBehaviour
{
    [SerializeField] private GameObject car;
    [SerializeField] private float speed = 10f;
    
    void Update()
    {
        
    }

    [ContextMenu("Move Left")]
    public void leftButton()
    {

        StartCoroutine(changeLeft());
    }

    public void brake()
    {
    }

    [ContextMenu("Move Right")]
    public void rightButton()
    {
        StartCoroutine(changeRight());
    }

    IEnumerator changeLeft()
    { 
        while(car.transform.position.x > -0.91f)
        {
            car.transform.Translate(Vector2.left * speed * Time.deltaTime);
            yield return null;
        }
    }

    IEnumerator changeRight()
    {
        while (car.transform.position.x < 0.91f)
        {
            car.transform.Translate(Vector2.right * speed * Time.deltaTime);
            yield return null;
        }
    }
}
