using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBluePrint standardTurret;
    public TurretBluePrint missileLauncher;
    BuildManager buildManager;

 private void Start() {
     buildManager = BuildManager.instance;
 }

    public void SelectStandardTurret() {
        buildManager.SelectTurretToBuild(standardTurret);
    }

    public void SelectMissileLauncher() {
        Debug.Log("MISSILE LAUMCHER PURCHASED");
        buildManager.SelectTurretToBuild(missileLauncher);
    }   
}
