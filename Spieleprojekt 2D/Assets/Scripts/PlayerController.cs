using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private Vector2 movementInputV;
    private Rigidbody2D rB;


    [SerializeField] private GameObject InvestigationgO; 
    private int vIndex = 0;  // index for getkeydown V
    private bool openInvestigation = true;   
    


    #region Sprites

    [SerializeField] private Sprite WalkLeftSprite;
    [SerializeField] private Sprite WalkRightSprite;
    [SerializeField] private Sprite WalkDownSprite;
    [SerializeField] private Sprite WalkUpSprite;

    #endregion
   
    public static bool isPlayerFrozen = false;  // checkbox in constrains was true, but player still moved ( bugg )
    public static bool pickingUp = false;
    private void Awake()
    {
      /*  InvestigationgO = GameObject.FindWithTag("Test");
        InvestigationgO.SetActive(false);
        DontDestroyOnLoad(InvestigationgO); */
    }
    private void Start()
    {
        InvestigationgO.SetActive(false);
        
        rB = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Vector2 directionV = transform.right * movementInputV.x + transform.up * movementInputV.y;
        rB.velocity = directionV * speed;



        #region Press V
        if (Input.GetKeyDown(KeyCode.V) && openInvestigation == true && vIndex == 0)
        {
            openInvestigation = false;
            vIndex = 1;
            InvestigationgO.SetActive(true);
            rB.constraints = RigidbodyConstraints2D.FreezeAll;

        }
        else if (Input.GetKeyDown(KeyCode.V) && openInvestigation == true && vIndex == 1)
        {
            openInvestigation = false;
            vIndex = 0;
            InvestigationgO.SetActive(false);
            rB.constraints = RigidbodyConstraints2D.None;
            rB.constraints = RigidbodyConstraints2D.FreezeRotation;

        }

        openInvestigation = true;

        #endregion

        
    }





    public void OnMovement(InputAction.CallbackContext _context)
    {
        if(isPlayerFrozen == false)
        {
            movementInputV = _context.ReadValue<Vector2>();
        }
       
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.identity;

        if(isPlayerFrozen)
        {
            rB.constraints = RigidbodyConstraints2D.FreezePosition;
        }
        else if(!isPlayerFrozen)
        {
            rB.constraints = RigidbodyConstraints2D.None;
            rB.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
    }
}
