using UnityEngine;
using System.Collections;
public class BallJump : MonoBehaviour
{
    public float speedLimit = 2f;
    Rigidbody rb;
    Renderer rend;
    Color originalColor;

    IEnumerator Start()
    {
        rb = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;

        rb.linearVelocity = Vector3.up * 6; 
        

        while (true)
        {
            do { yield return null; }
            while (rb.linearVelocity.magnitude > speedLimit);

            float time = Time.time;
            rend.material.color = Color.red;

            do { yield return null; }
            while (rb.linearVelocity.magnitude > speedLimit);

            rend.material.color = originalColor;
            Debug.Log("Время: " + (Time.time - time));




        }
    }

    void OnCollisionEnter(Collision collision)
    {
        rb.linearVelocity = Vector3.up * 6;
    }

}
