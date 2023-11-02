using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class FindPartyMembers : MonoBehaviour
{

    public string myName = "Bjarke Vinberg Hansen";
    public int myNumber = 0;
    //Assignment from here
    //Input Parameter 1 is own name,input parameter 2 is where in the last my character would be added
    public void FindQuestMembers(string myName, int myNumber)
    {
        List<string> QuestPartyMembers = new List<string>()
        {
            "Grim the Barbarian",
            "Merlin the Wise",
            "Sterling the Knight"
        };

        QuestPartyMembers.Insert(myNumber, myName);
        Debug.LogFormat("Party Members: {0}", QuestPartyMembers.Count);


        // For Loop printing entire list of party members
        for (int i = 0; i < QuestPartyMembers.Count; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, QuestPartyMembers[i]);
        }

    }
    

    // Start is called before the first frame update
    //Start adds my own name in the desired place on the list using FindQuestMembers 
    void Start()
    {
        FindQuestMembers(myName, myNumber);

        Character hero = new Character();
        hero.PrintStatsInfo();       
        Character heroine = new Character("Cindy");
        heroine.PrintStatsInfo();

    }


   

    // Update is called once per frame
    void Update()
    {
        
    }
}
