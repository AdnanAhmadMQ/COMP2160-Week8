using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float baseSpeed = 5.0f;
    [SerializeField] private float rotation = 60.0f;
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = baseSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0f, 0f, Input.GetAxis(InputAxes.Vertical)) * speed * Time.deltaTime);
        transform.Rotate(0,(rotation * Input.GetAxis(InputAxes.Horizontal)) * Time.deltaTime, 0f, Space.Self);
    }
}
