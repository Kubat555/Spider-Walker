using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderController : MonoBehaviour
{
    [SerializeField] float speed = 3f;
    float direction;
    float rotation;

    private void Update()
    {
        direction = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.W)){
            Move(direction);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Move(direction);
        }

        if (Input.GetKey(KeyCode.A)){
            RotateSpider(rotation);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            RotateSpider(rotation);
        }

    }
    private void Move(float direction)
    {
        transform.Translate(Vector3.forward * direction * speed * Time.deltaTime);
    }

    private void RotateSpider(float rotation)
    {
        transform.Rotate(Vector3.up * rotation * 100 * Time.deltaTime);
    }
}
