using System;
using SFML.Window;
using SFML.Graphics;

public class SportCar : Vehicle
{
	public SportCar(string name, string lane)
	{
        this.LoadTexture(name);
        speed = 4;
        this.lane = lane;
        this.high_lane = new Vector2f(0, 300);
        this.low_lane = new Vector2f(0, 425);
        this.scale = new Vector2f(0.5f, 0.5f);
        this.SetSprite();
    }
}
