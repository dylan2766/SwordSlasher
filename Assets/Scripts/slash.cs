using UnityEngine;
using UnityEngine.InputSystem;

public class slash : MonoBehaviour
{
    public Vector2 mousePos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePos;
        Debug.Log(mousePos);
    }
}
