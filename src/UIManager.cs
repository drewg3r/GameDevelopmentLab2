using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Text txt;

    private string textStart = "Go to woods and collect 5 pieces of wood";

    // Start is called before the first frame update
    void Start()
    {
     txt = GetComponent<Text>();
     txt.text = textStart;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void displayWoodCounter(int woodCounter)
    {
        if (woodCounter < 5)
        {
            txt.text = textStart + "\nCollected: " + woodCounter;
        }
        else
        {
          txt.text = "You did it!";
        }
    }
}
