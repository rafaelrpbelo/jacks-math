using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
    }

    public void GetLost() {
        animator.SetBool("isLost", true);
    }
}
