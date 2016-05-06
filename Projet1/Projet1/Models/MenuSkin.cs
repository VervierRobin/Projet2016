using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet1.Models
{
    public class MenuSkin
    {
        public static List<SkinColor> listSkinColorDark = new List<SkinColor>() {
            new SkinColor() { SkinLTE = "skin-blue",   LabelSkin="Bleu",   ColorRectTopLeft="bg-blue-active",   ColorRectTopRight="bg-blue" ,  ColorRectBottomLeft="bg-noir", ColorRectBottomRight = "bg-blanc"  },
            new SkinColor() { SkinLTE = "skin-black",  LabelSkin="Blanc",  ColorRectTopLeft="bg-blanc",         ColorRectTopRight="bg-blanc" , ColorRectBottomLeft="bg-noir", ColorRectBottomRight = "bg-blanc"  },
            new SkinColor() { SkinLTE = "skin-purple", LabelSkin="Violet", ColorRectTopLeft="bg-purple-active", ColorRectTopRight="bg-purple", ColorRectBottomLeft="bg-noir", ColorRectBottomRight = "bg-blanc"  },
            new SkinColor() { SkinLTE = "skin-green",  LabelSkin="Vert",   ColorRectTopLeft="bg-green-active",  ColorRectTopRight="bg-green" , ColorRectBottomLeft="bg-noir", ColorRectBottomRight = "bg-blanc"  },
            new SkinColor() { SkinLTE = "skin-red",    LabelSkin="Rouge",  ColorRectTopLeft="bg-red-active",    ColorRectTopRight="bg-red",    ColorRectBottomLeft="bg-noir", ColorRectBottomRight = "bg-blanc"  },
            new SkinColor() { SkinLTE = "skin-yellow", LabelSkin="Jaune",  ColorRectTopLeft="bg-yellow-active", ColorRectTopRight="bg-yellow", ColorRectBottomLeft="bg-noir", ColorRectBottomRight = "bg-blanc"  }

        };

        public static List<SkinColor> listSkinColorLight = new List<SkinColor>() {
            new SkinColor() { SkinLTE = "skin-blue-light",   LabelSkin="Bleu",   ColorRectTopLeft="bg-blue-active",   ColorRectTopRight="bg-blue" ,  ColorRectBottomLeft="bg-blanc", ColorRectBottomRight = "bg-blanc"  },
            new SkinColor() { SkinLTE = "skin-black-light",  LabelSkin="Blanc",  ColorRectTopLeft="bg-blanc",         ColorRectTopRight="bg-blanc" , ColorRectBottomLeft="bg-blanc", ColorRectBottomRight = "bg-blanc"  },
            new SkinColor() { SkinLTE = "skin-purple-light", LabelSkin="Violet", ColorRectTopLeft="bg-purple-active", ColorRectTopRight="bg-purple", ColorRectBottomLeft="bg-blanc", ColorRectBottomRight = "bg-blanc"  },
            new SkinColor() { SkinLTE = "skin-green-light",  LabelSkin="Vert",   ColorRectTopLeft="bg-green-active",  ColorRectTopRight="bg-green" , ColorRectBottomLeft="bg-blanc", ColorRectBottomRight = "bg-blanc"  },
            new SkinColor() { SkinLTE = "skin-red-light",    LabelSkin="Rouge",  ColorRectTopLeft="bg-red-active",    ColorRectTopRight="bg-red",    ColorRectBottomLeft="bg-blanc", ColorRectBottomRight = "bg-blanc"  },
            new SkinColor() { SkinLTE = "skin-yellow-light", LabelSkin="Jaune",  ColorRectTopLeft="bg-yellow-active", ColorRectTopRight="bg-yellow", ColorRectBottomLeft="bg-blanc", ColorRectBottomRight = "bg-blanc"  }
        };


    }
    public class SkinColor
    {
        public string SkinLTE { get; set; }
        public string LabelSkin { get; set; }
        public string ColorRectTopLeft { get; set; }
        public string ColorRectTopRight { get; set; }
        public string ColorRectBottomLeft { get; set; }
        public string ColorRectBottomRight { get; set; }

    }


}