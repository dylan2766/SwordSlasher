using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject slash;
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
        
        spawnSlash();
    }

    public void spawnSlash()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(slash, mousePos, Quaternion.identity);
        }
    }
}
