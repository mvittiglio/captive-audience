using UnityEngine;

public class SimpleWorldRotation : MonoBehaviour
{
    public Vector3 rotation;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 eulers = rotation * speed * Time.deltaTime;
        transform.Rotate(eulers, Space.World);    
    }
}
