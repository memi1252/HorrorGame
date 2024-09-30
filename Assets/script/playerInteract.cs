using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class playerInteract : MonoBehaviour
{ 
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float interactRange = 0.5f;
            Collider[] collidersArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in collidersArray)
            {
                if (collider.TryGetComponent(out storyinteract storyinteract))
                {
                    storyinteract.Interact();
                }

                if (collider.TryGetComponent(out flashInteract flashInteract))
                {
                    flashInteract.Interact();
                    Destroy(flashInteract.gameObject);
                }
                if (collider.TryGetComponent(out eraserinteract eraserinteract))
                {
                    eraserinteract.Interact();
                    Destroy(eraserinteract.gameObject);
                }
                if (collider.TryGetComponent(out DiaryInteract diaryInteract))
                {
                    diaryInteract.Interact();
                    Destroy(diaryInteract.gameObject);
                }
            }
        }
    }
}
