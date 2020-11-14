    void WeaponRotate()
    {
        float rotateZ = Mathf.Atan2(Joystick.Vertical, Joystick.Horizontal) * Mathf.Rad2Deg;
        armPosition.rotation = Quaternion.Euler(0, 0, rotateZ + 90);
    }
