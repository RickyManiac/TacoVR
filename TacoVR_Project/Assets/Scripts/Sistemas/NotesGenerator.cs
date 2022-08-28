using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Taco
{
    public int type_Taco;
    public bool onion = false;
    public bool silantro = false;
    public int salsa;
}

public class NotesGenerator : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> notes;

    private List<Text> notes_text;



    // Start is called before the first frame update
    void Start()
    {
        //notes_text.Add(notes)
        //notes
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Taco CreateTaco()
    {
        Taco taco = new Taco();
        taco.type_Taco = Random.Range(0, 3);
        if(Random.Range(0, 1) != 0)
        {
            taco.onion =  true;
        }
        
        if(Random.Range(0, 1) != 0)
        {
            taco.silantro =  true;
        }
        taco.salsa = Random.Range(0, 2);

        return taco;
    }

    public string StringTaco(Taco t)
    {
        string stringTaco = "";
        switch(t.type_Taco)
        {
            case 0:
                stringTaco += "Bistek";
                break;
            case 1:
                stringTaco += "Chorizo";
                break;
            case 2:
                stringTaco += "Suadero";
                break;
            case 3:
                stringTaco += "Tripa";
                break;
        }

        if(t.onion)
        {
            stringTaco += ", cebolla";
        }

        if(t.silantro)
        {
            stringTaco += ", silantro";
        }

        switch(t.salsa)
        {
            case 1:
                stringTaco += ", salsa verde";
                break;
            case 2:
                stringTaco += ", salsa roja";
                break;
        }

        stringTaco += ".";

        return stringTaco;

    }
}
