using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GridScript : MonoBehaviour
{
    public Button myButton;
    public TextMeshProUGUI buttonText;
    public string playerSide;
    private GameController myController;

    // Start is called before the first frame update
    void Start()
    {
        myButton = GetComponent<Button>();
        buttonText = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void SetSpace()
    {
        buttonText.text = myController.GetPlayerSide();
        myButton.interactable = false;
        myController.EndTurn();
    }

    public void SetController(GameController controller)
    {
        myController = controller;
    }
}
