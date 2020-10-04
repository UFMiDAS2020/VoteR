using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_Assistant : MonoBehaviour
{
    [SerializeField] private TextWriter textWriter;
    public Text messageText;
    int textSeg;

    public string[] textColl = new string[9];

    private void Awake()
    {
       
        textColl[0] = "Welcome to VoteR! \nThis simulation of the voting process will \n" +
                "help you be ready to place your vote on voting day! We will cover: \n" +
                "- How to place your vote in person \n" +
                "- What documentation you will need to vote \n" +
                "- How to stay safe while voting during COVID-19 \n" +
                "Look at the floating cube to progress. Try it now!";
        //messageText = transform.Find("message").Find("messageText").GetComponent<Text>();

        textColl[1] = "As you move forward in line, make sure to stay socially distanced by\n" +
            " keeping 6 feet away from the next person in line. Make sure to wear a mask to\n" +
            " the polls! You may be legally required to wear one in the voting location. ";

        textColl[2] = "In general, you will need at least one piece of valid, signed, photo\n" +
            " ID when you go to place your vote. Rules are different in every state,\n" +
            " so make sure to check with your local election supervisor if you have\n" +
            " any questions about this!";

        textColl[3] = "An election worker will be ready to verify your identification.\n" +
            " After that, they will provide you with your ballot!";

        textColl[4] = "MAKE SURE YOU READ AND UNDERSTAND YOUR BALLOT BEFORE FILLING IT OUT!\n " +
            "Filling the ballot out improperly WILL jeopardize your vote! If you have any\n " +
            "questions, MAKE SURE to ask an election worker!";

        textColl[5] = "You can familiarize yourself with a sample ballot before the election!\n" +
            " This is the best way to make sure you know what to do on voting day. Talk to your\n" +
            " local election supervisor if you want to obtain one!";

        textColl[6] = "Once you are SURE you understand your ballot, you will be asked to proceed\n" +
            " to a marked voting station. Go only to the station you are directed to and fill out your ballot!";

        textColl[7] = "After you have completely and properly filled out your ballot, place it in\n" +
            " the machine. Voting practices may be different in your location! The best way to be\n" +
            " sure is to reach out to your local election supervisor and request information!";

        textColl[8] = "Congratulations! You successfully cast your vote! \n" +
            "Voting is one of the most important things we can do to make a difference \n" +
            "in our society. Participating in Democracy helps everyone let their voice be\n" +
            " heard! Get out there and GO VOTE!" +
            "With love from VoteR! ";

    }
    // Start is called before the first frame update
    void Start()
    {
        //messageText.text = "Testing";
        textWriter.AddWriter(messageText, textColl[0], 0.1f);
        textSeg = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextText()
    {
        textWriter.AddWriter(messageText, textColl[textSeg], 0.05f);
        textSeg++;
    }
}
