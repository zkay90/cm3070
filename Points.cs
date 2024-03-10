using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Points : MonoBehaviour
{
    
    //Points counter
    public int points = 0;

    //Reference to the TMPro object displaying points
    public TextMeshProUGUI ptsText;

    //Timer for counting points every second
    private float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1.0f) {
            this.addPoints(1);
            timer = 0.0f;
        }
        ptsText.text = points.ToString();
        
    }

    public void addPoints(int pts)
    {
        points += pts;
    }
}
