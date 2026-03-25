using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBinding : MonoBehaviour
{
    [SerializeField] GameObject sprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Vector2 distance = sprite.transform.position - transform.position;
       
       if(distance.magnitude > 0.5)
        {
            Vector2 direction = distance.normalized;
            transform.position = new Vector3(
                transform.position.x + direction.x * 3 * Time.deltaTime,
                transform.position.y + direction.y * 3 * Time.deltaTime,
                transform.position.z 
            );
        } 
    }
}
