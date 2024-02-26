using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private Vector2 movementInputV;
    private Rigidbody2D rB;

    [SerializeField] private GameObject DocumentarygO; // is Documentary ( replace inventory )
    private int docIndex = 0; // documentary index , if 1 and player press B he undo constrains and close Documentary

    #region Sprites

    [SerializeField] private Sprite WalkLeftSprite;
    [SerializeField] private Sprite WalkRightSprite;
    [SerializeField] private Sprite WalkDownSprite;
    [SerializeField] private Sprite WalkUpSprite;

    #endregion


    public static bool isPlayerFrozen = false;  // checkbox in constrains was true, but player still moved ( bugg )

    private void Start()
    {
        rB = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Vector2 directionV = transform.right * movementInputV.x + transform.up * movementInputV.y;
        rB.velocity = (directionV * speed);

        if (Input.GetKeyDown(KeyCode.B) && docIndex == 0)
        {
            docIndex = 1;
            DocumentarygO.SetActive(true);
            rB.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
            isPlayerFrozen = true;
        }
        else if(Input.GetKeyDown(KeyCode.B) && docIndex == 1)
        {
            docIndex = 0;
            DocumentarygO.SetActive(false);
            rB.constraints = RigidbodyConstraints2D.None;
            rB.constraints = RigidbodyConstraints2D.FreezeRotation;
            isPlayerFrozen = false;  
        }  
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
    }
}
