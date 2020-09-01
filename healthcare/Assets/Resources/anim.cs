using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class anim : MonoBehaviour
{

    public Animator animator;
    public Transform my3DModel;
    // Start is called before the first frame update
    void Start()
    {
        animator = my3DModel.GetComponent<Animator>();

    }
    public void playAnim()
    {
        animator.Play("elbow_punch", -1, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
