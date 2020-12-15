using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final_formualario_
{
    public partial class Form1 : Form
    {
        public static bool START = true;
        bool arriba, izquierda;
        public string KEY;

        Sprite[] sprites = new Sprite[10];

        public Form1()
        {
            InitializeComponent();
        }

        public void loadSprite(string file, int num, int x, int y)
        {
            sprites[num] = new Sprite(file, x, y);
        }

        public void loadSprite(string file, int num, int x, int y, int a, int h)
        {
            sprites[num] = new Sprite(file, x, y, a, h);
        }

        public void SetupGame()
        {
            izquierda = true;
            arriba = true;
            loadSprite("Raqueta1.jpg", 1, 5, 210);
            loadSprite("Raqueta1.jpg", 2, 780, 210);
            loadSprite("pelota.jpg", 3, 390,240,20,20);
        }

        private void lblComenzar_MouseEnter(object sender, EventArgs e)
        {
            lblComenzar.Font = new Font("Cooper Black", 50);
        }

        private void lblSalir_MouseEnter(object sender, EventArgs e)
        {
            lblSalir.Font = new Font("Cooper Black", 50);
        }

        private void lblComenzar_MouseLeave(object sender, EventArgs e)
        {
            lblComenzar.Font = new Font("Cooper Black", 30);
        }

        private void lblSalir_MouseLeave(object sender, EventArgs e)
        {
            lblSalir.Font = new Font("Cooper Black", 30);
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblComenzar_Click(object sender, EventArgs e)
        {
            Tiempo.Start();
            START = true;
            lblSalir.Hide();
            lblComenzar.Hide();
            SetupGame();
        }

        private void lblComenzar_Paint(object sender, PaintEventArgs e)
        {

        }

        public bool KeyPressed(Keys k)
        {
            if (KEY == k.ToString())
                return true;
            else return false;
        }
        public void MoverSprite(int num, int x, int y)
        {
            sprites[num]._x = x;
            sprites[num]._y = y;
        }
        private void Tiempo_Tick(object sender, EventArgs e)
        {
            if (START)
                this.Refresh();
            if (KeyPressed(Keys.Up) && SpriteY(1) > 10)
                MoverSprite(1, SpriteX(1), SpriteY(1) - 6);
            if (KeyPressed(Keys.Down) && SpriteY(1) < 410)
                MoverSprite(1, SpriteX(1), SpriteY(1) + 6);
            if (KeyPressed(Keys.Left) && SpriteY(1) > 9 && SpriteX(1) > -20)
                MoverSprite(1, SpriteX(1) - 7, SpriteY(1));
            if (KeyPressed(Keys.Right) && SpriteY(1) < 415 && SpriteX(1) < 390)
                MoverSprite(1, SpriteX(1) + 4, SpriteY(1));

            if (!izquierda)
                MoverSprite(3, SpriteX(3) - 6, SpriteY(3));
            if (!izquierda)
                MoverSprite(3, SpriteX(3) + 6, SpriteY(3));
            if (arriba)
                MoverSprite(3, SpriteX(3), SpriteY(3) - 5);
            if (!arriba)
                MoverSprite(3, SpriteX(3), SpriteY(3) + 6);

            if (arriba && SpriteY(3) < 11)
                arriba = false;
            if (!arriba && SpriteY(3) > 475)
                arriba = true;

            if (sprites[3].SpriteCollision(sprites[1]) && izquierda)
                izquierda = false;
            if (sprites[3].SpriteCollision(sprites[2]) && izquierda == false)
                izquierda = true;

            if (SpriteY(3) < SpriteY(2) + sprites[2]._alto / 2 && SpriteY(2) > 10 && izquierda == false)
                MoverSprite(2, SpriteX(2) - 4, SpriteY(2) - 8);
            if (SpriteY(3) > SpriteY(2) + sprites[2]._alto / 2 && SpriteY(2) < 410 && izquierda == false)
                MoverSprite(2, SpriteX(2) + 3, SpriteY(2) + 8);

            if (SpriteX(3) < -30)
            {
                }
        }
        public int SpriteY(int num)
        {
            return sprites[num]._y;
        }
        public int SpriteX(int num)
        {
            return sprites[num]._x;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.DoubleBuffered = true;
            KEY = e.X.ToString();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            KEY = "";
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            this.DoubleBuffered = true;
            Graphics g= e.Graphics;
            foreach (Sprite s in sprites)
            {
                    if (s != null)
                        g.DrawImage(s.CurrentSprite, new Rectangle(s._x, s._y, s._ancho, s._alto));
            }
        }
    }
}
