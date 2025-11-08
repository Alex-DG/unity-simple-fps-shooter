using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Gun gun;

    private bool isHoldingShoot = false;

    #region PlayerInput SendMessage
    void OnShoot()
    {
        print("shoot!");
        isHoldingShoot = true;
    }
    void OnShootRelease()
    {
        print("shoot release!");
        isHoldingShoot = false;
    }
    void OnReload()
    {
        if (gun != null)
        {
            gun.TryReload();
        }
    }
    #endregion

    void Update()
    {
        if (isHoldingShoot && gun != null)
        {
            gun.Shoot();
        }
    }
}
