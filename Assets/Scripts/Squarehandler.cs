using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2f;
    private Vector3 initial_position;
    private float platform_pos_x;
    private float platform_scale_x;
    public int coins_counter;
    void Start()
    {
        initial_position = transform.position;
        platform_pos_x = 300.0f;
        platform_scale_x = 450.0f;
        coins_counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        var hoz = System.Convert.ToInt32(Input.GetKey(KeyCode.D)) - System.Convert.ToInt32(Input.GetKey(KeyCode.A));
        var pos = transform.position;
        var scale = transform.localScale;
        transform.position = new Vector3(pos.x + (hoz * speed * Time.deltaTime), pos.y, pos.z);
        pos = transform.position;
        if (((pos.x - scale.x) < (platform_pos_x - platform_scale_x - 40)) || ((pos.x + scale.x) > (platform_pos_x + platform_scale_x + 40)))
        {
            transform.position = initial_position;
        }
    }
}
