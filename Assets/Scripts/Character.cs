using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public string name;

    public int exp = 0;


    public void PrintStatsInfo()
    {
        Debug.LogFormat("Hero: {0} - {1} EXP", name, exp);
    }

    public Character()
    {
        name = "Bonso";
    }

    public Character(string name)
    {
       this.name = name;
       
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }

    public class Wizard: Character
    {
        public Weapon weapon;

        public Wizard( string name, Weapon weapon): base(name, exp)
        {
            this.weapon = weapon;
        }
    }
}
