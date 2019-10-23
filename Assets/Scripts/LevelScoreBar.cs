using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScoreBar : MonoBehaviour
{

    private Transform bar;
    // Start is called before the first frame update
    void Start()
    {
        bar = transform.Find("Bar");
        
    }

    public void setSize(float sizeNormalized)
    {
        bar.localScale = new Vector3(sizeNormalized, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
