using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whale_jointmotion : MonoBehaviour {

    public GameObject parentJoint;

    public float velocity = 1;
	
    private Vector3 parentToThis;

    // Use this for initialization
    void Start () {
        parentToThis = -parentJoint.transform.position + this.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.position = Vector3.Lerp(this.transform.position, parentJoint.transform.position + parentToThis, Time.deltaTime * velocity);
    }
}
