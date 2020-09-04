public bool LookOnLeft;
float HorizontalInput = Input.GetAxis("Horizontal");

private void Update()
{
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
