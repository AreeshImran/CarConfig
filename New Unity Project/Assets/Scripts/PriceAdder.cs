using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PriceAdder : MonoBehaviour
{
    public int price;
    public TextMeshProUGUI priceUI;
    [SerializeField] public Button prevCar;
    [SerializeField] public Button nextCar;
    public int initialPrice;
    public bool clicked = false;

    // Start is called before the first frame update
    void Start()
    {
        price = initialPrice;

        nextCar.onClick.AddListener(nextButtonCheck);
        prevCar.onClick.AddListener(prevButtonCheck);

    }

    void Update(){
        priceUI.text = price.ToString();
        if(clicked == true){
            price = initialPrice;
            clicked = false;
        }
        
    }

    public void nextButtonCheck(){
        clicked = true;
    }

    public void prevButtonCheck(){
        clicked = true;
    }

    public void blackPrice(){
        price = initialPrice;
        price = price + 200;


    }

    public void greenPrice(){
        price = initialPrice;
        price = price + 300;


    }

    public void yellowPrice(){
        price = initialPrice;
        price = price + 560;
        

    }

    public void cyanPrice(){
        price = initialPrice;
        price = price + 800;
        
    }


}
