using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public CharacterController cc;
    private float speed = 5f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        transform.Translate(x * Time.deltaTime * speed, 0, y * Time.deltaTime * speed);
        //cc.Move(transform.forward * y * Time.deltaTime * 5);
    }
}
