using System;
using SFML.Graphics;
using SFML.Window;

namespace RaceGame
{
	public class Content: ISETSPRITE
	{
		public string directory = "A:\\C++\\ITStep Homework\\C#\\Car Racing\\Homework3\\bin\\Content\\Texture\\";

		public Texture texture;
		public Sprite sprite;

		public Content(string texture_file_name)
        {
			this.LoadTexture(texture_file_name);
			this.LoadSprite();
			//this.Resize_and_Move();
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
			
        }
	}
}