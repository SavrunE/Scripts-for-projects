public bool LookOnLeft;


private void Update()
{
 float HorizontalInput = Input.GetAxis("Horizontal");
 if (LookOnLeft == true && HorizontalInput <= 0)
     Flip();
else if (LookOnLeft == false && HorizontalInput > 0)
      Flip();
}               
            
            public void Flip()
    {
        LookOnLeft = !LookOnLeft;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
