using UnityEngine;

public class SimpleMoverBehavior : MonoBehaviour
{
    public float speed = 1.0f;
    public Transform target = null;
    private float foo = 0;
    private float bar = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //MARK PIL WUZ HERE
        foo = 69f; //nice
        bar = 420;
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
