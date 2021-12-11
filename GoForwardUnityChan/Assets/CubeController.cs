using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private float speed = -12;

    private float groundLevel = -3.0f;

    private float deadLine = -10;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }

        bool isGround = (transform.position.y > this.groundLevel) ? false : true;

        GetComponent<AudioSource>().volume = (isGround) ? 1 : 0;
    }
        void OnCollisionEnter(Collision col)
        {
            if (col.gameObject.tag == "CobeTag")
                GetComponent<AudioSource>().Play();

        }
    }     
