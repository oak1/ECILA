using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class env_wallGenerator : MonoBehaviour {

    public GameObject Rock_Wall_2C_01;
    public GameObject Rock_Wall_2C_02;
    public GameObject Rock_Wall_2C_03;
    public GameObject Rock_Wall_2C_04;
    public GameObject Rock_Wall_2C_05;
    public GameObject Rock_Wall_2C_06;
    public GameObject Rock_Wall_2C_07;
    public GameObject FollowPoint;

    private Vector3 currentPosition;
    private GameObject lastRock;


    // Use this for initialization
    void Start () {
        currentPosition = FollowPoint.transform.forward;
        
	}
	
	// Update is called once per frame
	void Update () {

        //根据前一个Rock类型判断下一个Rock的中心坐标
        
	}

    //获取各种Rock的半长
    Vector3 GetRockHalfLength(GameObject Rock)
    {
        if (Rock == Rock_Wall_2C_01)
        {
            return new Vector3(0, 0, 0.8f);
        }
        else if (Rock == Rock_Wall_2C_02)
        {
            return new Vector3(0, 0, 1.6f);
        }
        else if (Rock == Rock_Wall_2C_03)
        {
            return new Vector3(0, 0, 1.1f);
        }
        else if (Rock == Rock_Wall_2C_04)
        {
            return new Vector3(0, 0, 1f);
        }
        else if (Rock == Rock_Wall_2C_05)
        {
            return new Vector3(0, 0, 1.7f);
        }
        else if (Rock == Rock_Wall_2C_06)
        {
            return new Vector3(0, 0, 1.5f);
        }
        else if (Rock == Rock_Wall_2C_07)
        {
            return new Vector3(0, 0, 5.9f);
        }
        else
        {
            return new Vector3(0, 0, 0);
        }
    }
}
