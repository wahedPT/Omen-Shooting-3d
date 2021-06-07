using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    Text scorer;
    // Start is called before the first frame update
    void Start()
    {
        scorer = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scorer.text = "Score:" + scoreValue;
    }

}
