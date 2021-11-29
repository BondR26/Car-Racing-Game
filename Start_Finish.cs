using System;
using SFML.Graphics;
using SFML.Window;

public class Win: ISETSPRITE
{
	public Sprite sprite;
    public Texture texture;
	public Win(string image_name)
	{
        this.LoadTexture(image_name);
        this.LoadSprite();
        this.Resize_and_Move();
	}

    public void LoadSprite()
    {
        this.sprite = new Sprite(this.texture);
    }

    public void LoadTexture(string image_name)
    {
        this.texture = new Texture("A:\\C++\\ITStep Homework\\C#\\Car Racing\\Homework3\\bin\\Content\\star_finish_count\\" + image_name);
    }

    public void Resize_and_Move()
    {
        this.sprite.Position = new Vector2f(600, 200);
    }
}

public class Loss: ISETSPRITE
{
    public Sprite sprite;
    public Texture texture;
    public Loss(string image_name)
    {
        this.LoadTexture(image_name);
        this.LoadSprite();
        this.Resize_and_Move();
    }

    public void LoadSprite()
    {
        this.sprite = new Sprite(this.texture);
    }

    public void LoadTexture(string image_name)
    {
        this.texture = new Texture("A:\\C++\\ITStep Homework\\C#\\Car Racing\\Homework3\\bin\\Content\\star_finish_count\\" + image_name);
    }

    public void Resize_and_Move()
    {
        this.sprite.Position = new Vector2f(600, 200);
    }
}

class Count_Down
{
    public const string Dir = "A:\\C++\\ITStep Homework\\C#\\Car Racing\\Homework3\\bin\\Content\\star_finish_count\\";
    public Sprite [] sprites = new Sprite[3];
    public Texture [] textures = new Texture[3];
    public Count_Down(string [] nums)
    {
        this.LoadTexture(nums);
        this.LoadSprite();
        this.Resize_and_Move();
    }

    public void LoadSprite()
    {
        for(int i=0; i <3; i++)
        this.sprites[i] = new Sprite(this.textures[i]);
    }

    public void LoadTexture(string [] image_name)
    {
        for (int i = 0; i < 3; i++)
            this.textures[i] = new Texture("A:\\C++\\ITStep Homework\\C#\\Car Racing\\Homework3\\bin\\Content\\star_finish_count\\" + image_name[i]);
    }

    public void Resize_and_Move()
    {
        this.sprites[2].Position = new Vector2f(600, 200);

        this.sprites[1].Scale = new Vector2f(0.1f, 0.1f);
        this.sprites[1].Position = new Vector2f(600, 200);

        this.sprites[0].Scale = new Vector2f(0.4f, 0.4f);
        this.sprites[0].Position = new Vector2f(600, 100);
    }

}
