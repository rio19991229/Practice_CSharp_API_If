using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ji : MonoBehaviour {
    Animator myAnimator;
	// Use this for initialization
	void Start ()
    {
        myAnimator = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            myAnimator.SetTrigger("吃飯觸發器");
        }
        if (Input.GetKey(KeyCode.R))
        {
            myAnimator.SetBool("跑步開關", true);
        }
        else
        {
            myAnimator.SetBool("跑步開關",false);

        }

    }
}
