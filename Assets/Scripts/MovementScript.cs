using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementScript : MonoBehaviour
{
    public float speed = 5f;

    public Slider slider;

    float t;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        Vector2 pos = transform.position;

        pos.x += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        pos.y += Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        transform.position = pos;

        if(pos.x >= 3 && pos.x <= 8 && pos.y >= -3 && pos.y <= 4)
        {
            slider.value = 1;
        }
        else
        {
            slider.value = 0;
        }
        
    }
}
