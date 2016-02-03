using System;

namespace tsconfig.domain
{
    public class WWColor
    {
        public string Name;
        public int Index;
        public byte H;
        public byte S;
        public byte V;
        public byte R;
        public byte G;
        public byte B;


        public WWColor (string name, int index, byte h, byte s, byte v)
        {
            Name = name;
            Index = index;
            H = h;
            S = s;
            V = v;
            HsvToRgb(this);
        }

        public static void HsvToRgb(WWColor self)
        {
            /* Similar to http://web.mit.edu/storborg/Public/hsvtorgb.c */
            byte H = self.H;
            byte S = self.S;
            byte V = self.V;
            if (S == 0)
            {
                self.R = V;
                self.G = V;
                self.B = V;
                return;
            }
            byte R,G,B;
            byte region = (byte)(H/43);
            byte fpart = (byte) ((H - (region * 43)) * 6);
            byte p = (byte) ((V * (255 - S)) >> 8);
            byte q = (byte) ((V * (255 - ((S * fpart) >>8))) >> 8);
            byte t = (byte) ((V * (255 - ((S * (255 - fpart)) >> 8))) >> 8);
            switch (region)
            {
                // Red is the dominant color
            case 0:
                R = V;
                G = t;
                B = p;
                break;

                // Green is the dominant color
            case 1:
                R = q;
                G = V;
                B = p;
                break;
            case 2:
                R = p;
                G = V;
                B = t;
                break;

                // Blue is the dominant color
            case 3:
                R = p;
                G = q;
                B = V;
                break;
            case 4:
                R = t;
                G = p;
                B = V;
                break;

                // Red is the dominant color
            case 5:
                R = V;
                G = p;
                B = q;
                break;


            default:
                R = V;
                G = p;
                B = q;
                break;
            }
            self.R = R;
            self.G = G;
            self.B = B;
        }

        public static WWColor ByIndex(int i)
        {
            /* The index value will always be an odd number.
               There are 100 colors in the TS Color Vector but
               each color is duplicated so that color 0 and
               color 1 has the same RGB/HSV. The WWColor Array
               contains only the odd numbered indices. (Even
               numbered colors may have the same HSV but have
               some other property that allows them to render
               on top of shroud)
            */
            if (i < 0 || i > 99)
            {
                throw new IndexOutOfRangeException();
            }
            i|=1; // Make it odd
            return WWColor.Array[i/2];
        }

        public static WWColor[] Array = {
            new WWColor("LightGold",1,0x22,0x80,0xff)
            ,new WWColor("Gold",3,0x22,0xa0,0xff)
            ,new WWColor("DarkGold",5,0x22,0xeb,0xff)
            ,new WWColor("LightGrey",7,0x0,0x0,0xdc)
            ,new WWColor("Grey",9,0x0,0x0,0xbe)
            ,new WWColor("DarkGrey",11,0x0,0x0,0x78)
            ,new WWColor("Black",13,0x0,0x64,0x0)
            ,new WWColor("White",15,0x0,0x0,0xff)
            ,new WWColor("LightRed",17,0x0,0x46,0xff)
            ,new WWColor("Red",19,0x0,0xa0,0xff)
            ,new WWColor("DarkRed",21,0x0,0xeb,0xff)
            ,new WWColor("Burgandy",23,0x0,0xff,0x96)
            ,new WWColor("LightOrange",25,0x18,0xa5,0xff)
            ,new WWColor("Orange",27,0x18,0xff,0xff)
            ,new WWColor("DarkOrange",29,0xb,0xeb,0xff)
            ,new WWColor("LightMagenta",31,0xe4,0x78,0xff)
            ,new WWColor("Magenta",33,0xe4,0xa0,0xff)
            ,new WWColor("DarkMagenta",35,0xe4,0xeb,0xff)
            ,new WWColor("LightPurple",37,0xc8,0xa0,0xff)
            ,new WWColor("Purple",39,0xc8,0xeb,0xff)
            ,new WWColor("HyundaiPurple",41,0xc8,0xeb,0xaa)
            ,new WWColor("LightBlue",43,0xa4,0x8c,0xff)
            ,new WWColor("Blue",45,0xa4,0xc8,0xff)
            ,new WWColor("DarkBlue",47,0xa4,0xc8,0xb3)
            ,new WWColor("NeonBlue",49,0xa4,0xff,0xff)
            ,new WWColor("LightSky",51,0x8e,0x46,0xff)
            ,new WWColor("Sky",53,0x8e,0xa0,0xff)
            ,new WWColor("DarkSky",55,0x8e,0xeb,0xff)
            ,new WWColor("LightCyan",57,0x84,0x46,0xff)
            ,new WWColor("Cyan",59,0x84,0xa0,0xff)
            ,new WWColor("DarkCyan",61,0x84,0xeb,0xff)
            ,new WWColor("LightTeal",63,0x6e,0x46,0xff)
            ,new WWColor("Teal",65,0x6e,0xa0,0xff)
            ,new WWColor("DarkTeal",67,0x6e,0xeb,0xff)
            ,new WWColor("LightGreen",69,0x55,0x46,0xff)
            ,new WWColor("Green",71,0x55,0xa0,0xc8)
            ,new WWColor("DarkGreen",73,0x55,0xeb,0x96)
            ,new WWColor("NeonGreen",75,0x55,0xff,0xff)
            ,new WWColor("LightYellow",77,0x2b,0x46,0xff)
            ,new WWColor("Yellow",79,0x2b,0xa0,0xff)
            ,new WWColor("DarkYellow",81,0x2b,0xeb,0xff)
            ,new WWColor("NeonYellow",83,0x2b,0xff,0xff)
            ,new WWColor("LightPeach",85,0x15,0x78,0xff)
            ,new WWColor("Peach",87,0x15,0x96,0xff)
            ,new WWColor("DarkPeach",89,0x15,0xb4,0xff)
            ,new WWColor("DarkerPeach",91,0x15,0xff,0xff)
            ,new WWColor("LightLime",93,0x35,0x46,0xff)
            ,new WWColor("Lime",95,0x35,0xa0,0xff)
            ,new WWColor("Darklime",97,0x35,0xeb,0xc8)
            ,new WWColor("NeonLime",99,0x35,0xeb,0xff)
        };
    }
}
