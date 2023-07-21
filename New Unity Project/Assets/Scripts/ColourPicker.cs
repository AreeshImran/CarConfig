using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourPicker : MonoBehaviour
{
    public Material CarColour;
    public Renderer carRenderer;
    public GameObject Car;


    public void pickColour(Color Colour){
        Car = GameObject.FindWithTag("Car");
        carRenderer = Car.GetComponent<Renderer>();
        CarColour.color = Colour;
        carRenderer.material = CarColour;
        

    }
}
