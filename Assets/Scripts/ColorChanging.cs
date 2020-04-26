using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanging : MonoBehaviour
{
    private AudioSource Yamete;
    private Color originalColor;
    private Rigidbody rb;
    public Camera cam;
     public Texture2D textureToUse;
      public Texture2D textureToReturn;
    // Start is called before the first frame update
    void Start()
    {
        //Getting audio
        Yamete = gameObject.GetComponent<AudioSource>();
        //Establishing original color
        originalColor = gameObject.GetComponent<Renderer>().material.color;
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        //If an audio exists, play it
        if (Yamete)
            Yamete.Play();

        
    }
    //If the mouse is on, change color and texture
    private void OnMouseEnter()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.white;
        gameObject.GetComponent<Renderer>().material.mainTexture = textureToUse;
    }
    //Once the mouse is off, color and texture are restablished
    private void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().material.color = originalColor;
        gameObject.GetComponent<Renderer>().material.mainTexture = textureToReturn;

    }
}
