var movement = new Vector2(HorizontalInput, Input.GetAxis("Vertical"));
PlayersRigidbody.MovePosition(PlayersRigidbody.position + movement * speed * Time.deltaTime);

//в project settings - Physics 2D - Simulation mode - Update
//иначе дергать будет
