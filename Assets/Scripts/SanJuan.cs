using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SanJuan : MonoBehaviour {

    static public SanJuan S;

    [Header("Set in Inspector")]
    public TextAsset deckXML;

    [Header("Set Dynamically")]
    public Deck deck;

    void Awake()
    {
        S = this; //singleton for San Juan
    }

    // Use this for initialization
    void Start ()
    {
        deck = GetComponent<Deck>(); //get the deck
        deck.InitDeck(deckXML.text); //pass deckXML to it
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
