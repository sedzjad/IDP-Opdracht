using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessagePanel : MonoBehaviour
{

    public GameObject MessageText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenMessageText(string text)
    {
        MessageText.SetActive(true);
    }

    public void CloseMessageText()
    {
        MessageText.SetActive(false);
    }
}
