using System;
using SFML.Window;
using SFML.Graphics;
public class Bus:Vehicle
{
	public Bus(string name, string lane)
	{
		this.LoadTexture(name);
		speed = 1;
		this.lane = lane;
		this.high_lane = new Vector2f(0, 325);
		this.low_lane = new Vector2f(0, 450);
		this.scale = new Vector2f(1f, 1f);
		this.SetSprite();
	}



}
