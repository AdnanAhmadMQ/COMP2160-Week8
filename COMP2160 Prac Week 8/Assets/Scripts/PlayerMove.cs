using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float setSpeed = 5.0f;
    private float speed;
    [SerializeField] private float rotation = 60.0f;
    // Start is called before the first frame update
    void Start()
    {
        speed = setSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0,0,Input.GetAxis(InputAxes.Vertical)) * speed * Time.deltaTime);
        transform.Rotate(0,(rotation * Input.GetAxis(InputAxes.Horizontal))*Time.deltaTime,0,Space.Self);
    }
}
