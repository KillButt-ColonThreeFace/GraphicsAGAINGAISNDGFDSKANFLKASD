using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody a;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        a = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            a.AddForce(new Vector3(-10, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            a.AddForce(new Vector3(10, 0));
        }
    }
}
