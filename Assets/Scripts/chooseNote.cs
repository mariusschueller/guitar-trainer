using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chooseNote : MonoBehaviour
{
    //int maxNotes = 12;

    string[] notes = { "C", "C#/Db", "D", "D#/Eb", "E", "F", "F#/Gb", "G", "G#/Ab", "A", "A#/Bb", "B" };
    string correctNote = "";
    int amountPicked = 0;
    int score = 0;
    public Text scoreText;

    public Text noteText;

    public GameObject eLowString;
    public GameObject aString;
    public GameObject dString;
    public GameObject gString;
    public GameObject bString;
    public GameObject eHighString;

    // Start is called before the first frame update
    void Start()
    {
        pickNote();
    }

    public void pickNote()
    {
        int noteNum = Random.Range(0, notes.Length);
        correctNote = notes[noteNum];

        noteText.text = correctNote;

        amountPicked = 0;

        turnOnStrings();
    }



    public void checkNote(string stringNote)
    {
        ++amountPicked;
        //check if note is correct
        if (correctNote == stringNote)
        {
            //do correct stuff
            ++score;
        }
        else
        {
            //incorrect stuff
            Debug.Log("wrong note picked");
            --score;
        }
        scoreText.text = "Score: " + score;

        if (amountPicked >= 6)
        {
            Invoke("pickNote", .1f);
        }
    }

    

    public void offString(int num)
    {
        if (num == 0)
        {
            eLowString.SetActive(false);
        }
        else if (num == 1)
        {
            aString.SetActive(false);
        }
        else if (num == 2)
        {
            dString.SetActive(false);
        }
        else if (num == 3)
        {
            gString.SetActive(false);
        }
        else if (num == 4)
        {
            bString.SetActive(false);
        }
        else if (num == 5)
        {
            eHighString.SetActive(false);
        }
        else
        {
            Debug.Log("error with string off");
        }
    }

    private void turnOnStrings()
    {
        eLowString.SetActive(true);
        aString.SetActive(true);
        dString.SetActive(true);
        gString.SetActive(true);
        bString.SetActive(true);
        eHighString.SetActive(true);
    }
}
