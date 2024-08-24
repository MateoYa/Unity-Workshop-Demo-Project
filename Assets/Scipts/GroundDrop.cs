using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDrop : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool IsDrop = true;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine("WaitFall");
    }
    private IEnumerator WaitFall()
    {
        yield return new WaitForSeconds(2);
        Debug.Log("Waited a second");
        if (IsDrop)
        {
            rb.gravityScale = 1;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
