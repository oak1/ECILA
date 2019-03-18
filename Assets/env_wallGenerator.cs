using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class env_wallGenerator : MonoBehaviour {

    public Vector3 initialPosition;
    public GameObject initialRock;

    public GameObject Rock_Wall_2C_01;
    public GameObject Rock_Wall_2C_02;
    public GameObject Rock_Wall_2C_03;
    public GameObject Rock_Wall_2C_04;
    public GameObject Rock_Wall_2C_05;
    public GameObject Rock_Wall_2C_06;
    public GameObject Rock_Wall_2C_07;
    public GameObject FollowPoint;

    private Transform currentPosition;        //鲸鱼头部当前的坐标
    private Vector3 lastPosition;           //上一块生成的Rock的坐标
    private Transform nextPostion;            //下一块石头的坐标
    private GameObject lastRock;            //上一块生成的Rock


    // Use this for initialization
    void Start () {
        lastRock = initialRock;
        lastPosition = initialPosition;
        GameObject gameObject = GameObject.Instantiate(Rock_Wall_2C_01, initialPosition,initialRock.transform.rotation) as GameObject;
        //currentPosition = FollowPoint.transform;
        //lastPosition.position = initialPosition;

    }
	
	// Update is called once per frame
	void Update () {

        //GameObject gameObject = GameObject.Instantiate(Rock_Wall_2C_01, lastPosition, true) as GameObject;

        //根据前一个Rock类型判断下一个Rock的中心坐标

        if(lastRock != null)
        {
            lastPosition = lastRock.transform.position;
        }

        System.Random ran = new System.Random();
        int i = ran.Next(1, 8);
        GameObject nextRock;
        if (i == 1)
        {
            nextRock = GameObject.Instantiate(Rock_Wall_2C_01, lastPosition + GetRockHalfLength(Rock_Wall_2C_01) + GetRockHalfLength(lastRock), initialRock.transform.rotation);
        }
        else if(i == 2)
        {
            nextRock = GameObject.Instantiate(Rock_Wall_2C_02, lastPosition + GetRockHalfLength(Rock_Wall_2C_02) + GetRockHalfLength(lastRock), initialRock.transform.rotation);
        }
        else if (i == 3)
        {
            nextRock = GameObject.Instantiate(Rock_Wall_2C_03, lastPosition + GetRockHalfLength(Rock_Wall_2C_03) + GetRockHalfLength(lastRock), initialRock.transform.rotation);
        }
        else if (i == 4)
        {
            nextRock = GameObject.Instantiate(Rock_Wall_2C_04, lastPosition + GetRockHalfLength(Rock_Wall_2C_04) + GetRockHalfLength(lastRock), initialRock.transform.rotation);
        }
        else if (i == 5)
        {
            nextRock = GameObject.Instantiate(Rock_Wall_2C_05, lastPosition + GetRockHalfLength(Rock_Wall_2C_05) + GetRockHalfLength(lastRock), initialRock.transform.rotation);
        }
        else if (i == 6)
        {
            nextRock = GameObject.Instantiate(Rock_Wall_2C_06, lastPosition + GetRockHalfLength(Rock_Wall_2C_06) + GetRockHalfLength(lastRock), initialRock.transform.rotation);
        }
        else
        {
            nextRock = GameObject.Instantiate(Rock_Wall_2C_07, lastPosition + GetRockHalfLength(Rock_Wall_2C_07) + GetRockHalfLength(lastRock), initialRock.transform.rotation);
        }
        lastRock = nextRock;
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
