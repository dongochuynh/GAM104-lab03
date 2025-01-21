using UnityEngine;

public class vari : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool IsSpinning;
    public float rotationSpeed = 90.0f;

    void Start()
    {
        IsSpinning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsSpinning)
        {
            transform.Rotate(90, 0, 0);
        }
    }
}


