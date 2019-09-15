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

    public void PurchaseAnotherTurret() {
        Debug.Log("ANNOTHER TURRENT PURCHASED");
        buildManager.SetTurretToBuild(buildManager.annotherTurretPrefab);
    }   
}
