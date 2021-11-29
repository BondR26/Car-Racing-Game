using System;
using SFML.Graphics;
using SFML.Window;

public class Menu
{
	public int selectedItemIndex;

	public const int MENU_ITEMS = 5;
	public Font font;

	public Text[] menu;
	public Menu(int width, int height)
	{
		string[] s_menu = { "Select your car", "Sport Car", "Sedan", "Truck", "Bus" };

		font = new Font("A:\\C++\\ITStep Homework\\C#\\Car Racing\\Homework3\\BRLNSR.TTF");

		menu = new Text[5];

		for(int i=0; i< 5; i++)
        {
			menu[i] = new Text(s_menu[i], font);
			if (i == 0)
			{
				menu[i].Color = Color.White;
			}
			else
			{
				menu[i].Color = (Color.Red);
			}
			menu[i].Position = new Vector2f(width/2, height / 6 * (i + 1));
		}


		selectedItemIndex = 1;

	}


	public void drawmenu(ref RenderWindow window)
	{
		for (int i = 0; i < MENU_ITEMS; i++)
		{
			window.Draw(menu[i]);
		}
	}


	public void MoveUp()
	{
		if (selectedItemIndex - 1 >= 1)
		{
			menu[selectedItemIndex].Color = Color.Red;
			selectedItemIndex--;
			menu[selectedItemIndex].Color = Color.White;
		}
	}

	public void MoveDown()
	{
		if (selectedItemIndex + 1 < MENU_ITEMS)
		{
			menu[selectedItemIndex].Color = Color.Red;
			selectedItemIndex++;
			menu[selectedItemIndex].Color = Color.White;
		}
	}

	public int GetPressedItem()
	{
		return selectedItemIndex;
	}
}
