using System;
using SFML.Window;
using SFML.Graphics;

public abstract class Vehicle
{
	public const string directory = "A:\\C++\\ITStep Homework\\C#\\Car Racing\\Homework3\\bin\\Content\\Cars\\";

    private Texture car;
	public Texture Car
    {
        get => car;
    }

		public void LoadTexture(string car_name)
		{
			car = new Texture(directory + car_name);
		}

	public Vector2f low_lane;
	public Vector2f high_lane;
	public Vector2f scale;
	public int speed;
    public string lane;
	public Sprite sprite;


    public void SetSprite()
    {
        this.sprite = new Sprite(Car);
        SetLane(lane);
        SetScale();
    }
    public Vector2f Move()
    {
        this.sprite.Position += new Vector2f(speed, 0);
        if(this.sprite.Position.X > 1365)
        {
            this.sprite.Position = SetLane(lane);
        }
        return this.sprite.Position;
    }

    public Vector2f SetLane(string lane = "low_lane")
    {
        if (lane == "low_lane")
            this.sprite.Position = this.low_lane;
        else if (lane == "high_lane")
            this.sprite.Position = this.high_lane;

        return this.sprite.Position;
    }

    public Vector2f SetScale()
    {
        return this.sprite.Scale = this.scale;
    }
}



