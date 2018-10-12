using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere : MonoBehaviour {

    protected Joystick joystick;
    protected Joybutton joybutton;
    protected bool jump;
    // Use this for initialization
    void Start () {
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<Joybutton>();
	}
	
	// Update is called once per frame
	void Update () {
		
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3( joystick.Horizontal * 10f /*+ Input.GetAxis("Horizontal")*10f*/,
                                          rigidbody.velocity.y,
                                          joystick.Vertical * 10f);
        if(!jump && joybutton.pressed )
        {
            jump = true;
            rigidbody.velocity += Vector3.up * 10f;
        }
        if (jump && !joybutton.pressed)
        {
            jump = false;
        }
	}
}
