using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using  System.Windows.Forms;

namespace AsteroidsGame.Sprites
{
    public class Keyboard
    {
        Form form;
        Sprite sprite;
        float acc = 0.25F;

        public Keyboard (Form f, Sprite s)
        {
            this.form=f;
            sprite = s;
            form.KeyDown += new KeyEventHandler(form_KeyDown);
        }

        void form_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Up:
                    {
                        sprite.acc.Move(0, -acc);
                        break;
                    }
                case Keys.Down:
                    {
                        sprite.acc.Move(0, acc);
                        break;
                    }
                case Keys.Left:
                    {
                        sprite.acc.Move(-acc, 0);
                        break;
                    }
                case Keys.Right:
                    {
                        sprite.acc.Move(acc, 0);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }
}
