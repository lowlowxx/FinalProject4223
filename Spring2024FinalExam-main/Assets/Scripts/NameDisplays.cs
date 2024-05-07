using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameDisplays : MonoBehaviour
{

    private SaveNames saveNames;
    public Text nameText;


    // Start is called before the first frame update
    void Start()
    {
        saveNames = GameObject.Find("PlayerNames").GetComponent<SaveNames>();
        nameText.text = saveNames.playerName;
    }

    // Update is called once per frame
    void Update()
    {

    }



}