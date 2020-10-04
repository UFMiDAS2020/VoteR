using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextWriter : MonoBehaviour
{

    private Text uiText;
    private string textToWrite;
    private float timePerCharacter;
    private int characterIndex;
    private float timer;

    public void AddWriter(Text uiText, string textToWrite, float timePerCharacter)
    {
        this.uiText = uiText;
        this.textToWrite = textToWrite;
        this.timePerCharacter = timePerCharacter;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(uiText != null)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                timer += timePerCharacter;
                characterIndex++;
                uiText.text = textToWrite.Substring(0, characterIndex);

                if (characterIndex >= textToWrite.Length)
                {
                    uiText = null;
                    return;
                }
            }
        }
    }
}
