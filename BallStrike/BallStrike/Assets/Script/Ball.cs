using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Ball : MonoBehaviour
{
    public float Speed = 8f;
    public float cnt = 0;
    public GameManager gm;
    public AudioClip ping;
    public AudioClip thud;
    public AudioClip crack;
    public AudioClip dead;

    // Start is called before the first frame update
    private AudioSource sfx;

    
    void Start()
    {
        sfx = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (cnt == 0)
        {

            Respawn();
            cnt++;

        }
    }

    public void Respawn()
    {

        transform.position = new Vector2(-0.033f, -3.34f);

        GetComponent<Rigidbody2D>().velocity = Random.insideUnitSphere.normalized * Speed;
        Debug.Log(GetComponent<Rigidbody2D>().velocity);
    }

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "DeadBar")
        {
            FindObjectOfType<GameManager>().GameOver();
            sfx.clip = dead;
            sfx.Play();
        }
        if (collisionInfo.collider.tag == "Wall")
        {
            Speed += 0.2f;
            sfx.clip = thud;
            sfx.Play();
        }
        if (collisionInfo.collider.tag == "Paddle")
        {
            Speed += 0.2f;
            sfx.clip = thud;
            sfx.Play();
        }
        if (collisionInfo.collider.tag == "Brick")
        {
            sfx.clip = crack;
            sfx.Play();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Gem"))
        {
            sfx.clip = ping;
            sfx.Play();
            gm.UpdateScore();
            Destroy(collision.gameObject);
        }
    }


}
