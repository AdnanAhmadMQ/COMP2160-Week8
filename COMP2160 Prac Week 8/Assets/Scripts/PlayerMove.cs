using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float baseSpeed = 5.0f;
    [SerializeField] private float rotation = 60.0f;
    private float speed;
    private string playerID;

    // Start is called before the first frame update
    void Start()
    {
        speed = baseSpeed;
        
        if (this.gameObject.tag == "Player1")
        {
            playerID = "1";
        }
        else
        {
            playerID = "2";
        }
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(new Vector3(0f, 0f, Input.GetAxis(InputAxes.Vertical + playerID)) * speed * Time.deltaTime);
        this.transform.Rotate(0, (rotation * Input.GetAxis(InputAxes.Horizontal + playerID)) * Time.deltaTime, 0f, Space.Self);
    }
}
