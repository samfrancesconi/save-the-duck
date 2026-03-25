using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Controller : MonoBehaviour
{
    [SerializeField] int speed;
    [SerializeField] GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Moove();
        Shoot();
    }

    void Moove()
    {
        float x = Input.GetAxis("Horizontal") * speed;
        float y = Input.GetAxis("Vertical") * speed;

        transform.position = new Vector2(
            transform.position.x + x * Time.deltaTime,
            transform.position.y + y * Time.deltaTime 
        );
    }

    void Shoot()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(bullet, (Vector2)transform.position, Quaternion.identity);
        }
    }
}
