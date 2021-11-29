using System;
using SFML.Audio;
using SFML.Graphics;
using SFML.Window;
using System.Threading;

namespace RaceGame
{
    class Program
    {
        enum Car { bus, truck, sportcar, sedan };
        public static RenderWindow wind = new RenderWindow(new VideoMode(1365, 601), "Racing Game");
        public static Content road_texture = new Content("road.png");
        public static Finish finish = new Finish("finish.png");
        public static Win win = new Win("win.png");
        public static Loss loss = new Loss("lost.png");
        public static  string[] nums = { "3.png", "2.png", "1.png" };
        public static Count_Down count_down = new Count_Down(nums);
        public static  Bus bus = new Bus("bus1.png", "low_lane");
        public static Truck truck = new Truck("truck1.png", "high_lane");
        public static SportCar sportcar = new SportCar("sportcar.png", "low_lane");
        public static Sedan sedan = new Sedan("sedan.png", "high_lane");
        public static Menu menu = new Menu(1365, 601);
        public static Vehicle my_vehicle;
        public static Vehicle opponent_vehicle;

        static void WinClose(object sender, EventArgs ea)
        {
            wind.Close();
        }



        static void MakeCountDown()
        {
            int count = 0;

            while (count != 3)
            {
                wind.Clear(Color.White);
                wind.Draw(road_texture.sprite);
                wind.Draw(finish.sprite);
                wind.Draw(my_vehicle.sprite);
                wind.Draw(opponent_vehicle.sprite);
                wind.Draw(count_down.sprites[count]);
                Thread.Sleep(1000);
                count++;
                wind.Display();
                
            }

            Thread.Sleep(1000);
        }

        static public void GameMain()
        {
            while (true)
            {
                wind.DispatchEvents();

                wind.Clear(Color.White);

                wind.Draw(road_texture.sprite);

                wind.Draw(finish.sprite);

                wind.Draw(my_vehicle.sprite);

                if (Keyboard.IsKeyPressed(Keyboard.Key.Space))
                    my_vehicle.Move();

                wind.Draw(opponent_vehicle.sprite);

                opponent_vehicle.Move();

                if (opponent_vehicle.sprite.Position.X >= finish.sprite.Position.X - 350)
                {
                    wind.Draw(loss.sprite);
                    wind.Display();
                    Thread.Sleep(10000);
                    break;
                }

                if (my_vehicle.sprite.Position.X >= finish.sprite.Position.X - 150)
                {
                    wind.Draw(win.sprite);
                    wind.Display();
                    Thread.Sleep(10000);
                    break;
                }

                wind.Display();
            }
        }

        static void Main()
        {
           
            wind.SetVerticalSyncEnabled(true);
            wind.Closed += WinClose;

            

            while (wind.IsOpen())
            {
                wind.Clear(Color.Black);

                menu.drawmenu(ref wind);

                wind.DispatchEvents();

                if(Keyboard.IsKeyPressed(Keyboard.Key.Down))
                {
                    menu.MoveDown();
                }

                if(Keyboard.IsKeyPressed(Keyboard.Key.Up))
                {
                    menu.MoveUp();
                }

                if (Keyboard.IsKeyPressed(Keyboard.Key.Return))
                {
                   switch(menu.selectedItemIndex)
                    {
                        case 1: 
                            {
                                my_vehicle = sportcar;
                                opponent_vehicle = sedan;
                            }
                            break;
                        case 2:
                            {

                                opponent_vehicle = sportcar;
                                my_vehicle = sedan;
                            }
                            break;
                        case 3:
                            {
                                opponent_vehicle = bus;
                                my_vehicle = truck;
                            }
                            break;
                        case 4:
                            {
                                my_vehicle = bus;
                                opponent_vehicle = truck;

                            }
                            break;
                    }

                    MakeCountDown();

                    GameMain();

                    
                }
                
                if(Keyboard.IsKeyPressed(Keyboard.Key.Escape))
                {
                    wind.Close();
                }

                wind.Display();       
            }

           
           
        }
    }
}