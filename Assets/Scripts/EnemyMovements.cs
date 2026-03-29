using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovements : MonoBehaviour
{
    bool isTurning = false;

    void Update()
    {
        Moove();
        
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up, 1f);
        Debug.DrawRay(transform.position, transform.up * 4, Color.red);
        
        if (hit && !isTurning)
        {
            isTurning = true;
            transform.Rotate(0, 180f, 0);
        }
        else if (!hit)
        {
            isTurning = false;
        }
    }

    void Moove()
    {
        transform.position += transform.up * Time.deltaTime;
    }
}
