using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class Manager : MonoBehaviour
{
    public TextMeshProUGUI question_txt;
    public TextAsset question, answer;
    public TMP_InputField answerForQuestion;
    string[] questions;
    string[] answers;
    int firsLine = 0;
    int lastLine;
    int trueAnswer;
    void Start()
    {
        questions = question.text.Split("\n"[0]);
        answers = answer.text.Split("\n"[0]);
        AddQuestions(firsLine, lastLine);
    }

    // Update is called once per frame
    void AddQuestions(int first, int last)
    {
        question_txt.text = questions[first];
    }
}
