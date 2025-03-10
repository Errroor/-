using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    [SerializeField]
    private Animator playerAnimator = null;
    void Start()
    {
        
    }
    void Update()
    {
        if (playerAnimator.GetFloat("x") == 0 && playerAnimator.GetFloat("y") == -1)
        {
            this.transform.localScale = Vector2.one;
        }
        else if (playerAnimator.GetFloat("x") == 1 && playerAnimator.GetFloat("y") == 0)
        {
            this.transform.localScale = new Vector2(-1, 1);
        }
        else if (playerAnimator.GetFloat("x") == 0 && playerAnimator.GetFloat("y") == 1)
        {
            this.transform.localScale = new Vector2(-1, -1);
        }
        else if (playerAnimator.GetFloat("x") == -1 && playerAnimator.GetFloat("y") == 0)
        {
            this.transform.localScale = new Vector2(1, -1);
        }
    }
}