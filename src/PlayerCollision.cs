using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player") {
            if (SceneManager.GetActiveScene().name == "Scene1") {
                SceneManager.LoadScene("Scene2");
            }
            else {
                SceneManager.LoadScene("Scene1");
            }
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
