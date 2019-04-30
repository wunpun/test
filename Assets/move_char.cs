using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_char : MonoBehaviour
{

    public void move() {
        transform.position = GameObject.Find("Cube").transform.position;

    }
}
