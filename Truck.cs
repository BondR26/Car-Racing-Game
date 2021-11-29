using System;
using SFML.Window;
using SFML.Graphics;
public class Truck : Vehicle
{
	public Truck(string name, string lane)
	{
        this.LoadTexture(name);
        speed = 2;
        this.lane = lane;
        this.high_lane = new Vector2f(0, 300);
        this.low_lane = new Vector2f(0, 425);
        this.scale = new Vector2f(0.7f, 0.6f);
        this.SetSprite();
    }

   // 
    
   
}
