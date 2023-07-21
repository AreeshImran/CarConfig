using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selection : MonoBehaviour
{
    private int activeCar;
    [SerializeField] private Button prevCar;
    [SerializeField] private Button nextCar;

    private void Awake(){
        CarSelect(0);
    }

    private void CarSelect(int var){

        prevCar.interactable = (var != 0);
        nextCar.interactable = (var != transform.childCount-1);
        for(int i = 0; i < transform.childCount; i++){
            transform.GetChild(i).gameObject.SetActive(i == var);
        }
    }

    public void CarChanger(int carChange){
        activeCar+= carChange;
        CarSelect(activeCar);
    }

}
