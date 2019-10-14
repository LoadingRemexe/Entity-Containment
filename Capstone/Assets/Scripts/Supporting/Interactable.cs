﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    [SerializeField] UnityEvent InteractActivate = null;

    public void Interact()
    {
        if (InteractActivate != null)
        {
            InteractActivate.Invoke();
        }
    }
}
