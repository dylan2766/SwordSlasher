using UnityEngine;
using UnityEngine.InputSystem;

public class slash : MonoBehaviour
{
    public Vector2 mousePos;

    //public bool collisionDetected = false;

    public int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePos;

        //if (collisionDetected == true)
        //{
        //    score = score + 20;
        //}

        if (Input.GetMouseButtonUp(0))
        {
            Destroy(gameObject);
        }
    }
    //public void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Debug.Log("This object has just collided with another.");
    //    collisionDetected = true;
    //}

    //public void OnCollisionStay2D(Collision2D collision)
    //{
    //    Debug.Log("This object is currently touching another.");
    //    collisionDetected = true;
    //}

    //public void OnCollisionExit2D(Collision2D collision)
    //{
    //    Debug.Log("This object has stopped colliding with another.");
    //    collisionDetected = false;
    //}
}
