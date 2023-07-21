using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourUI : MonoBehaviour
{
    public GameObject Car;
    public ColourPicker ColourPicker;
    
    // Start is called before the first frame update
    void Start()
    {
        Car = GameObject.FindWithTag("Car");
        ColourPicker = Car.GetComponent<ColourPicker>();


    }

    public void PickBlack(){
        ColourPicker.pickColour(Color.black);

    }

    public void PickGreen(){
        ColourPicker.pickColour(Color.green);

    }

    public void PickYellow(){
        ColourPicker.pickColour(Color.yellow);

    }

    public void PickCyan(){
        ColourPicker.pickColour(Color.cyan);

    }
}
