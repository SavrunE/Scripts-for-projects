if (currentTarget) {
                var mainDirection = puskUstanovka.TransformDirection(Vector3.forward);
                var targetDirection = currentTarget.position - puskUstanovka.position;
                var enemAngle = Vector3.Angle(targetDirection, mainDirection);
         if (enemAngle > fireAngle) {
                puskUstanovka.rotation = Quaternion.Slerp (puskUstanovka.rotation, Quaternion.LookRotation(targetDirection), turelRotSpeed);
                puskUstanovka.eulerAngles = Vector3(0, puskUstanovka.eulerAngles.y, 0);
        }
}
