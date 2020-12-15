using System.Drawing;

namespace Proyecto_final_formualario_
{
    class Sprite
    {
        public Bitmap CurrentSprite;
        public bool Show;
        public int _x, _y, _ancho, _alto;
        public Sprite(string filename, int x, int y)
        {
            CurrentSprite = new Bitmap(filename);
            _x = x;
            _y = y;
            _ancho = CurrentSprite.Width;
            _alto = CurrentSprite.Height;
        }
        public Sprite(string filename, int x, int y, int a, int h)
        {
            CurrentSprite = new Bitmap(filename);
            _x = x;
            _y = y;
            _ancho = a;
            _alto = h;
            Show = true;
        }

            public bool SpriteCollision(Sprite s)
        {
            Sprite temp = this;
            Rectangle A = new Rectangle(s._x, s._y, s._ancho, s._alto);
            Rectangle B = new Rectangle(temp._x, temp._y, temp._ancho, temp._alto);

            if (A.IntersectsWith(B))
                return true;
            else return false;
        }

    }
}
