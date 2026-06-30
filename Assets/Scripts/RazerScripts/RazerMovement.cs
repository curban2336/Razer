using UnityEngine;
using UnityEngine.Rendering;

public class RazerMovement : MonoBehaviour
{

    [SerializeField] RazerStats stats;

    float timeCounter = 0f;

    public float speed;
    public float width;
    public float height;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = stats.atk/2;
    }

    // Update is called once per frame
    void Update()
    {
        float x = 0f;
        float z = 0f;
        if (speed < stats.atk * 10 || speed > stats.atk * 10)
        {
            speed = stats.atk/2;
        }
        timeCounter += Time.deltaTime * speed;

        if(stats.rotation)
        {
            x = (Mathf.Sin(timeCounter) * width);
            z = (Mathf.Cos(timeCounter) * height);
        }
        else
        {
            x = (Mathf.Cos(timeCounter) * height);
            z = (Mathf.Sin(timeCounter) * width);
        }

        transform.position = new Vector3(x, transform.position.y, z);
    }
}
