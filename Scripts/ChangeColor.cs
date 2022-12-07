using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color[] color;
    public bool sprite;

// Start is called before the first frame update
    void Start()
    {
        int Num = Random.Range(0, color.Length);
        SpriteRenderer s = GetComponent<SpriteRenderer>();
        s.color = color[Num];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
