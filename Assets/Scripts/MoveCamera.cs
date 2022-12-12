using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform GameObject;
    public void toMercury()
    {
        GameObject.transform.position = new Vector3(0, 0, -14);
        GameObject.transform.eulerAngles = new Vector3(
            GameObject.transform.eulerAngles.x * 0,
            GameObject.transform.eulerAngles.y,
            GameObject.transform.eulerAngles.z);
    }
    public void toVenus()
    {
        GameObject.transform.position = new Vector3(0, 0, -17);
        GameObject.transform.eulerAngles = new Vector3(
            GameObject.transform.eulerAngles.x * 0,
            GameObject.transform.eulerAngles.y,
            GameObject.transform.eulerAngles.z);
    }
    public void toEarth()
    {
        GameObject.transform.position = new Vector3(0, 1, -22);
        GameObject.transform.eulerAngles = new Vector3(
            GameObject.transform.eulerAngles.x * 0 + 3,
            GameObject.transform.eulerAngles.y,
            GameObject.transform.eulerAngles.z);
    }
    public void toMars()
    {
        GameObject.transform.position = new Vector3(0, 3, -35);
        GameObject.transform.eulerAngles = new Vector3(
            GameObject.transform.eulerAngles.x * 0 + 13,
            GameObject.transform.eulerAngles.y,
            GameObject.transform.eulerAngles.z);
    }
    public void toJupiter()
    {
        GameObject.transform.position = new Vector3(0, 15, -85);
        GameObject.transform.eulerAngles = new Vector3(
            GameObject.transform.eulerAngles.x * 0 + 15,
            GameObject.transform.eulerAngles.y,
            GameObject.transform.eulerAngles.z);
    }
    public void toSaturn()
    {
        GameObject.transform.position = new Vector3(0, 30, -170);
        GameObject.transform.eulerAngles = new Vector3(
            GameObject.transform.eulerAngles.x * 0 + 19,
            GameObject.transform.eulerAngles.y,
            GameObject.transform.eulerAngles.z);
    }
    public void toUranus()
    {
        GameObject.transform.position = new Vector3(0, 40, -280);
        GameObject.transform.eulerAngles = new Vector3(
            GameObject.transform.eulerAngles.x * 0 + 17,
            GameObject.transform.eulerAngles.y,
            GameObject.transform.eulerAngles.z);
    }
    public void toWholeSystem()
    {
        GameObject.transform.position = new Vector3(0, 60, -300);
        GameObject.transform.eulerAngles = new Vector3(
            GameObject.transform.eulerAngles.x * 0 + 15,
            GameObject.transform.eulerAngles.y,
            GameObject.transform.eulerAngles.z);
    }
}
