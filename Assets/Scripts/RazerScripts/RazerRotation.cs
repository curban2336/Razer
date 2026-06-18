using UnityEngine;

public class RazerRotation : MonoBehaviour
{
    [SerializeField] RazerStats stats;
    [SerializeField] float rotationSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rotationSpeed = 30 * stats.atk;
    }

    private void Update()
    {
        if(rotationSpeed < stats.atk * 30 || rotationSpeed > stats.atk * 30)
        {
            rotationSpeed = 30 * stats.atk;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(stats.rotation)
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
        else
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * -1);
        }
    }
}
