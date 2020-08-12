using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(6f, 6f);
        //int xRand = Random.Range(0, 2);
        //Vector2 launchDir = new Vector2();

        //if (xRand == 0)
        //{
        //    launchDir.x = -5f;
        //}

        //    if (xRand == 1)
        //{
        //    launchDir.x = -5f; 
        //}

        //int yRand = Random.Range(0, 2);
        //if (yRand == 0)
        //{
        //    launchDir.y = -5f;
        //}

        //if (yRand == 1)
        //{
        //    launchDir.y = -5f;
        //}
        //rb.velocity = launchDir;
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);

        //if (collision.gameObject.name == "Player")
        //{
        //    rb.velocity = new Vector2(0, 13f/*, 0*/);
        //    float dist = this.transform.position.x - GameObject.Find("Player").transform.position.x;
        //    if (collision.gameObject.name == "Player")
        //    {
        //        this.GetComponent<Rigidbody>().velocity = new Vector2(dist * 5f, 5);
        //    }
        //}

        if (collision.gameObject.name == "Left_Bound")
        {
            float SpeedInYDirection = 0f;

            if (rb.velocity.y > 0)

                SpeedInYDirection = 8f;

            if (rb.velocity.y < 0)

                SpeedInYDirection = -8f;

            rb.velocity = new Vector2(5f, SpeedInYDirection/*, 0*/);
        }

        if (collision.gameObject.name == "Right_Bound")
        {
            float SpeedInYDirection = 0f;

            if (rb.velocity.y > 0)

                SpeedInYDirection = 8f;

            if (rb.velocity.y < 0)

                SpeedInYDirection = -8f;

            rb.velocity = new Vector2(-5f, SpeedInYDirection/*, 0*/);
        }

        if (collision.gameObject.name == "Upper_Bound")
        {
            float SpeedInXDirection = 0f;

            if (rb.velocity.x > 0)

                SpeedInXDirection = 8f;

            if (rb.velocity.x < 0)

                SpeedInXDirection = -8f;

            rb.velocity = new Vector2(SpeedInXDirection, -5f/*, 0*/);
        }

        if(collision.gameObject.name == "left")
        {
            float SpeedInXDirection = 0f;

            if (rb.velocity.x > 0)

                SpeedInXDirection = 8f;

            if (rb.velocity.x < 0)

                SpeedInXDirection = -8f;

            rb.velocity = new Vector2(SpeedInXDirection, 5f/*, 0*/);
        }

        if (collision.gameObject.name == "right")
        {
            float SpeedInXDirection = 0f;

            if (rb.velocity.x > 0)

                SpeedInXDirection = 8f;

            if (rb.velocity.x < 0)

                SpeedInXDirection = -8f;

            rb.velocity = new Vector2(SpeedInXDirection, 5f/*, 0*/);
        }
        if (collision.gameObject.name == "center")
        {
            //float SpeedInXDirection = 0f;

            //if (rb.velocity.x > 0)

            //    SpeedInXDirection = 8f;

            //if (rb.velocity.x < 0)

            //    SpeedInXDirection = -8f;

            rb.velocity = new Vector2(0, 5f/*, 0*/);
        }
        if (collision.gameObject.name == "childCenter")
        {
            //float SpeedInXDirection = 0f;

            //if (rb.velocity.x > 0)

            //    SpeedInXDirection = 8f;

            //if (rb.velocity.x < 0)

            //    SpeedInXDirection = -8f;

            rb.velocity = new Vector2(0, -5f/*, 0*/);
        }
    }
}
    //void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Debug.Log(collision.gameObject.name);

    //    if (collision.gameObject.name == "Player")
    //    {
    //        rb.velocity = new Vector3(0, 13f, 0);
    //        float dist = this.transform.position.x - GameObject.Find("Player").transform.position.x;
    //        if (collision.gameObject.name == "Player")
    //        {
    //            this.GetComponent<Rigidbody>().velocity = new Vector2(dist * 5f, 5);
    //        }
    //    }

    //    if (collision.gameObject.name == "Left_Bound")
    //    {
    //        float SpeedInYDirection = 0f;

    //        if (rb.velocity.y > 0)

    //            SpeedInYDirection = 8f;

    //        if (rb.velocity.y < 0)

    //            SpeedInYDirection = -8f;

    //        rb.velocity = new Vector3(5f, SpeedInYDirection, 0);
    //    }

    //    if (collision.gameObject.name == "Right_Bound")
    //    {
    //        float SpeedInYDirection = 0f;

    //        if (rb.velocity.y > 0)

    //            SpeedInYDirection = 8f;

    //        if (rb.velocity.y < 0)

    //            SpeedInYDirection = -8f;

    //        rb.velocity = new Vector3(-5f, SpeedInYDirection, 0);
    //    }

    //    if (collision.gameObject.name == "Upper_Bound")
    //    {
    //        float SpeedInXDirection = 0f;

    //        if (rb.velocity.x > 0)

    //            SpeedInXDirection = 8f;

    //        if (rb.velocity.x < 0)

    //            SpeedInXDirection = -8f;

    //        rb.velocity = new Vector3(SpeedInXDirection, -5f, 0);
    //    }
    //}








        //}
    //}

