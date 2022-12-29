using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{
    public float speed;

    public float jumpForce = 10f;
    Rigidbody rb;

    private int woodCount = 0;
    private Canvas canvas;
    private UIManager manager;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        manager = FindObjectOfType<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal,0.0f,moveVertical);

        GetComponent<Rigidbody>().AddForce(movement*speed*Time.deltaTime);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);    
        }
    }

    public void updateWoodCount()
    {
        woodCount ++;
        manager.displayWoodCounter(woodCount);
    }
}
