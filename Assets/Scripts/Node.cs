﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{

    public Color hoverColor;
    public Vector3 positionOffset;
    private GameObject turret;
    private Renderer rend;
    private Color startColor;
    private BuildManager buildManager;
    void Start() {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = BuildManager.instance;
    }

    void OnMouseDown() {
        if (buildManager.getTurretToBuild() == null)
            return;
        
        if (turret != null) {
            Debug.Log("WE CANT BUILD HERE");
            return;
        }
        
        GameObject turretToBuild = BuildManager.instance.getTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
    }
    void OnMouseEnter() {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (buildManager.getTurretToBuild() == null)
            return;

        rend.material.color = hoverColor; 
    }

    void OnMouseExit() {
        rend.material.color = startColor;
    }
}
