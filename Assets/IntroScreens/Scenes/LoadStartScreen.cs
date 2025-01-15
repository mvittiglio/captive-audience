using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadStartScreen : MonoBehaviour
{
    public Transform target;
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

        if ((target.position - transform.position).magnitude <= 1.0f)
        {
            SceneManager.LoadScene(1);
        }
    }
}
