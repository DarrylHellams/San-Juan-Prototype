using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour {
    [Header("Set in Inspector")]
    public Sprite marketHall;
    public Sprite marketStand;
    public Sprite tradingPost;
    public Sprite well;
    public Sprite aqueduct;
    public Sprite cityHall;
    public Sprite quarry;
    public Sprite sugarMill;
    public Sprite indigoPlant;
    public Sprite cardBack;

    public GameObject prefabCard;
    public GameObject prefabSprite;

    [Header("Set Dynamically")]
    public PT_XMLReader xmlr;
    public List<string> cardNames;
    public List<Card> cards;
    public Transform deckAnchor;
    public Dictionary<string, Sprite> dictCards;

    //InitDeck is called by San Juan when it is ready
    public void InitDeck(string deckXMLText)
    {
        if(GameObject.Find("_Deck") == null)
        {
            GameObject anchorGO = new GameObject("_Deck");
            deckAnchor = anchorGO.transform;
        }

        dictCards = new Dictionary<string, Sprite>()
        {
            {"cards_0", marketHall  },
            {"cards_1", marketStand },
            {"cards_2", tradingPost },
            {"cards_3", well },
            {"cards_4", aqueduct },
            {"cards_5", cityHall },
            {"cards_6", quarry },
            {"cards_7", sugarMill },
            {"cards_8", indigoPlant }
        };

        ReadDeck(deckXMLText);

        MakeCards();
    }

    //ReadDeck parses the XML file passed to it into CardDefinitions
    public void ReadDeck(string deckXMLText)
    {
        xmlr = new PT_XMLReader();
        xmlr.Parse(deckXMLText);

        string s = "xml[0] decorator[0] ";
        s += "type=" + xmlr.xml["xml"][0]["decorator"][0].att("type");
        s += " x=" + xmlr.xml["xml"][0]["decorator"][0].att("x");
        s += " y=" + xmlr.xml["xml"][0]["decorator"][0].att("y");
        s += " scale=" + xmlr.xml["xml"][0]["decorator"][0].att("scale");
        //print(s);
    }

    public void MakeCards()
    {
        cardNames = new List<string>();
        string[] letters = new string[] { "cards_0", "cards_1", "cards_2", "cards_3", "cards_4", "cards_5", "cards_6" };
        foreach (string s in letters)
        {
            for (int i=0; i<3; i++)
            {
                cardNames.Add(s + (i + 1));
            }
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
