using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

 private void Start() {
     buildManager = BuildManager.instance;
 }

    public void PurchaseStandardTurret() {
        Debug.Log("STADARD TURRENT PURCHASED");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
    }

    public void PurchaseMissileLauncher() {
        Debug.Log("MISSILE LAUMCHER PURCHASED");
        buildManager.SetTurretToBuild(buildManager.missileLauncherPrefab);
    }   
}
