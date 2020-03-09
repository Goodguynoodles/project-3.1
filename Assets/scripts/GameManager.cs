using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Image questionImage;
    [SerializeField] private List<Question> questions;
    [SerializeField] private List<Question> hardq;
    [SerializeField] private List<Question> mediumq;
    [SerializeField] private InputField answerfield;
    
    private int goodAnswers;
    
    public Button easy;
    public Button medium;
    public Button hard;
    public GameObject background;
    public GameObject img;
    public GameObject start;
    public GameObject text;
    
    private bool kaas;
    private bool kees;
    private bool kuus;

    private int questionNumber;
    private int teste;
    private int HardNumber;

    public int hee = 5; 
        
    // Start is called before the first frame update
    void Start()
    {
        kaas = false;
        kuus = false;
        kees = false;
        teste = 0;
        HardNumber = 0;
        questionNumber = 0;
        questionImage.sprite = questions[questionNumber].picture;
        Debug.Log(questions[questionNumber].answer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void NextQuestion0()
    {
        questions.RemoveAt(questionNumber);
        questionNumber = Random.Range(0, questions.Count);
        questionImage.sprite = questions[questionNumber].picture;
        Debug.Log(questions[questionNumber].answer);
    }
    void NextQuestion1()
    {
        mediumq.RemoveAt(teste);
        teste = Random.Range(0, mediumq.Count);
        questionImage.sprite = mediumq[teste].picture;
        Debug.Log(mediumq[teste].answer);
    }
    void NextQuestion2()
    {
        hardq.RemoveAt(HardNumber);
        HardNumber = Random.Range(0, hardq.Count);
        questionImage.sprite = hardq[HardNumber].picture;
        Debug.Log(hardq[HardNumber].answer);
    }

    public void test0()
    {
        hee = 0;
        easy.gameObject.SetActive(false);
        medium.gameObject.SetActive(false);
        hard.gameObject.SetActive(false);
        img.gameObject.SetActive(true);
        background.gameObject.SetActive(true);
        start.gameObject.SetActive(false);
        text.gameObject.SetActive(true);
    }
    public void test1()
    {
        hee = 1;
        easy.gameObject.SetActive(false);
        medium.gameObject.SetActive(false);
        hard.gameObject.SetActive(false);
        img.gameObject.SetActive(true);
        background.gameObject.SetActive(true);
        start.gameObject.SetActive(false);
        text.gameObject.SetActive(true);
    }
    public void test2()
    {
        hee = 2;
        easy.gameObject.SetActive(false);
        medium.gameObject.SetActive(false);
        hard.gameObject.SetActive(false);
        img.gameObject.SetActive(true);
        background.gameObject.SetActive(true);
        start.gameObject.SetActive(false);
        text.gameObject.SetActive(true);
    }
    public void CheckAnswer()
    {
        if (answerfield.text == questions[questionNumber].answer && hee == 0)
        {
            Debug.Log("goed zo");
            NextQuestion0();
            kaas = true;
                                             answerfield.text = "";
        }
        else if (kaas)
        {
            Debug.Log("fout");
                        NextQuestion0();
                        answerfield.text = "";
                     
        }
        if (answerfield.text == mediumq[teste].answer && hee == 1)
        {
            Debug.Log("goed");
            NextQuestion1();
            answerfield.text = "";
            kees = true;
        }
        else if (kees)
        {
            Debug.Log("test");
            NextQuestion1();
            answerfield.text = "";
            
        }
        if (answerfield.text == hardq[HardNumber].answer && hee == 2)
        {
            Debug.Log("goed");
            NextQuestion2();
            answerfield.text = "";
            kuus = true;
        }
        else if (kuus)
        {
            Debug.Log("nee");
            NextQuestion2();
            answerfield.text = "";
           
        }
        
    }
    
}