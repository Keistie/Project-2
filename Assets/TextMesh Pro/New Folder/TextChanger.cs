using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextChanger : MonoBehaviour
{

    public enum Stages {Stage1, Stage2, Stage3}
    public Stages myStage = Stages.Stage1;

    [SerializeField]
    private TMP_Text mytext1; 
    public string newText1 = "Some New Text";

    private void Awake() {
        mytext1 = GetComponent<TMP_Text>();
    }
    // Start is called before the first frame update
    void Start()
    {
        //mytext1.text = "START";
       // mytext1.text = newText1;
    }

    void EnumChange() {
        switch (myStage) {

            case Stages.Stage1:
                mytext1.text = "Stage 1";
                myStage = Stages.Stage2;
                break;

            case Stages.Stage2:
                mytext1.text = "Stage 2";
                myStage = Stages.Stage3;
                break;

            case Stages.Stage3:
                mytext1.text = "Stage 3";
                myStage = Stages.Stage1;
                break;

        }

        /*
        if(myStage = Stages.Stage1) {
            mytext1 = "Stage 1";
            mystage = Stages.Stage2;
        }
        else if (myStage = Stages.Stage2) {
            mytext1 = "Stage 2";
            mystage = Stages.Stage3;
        }
        else if (myStage = Stages.Stage3){
            mytext1 = "Stage 3";
            mystage = Stages.Stage1;
        }
        */
    }
    // Update is called once per frame
    void Update()
    {
        EnumChange ();
        if (Input.GetKeyDown(KeyCode.Space)) {
            mytext1.text = "Press Space";

        }
    }
}
