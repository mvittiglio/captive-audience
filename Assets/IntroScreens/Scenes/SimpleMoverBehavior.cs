using UnityEngine;

public class SimpleMoverBehavior : MonoBehaviour
{
    public float speed = 1.0f;
    public Transform target = null;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            return;
        }

        Vector3 moveTo = target.position - transform.position;
        moveTo.Normalize();
        transform.position += moveTo * (speed * Time.deltaTime); 
    }
}
