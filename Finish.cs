using System;
using SFML.Window;
using SFML.Graphics;

namespace RaceGame
{
	public class Finish : ISETSPRITE
	{

		public string directory = "A:\\C++\\ITStep Homework\\C#\\Car Racing\\Homework3\\bin\\Content\\star_finish_count\\";

		public Texture texture;
		public Sprite sprite;

		public Finish(string texture_file_name)
		{
			this.LoadTexture(texture_file_name);
			this.LoadSprite();
			this.Resize_and_Move();
		}

		public void LoadTexture(string image_name)
		{
			texture = new Texture(directory + image_name);
		}

		public void LoadSprite()
		{
			this.sprite = new Sprite(texture);
		}

        public void Resize_and_Move()
        {
			this.sprite.Scale = new Vector2f(0.3f, 0.3f);
            this.sprite.Position = new Vector2f(1225, 330);
        }
    }
}