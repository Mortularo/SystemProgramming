using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(MoveUpCor(3, Vector3.up));  
    }

    IEnumerator MoveUpCor(int time, Vector3 direction)
    {
        while (transform.position.y <= 10)
        {
            yield return new WaitForSeconds(time);
            transform.position += direction;
        }
    }
}
