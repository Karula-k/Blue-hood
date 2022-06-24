using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleport : MonoBehaviour
{
    public string scaneName;
    // Start is called before the first frame update
  /*  private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            SceneManager.LoadScene(scaneName);
        }
    }*/
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player") SceneManager.LoadScene(scaneName);
    }

}
