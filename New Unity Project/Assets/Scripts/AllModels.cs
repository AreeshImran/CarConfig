using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AllModels : MonoBehaviour
{

    [SerializeField] public Button ViewAllModels;
    public GameObject panel;


    public void activatePanel(){
        panel.gameObject.SetActive(!panel.gameObject.activeSelf);
    }


}
