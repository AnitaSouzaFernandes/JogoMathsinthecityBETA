﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalizaFase3 : MonoBehaviour
{
    public GameObject FasesPanel;
    public GameObject ControleTextosTF;
    public Button Fase4;

    void Start()
    {
        FasesPanel.SetActive(false);
      
    }

    public void ShowFasesPanel()
    {
        FasesPanel.SetActive(true);
        Fase4.interactable = true;
        ControleTextosTF.GetComponent<AbreTexto1>().MostraMensagem();
    }
    public void HideFasesPanel()
    {
        FasesPanel.SetActive(false);
    }
}
