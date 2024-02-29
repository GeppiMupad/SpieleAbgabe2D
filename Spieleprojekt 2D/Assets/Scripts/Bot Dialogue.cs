using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotDialogue : MonoBehaviour
{
    [SerializeField] private GameObject BotgO;        // Parent object of Dialogue Canvas ( necessary for DontDestroyOnLoad()
  
    [SerializeField] private GameObject DialogueCanvasgO; //if active, then Conversation has started
    [SerializeField] private GameObject QuestionCanvasgO; //if active, then Buttons ( questions ) are shown

    [SerializeField] private GameObject EgO;   // shows if Bot is in range to interact
    [SerializeField] private Rigidbody2D PlayerRB;

    [SerializeField] private AudioClip DialogueClip;
    public static AudioSource DialogueAudio;

    public static bool exitButton = false; // if player press exit button, leave convo


    private bool canTalk = false;   // if true, player can press E to talk with bot
    private bool repeat = false;   // if player has talked once to bot, then = true and repeat first sentence



    private int showCanvasIndex = 0; // if player is talking to one bot , set it to 1 ( if values get changed, script asks if this index of the bot is = 1 )


    private void Awake()
    {
        DontDestroyOnLoad(BotgO);  // dont destroy the bot with canvas etc
        
    }
    private void Start()
    {
        DialogueAudio = GetComponent<AudioSource>();
        DialogueInput.QuestionEvent += ManageQuestions;

        ButtonManager.Managecanvas += ManageQuestions;   
        ButtonManager.OnClickExit += GetDefaultSetUp;
    }
    void Update()
    {

       
        if (Input.GetKeyDown(KeyCode.E) && canTalk == true)
        {
            DialogueAudio.PlayOneShot(DialogueClip, 0.7f);
            showCanvasIndex = 1; 

            if(repeat == true)
            {
                DialogueInput.repeat = true; // say same text, bot said at the very beginning
                repeat = false;
            }

            
            PlayerRB.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
            PlayerController.isPlayerFrozen = true;
            DialogueCanvasgO.SetActive(true);
            
            
        }

        else if(Input.GetKeyDown(KeyCode.Escape) && canTalk == true || exitButton == true)
        {
            exitButton = false;

            PlayerRB.constraints = RigidbodyConstraints2D.None;        
            PlayerRB.constraints = RigidbodyConstraints2D.FreezeRotation;
            PlayerController.isPlayerFrozen = false;
            DialogueCanvasgO.SetActive(false);
            QuestionCanvasgO.SetActive(false);         
        }
    }

    private void ManageQuestions()
    {
        if (showCanvasIndex == 1)
        {
            
            QuestionCanvasgO.SetActive(true);
            
        }
        if (DialogueInput.i == 1 || DialogueInput.i == 2 || DialogueInput.i == 3) // if a button ( question ) got pressed
        {
            
            DialogueAudio.PlayOneShot(DialogueClip, 0.7f);
            QuestionCanvasgO.SetActive(false);
        }
    }

    private void GetDefaultSetUp()
    {
        repeat = true;
        showCanvasIndex = 0;
        DialogueCanvasgO.SetActive(false);
        QuestionCanvasgO.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            EgO.SetActive(true);
            canTalk = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            EgO.SetActive(false);
            canTalk = false;
        }
    }
}
