using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class BirdController : MonoBehaviour
{
    public float speed = 1f;
    public float jumpForce = 3f;
    private Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        // Dokunma kontrolü
        if (Input.GetMouseButtonDown(0))
        {
            Jump();
        }

        transform.Translate(Vector2.right * speed * Time.deltaTime);
        Camera.main.transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void Jump()
    {
        // Yatay hýzý sýfýrla ve yukarý doðru bir kuvvet uygula
        rb.velocity = new Vector2(0, jumpForce);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            FindObjectOfType<GameDesign>().GameOver();
        }
        else if(other.gameObject.tag == "Scoring")
        {
            FindObjectOfType<GameDesign>().IncreaseScore();
        }
    }
}

