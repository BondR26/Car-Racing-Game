using System;
using SFML.Window;
using SFML.Graphics;

public class Sedan : Vehicle
{
	public Sedan(string name, string lane)
	{
		this.LoadTexture(name);
		speed = 3;
		this.lane = lane;
		this.high_lane = new Vector2f(-125, 225);
		this.low_lane = new Vector2f(0, 425);
		this.scale = new Vector2f(0.45f, 0.45f);
		this.SetSprite();
	}

   
}
