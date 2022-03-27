using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class WordDisplay : MonoBehaviour
{
    public Text text;
    private Rigidbody2D rb;
    private BoxCollider2D bc;
    public float theta;
    float x;
    float y;
    double v = 1;

    public void SetWord( string word)
    {
        text.text = word;
    }

    public void RemoveLetter()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.red;
    }

    public void RemoveWord()
    {
        Destroy(gameObject);
    }

    private void changeV(double velocity, Rigidbody2D rb)
    {
        v = 1 / velocity;
        x = (float)rb.position[0];
        y = (float)rb.position[1];
        theta = (float)Math.Atan(x/y);
        if(y < 0)
        {
            rb.velocity = new Vector2((float)(Math.Sin(theta) / v), (float)(Math.Cos(theta) / v));
        }
        else{
            rb.velocity = new Vector2(-(float)(Math.Sin(theta) / v), -(float)(Math.Cos(theta) / v));
        }
    }

    private void ResizeColliders( BoxCollider2D bc, string text)
    {
        float xSize = (float)(text.Length * 10);

        bc.size = new Vector2(xSize, 20f);
    }

    private void Start()
    {
        bc = this.GetComponent<BoxCollider2D>();
        ResizeColliders(bc, text.text);
        rb = this.GetComponent<Rigidbody2D>();
        changeV(v, rb);

    }

    private void Update()
    {
        bc = this.GetComponent<BoxCollider2D>();
        ResizeColliders(bc, text.text);
        rb = this.GetComponent<Rigidbody2D>();
        changeV(v, rb);
    }

}
