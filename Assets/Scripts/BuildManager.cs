﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    void Awake() {
        if (instance != null) {
            Debug.Log("More than one game manager in scene");
            return;
        }
        instance = this;
    }

    public GameObject standardTurretPrefab;
    public GameObject missileLauncherPrefab;

    public GameObject buildEffect;
    private TurretBluePrint turretToBuild;

    public bool CanBuild { get { return turretToBuild != null; } }
    public bool HasMoney { get { return PlayerStats.Money >= turretToBuild.cost; } }

    public void BuildTurretOn(Node node) {
        if (PlayerStats.Money < turretToBuild.cost) {
            Debug.Log("NOT ENOUGH MONEY");
            return;
        }
            
        PlayerStats.Money -= turretToBuild.cost;
        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;
        Instantiate(buildEffect, node.GetBuildPosition(), Quaternion.identity);
        Debug.Log("MONEY LEFT: " + PlayerStats.Money);
    }
    public void SelectTurretToBuild(TurretBluePrint turret) {
        turretToBuild = turret;
    }
}
