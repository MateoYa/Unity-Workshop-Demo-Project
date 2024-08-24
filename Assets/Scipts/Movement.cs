using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Movement : MonoBehaviour
{
    public float speed = 1;
    public float jumpforce = 100;
    public Rigidbody2D rb;
    public bool CanJump = true;
    public bool CanDash = true;
    public int rev = 1;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            if(rb.velocity.x > 0)
            {
                rb.velocity = new Vector2(0, rb.velocity.y);
            }
            rev = -1;
            
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            if (rb.velocity.x < 0)
            {
                rb.velocity = new Vector2(0, rb.velocity.y);
            }
            rev = 1;
        }
        if (Input.GetKeyDown(KeyCode.Space) && CanJump)
        {
            CanJump = false;
            CanDash = true;
            rb.AddForce(Vector2.up * jumpforce);

        }

        if (Input.GetKeyDown(KeyCode.E) && CanDash)
        {
            CanDash = false;
            StartCoroutine("EndDash");
            transform.localScale = new Vector3(1, 0.5f, 1);
            rb.gravityScale = 0;
            rb.AddForce(new Vector2(rev * jumpforce*2, 0));
            
            
            
        }


        if(transform.position.y <= -5.6)
        {
            SceneManager.LoadScene(0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            CanDash = true;
            CanJump = true;
        }
    }
    private IEnumerator EndDash()
    {
        yield return new WaitForSeconds(0.2f);
        transform.localScale = new Vector3(1, 1, 1);
        rb.velocity = new Vector2(0, rb.velocity.y);
        rb.gravityScale = 1;
    }

}
