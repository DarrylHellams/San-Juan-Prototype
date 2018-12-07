using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour {

    [Header("Set Dynamically")]
    public string card;
    public List<GameObject> pipGOs = new List<GameObject>();

    public GameObject back;

    [System.Serializable] //a serializable class is able to be edited in the inspector

    public class Decorator
    {
        //this class stores information about each decorator or pip from DeckXML
        public string type;
        public Vector3 loc;
        public bool flip = false;
        public float scale = 1f;
    }

    [System.Serializable]
    public class CardDefinition
    {
        //this class stores information for each rank of card
        public string cardFace; //sprite to use for each card
        public List<Decorator> pips = new List<Decorator>();
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
