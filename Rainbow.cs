// rainbow
// 
// Copyright (c) 2016 Robin Southern -- github.com/r57s/rainbow
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using UnityEngine;

static public class WebColor
{
    public static Color HexCode(int h)
    {
        return new Color(
            (((h >> 16) & 0xFF) / 255.0f),
            (((h >> 8) & 0xFF) / 255.0f),
            ((h & 0xFF) / 255.0f),
            1.0f);
    }
    
    public static Color aliceBlue { get { return HexCode(0xf0f8ff); } }
    public static Color antiqueWhite { get { return HexCode(0xfaebd7); } }
    public static Color aqua { get { return HexCode(0x00ffff); } }
    public static Color aquamarine { get { return HexCode(0x7fffd4); } }
    public static Color azure { get { return HexCode(0xf0ffff); } }
    public static Color beige { get { return HexCode(0xf5f5dc); } }
    public static Color bisque { get { return HexCode(0xffe4c4); } }
    public static Color black { get { return HexCode(0x000000); } }
    public static Color blanchedAlmond { get { return HexCode(0xffebcd); } }
    public static Color blue { get { return HexCode(0x0000ff); } }
    public static Color blueViolet { get { return HexCode(0x8a2be2); } }
    public static Color brown { get { return HexCode(0xa52a2a); } }
    public static Color burlywood { get { return HexCode(0xdeb887); } }
    public static Color cadetBlue { get { return HexCode(0x5f9ea0); } }
    public static Color chartreuse { get { return HexCode(0x7fff00); } }
    public static Color chocolate { get { return HexCode(0xd2691e); } }
    public static Color coral { get { return HexCode(0xff7f50); } }
    public static Color cornflowerBlue { get { return HexCode(0x6495ed); } }
    public static Color cornsilk { get { return HexCode(0xfff8dc); } }
    public static Color crimson { get { return HexCode(0xdc143c); } }
    public static Color cyan { get { return HexCode(0x00ffff); } }
    public static Color darkBlue { get { return HexCode(0x00008b); } }
    public static Color darkCyan { get { return HexCode(0x008b8b); } }
    public static Color darkGoldenrod { get { return HexCode(0xb8860b); } }
    public static Color darkGray { get { return HexCode(0xa9a9a9); } }
    public static Color darkGreen { get { return HexCode(0x006400); } }
    public static Color darkGrey { get { return HexCode(0xa9a9a9); } }
    public static Color darkKhaki { get { return HexCode(0xbdb76b); } }
    public static Color darkMagenta { get { return HexCode(0x8b008b); } }
    public static Color darkOlivegreen { get { return HexCode(0x556b2f); } }
    public static Color darkOrange { get { return HexCode(0xff8c00); } }
    public static Color darkOrchid { get { return HexCode(0x9932cc); } }
    public static Color darkRed { get { return HexCode(0x8b0000); } }
    public static Color darkSalmon { get { return HexCode(0xe9967a); } }
    public static Color darkSeagreen { get { return HexCode(0x8fbc8f); } }
    public static Color darkSlateblue { get { return HexCode(0x483d8b); } }
    public static Color darkSlategray { get { return HexCode(0x2f4f4f); } }
    public static Color darkSlategrey { get { return HexCode(0x2f4f4f); } }
    public static Color darkTurquoise { get { return HexCode(0x00ced1); } }
    public static Color darkViolet { get { return HexCode(0x9400d3); } }
    public static Color deepPink { get { return HexCode(0xff1493); } }
    public static Color deepSkyblue { get { return HexCode(0x00bfff); } }
    public static Color dimGray { get { return HexCode(0x696969); } }
    public static Color dimGrey { get { return HexCode(0x696969); } }
    public static Color dodgerBlue { get { return HexCode(0x1e90ff); } }
    public static Color fireBrick { get { return HexCode(0xb22222); } }
    public static Color floralWhite { get { return HexCode(0xfffaf0); } }
    public static Color forestGreen { get { return HexCode(0x228b22); } }
    public static Color fuchsia { get { return HexCode(0xff00ff); } }
    public static Color gainsboro { get { return HexCode(0xdcdcdc); } }
    public static Color ghostWhite { get { return HexCode(0xf8f8ff); } }
    public static Color gold { get { return HexCode(0xffd700); } }
    public static Color goldenrod { get { return HexCode(0xdaa520); } }
    public static Color gray { get { return HexCode(0x808080); } }
    public static Color green { get { return HexCode(0x008000); } }
    public static Color greenYellow { get { return HexCode(0xadff2f); } }
    public static Color grey { get { return HexCode(0x808080); } }
    public static Color honeydew { get { return HexCode(0xf0fff0); } }
    public static Color hotPink { get { return HexCode(0xff69b4); } }
    public static Color indianRed { get { return HexCode(0xcd5c5c); } }
    public static Color indigo { get { return HexCode(0x4b0082); } }
    public static Color ivory { get { return HexCode(0xfffff0); } }
    public static Color khaki { get { return HexCode(0xf0e68c); } }
    public static Color lavender { get { return HexCode(0xe6e6fa); } }
    public static Color lavenderBlush { get { return HexCode(0xfff0f5); } }
    public static Color lawnGreen { get { return HexCode(0x7cfc00); } }
    public static Color lemonChiffon { get { return HexCode(0xfffacd); } }
    public static Color lightBlue { get { return HexCode(0xadd8e6); } }
    public static Color lightCoral { get { return HexCode(0xf08080); } }
    public static Color lightCyan { get { return HexCode(0xe0ffff); } }
    public static Color lightGoldenrodyellow { get { return HexCode(0xfafad2); } }
    public static Color lightGray { get { return HexCode(0xd3d3d3); } }
    public static Color lightGreen { get { return HexCode(0x90ee90); } }
    public static Color lightGrey { get { return HexCode(0xd3d3d3); } }
    public static Color lightPink { get { return HexCode(0xffb6c1); } }
    public static Color lightSalmon { get { return HexCode(0xffa07a); } }
    public static Color lightSeagreen { get { return HexCode(0x20b2aa); } }
    public static Color lightSkyblue { get { return HexCode(0x87cefa); } }
    public static Color lightSlategray { get { return HexCode(0x778899); } }
    public static Color lightSlategrey { get { return HexCode(0x778899); } }
    public static Color lightSteelblue { get { return HexCode(0xb0c4de); } }
    public static Color lightYellow { get { return HexCode(0xffffe0); } }
    public static Color lime { get { return HexCode(0x00ff00); } }
    public static Color limeGreen { get { return HexCode(0x32cd32); } }
    public static Color linen { get { return HexCode(0xfaf0e6); } }
    public static Color magenta { get { return HexCode(0xff00ff); } }
    public static Color maroon { get { return HexCode(0x800000); } }
    public static Color mediumAquamarine { get { return HexCode(0x66cdaa); } }
    public static Color mediumBioletRed { get { return HexCode(0xc71585); } }
    public static Color mediumBlue { get { return HexCode(0x0000cd); } }
    public static Color mediumOrchid { get { return HexCode(0xba55d3); } }
    public static Color mediumPurple { get { return HexCode(0x9370db); } }
    public static Color mediumSeaGreen { get { return HexCode(0x3cb371); } }
    public static Color mediumSlateBlue { get { return HexCode(0x7b68ee); } }
    public static Color mediumSpringGreen { get { return HexCode(0x00fa9a); } }
    public static Color mediumTurquoise { get { return HexCode(0x48d1cc); } }
    public static Color midnightBlue { get { return HexCode(0x191970); } }
    public static Color mintCream { get { return HexCode(0xf5fffa); } }
    public static Color mistyRose { get { return HexCode(0xffe4e1); } }
    public static Color moccasin { get { return HexCode(0xffe4b5); } }
    public static Color navajoWhite { get { return HexCode(0xffdead); } }
    public static Color navy { get { return HexCode(0x000080); } }
    public static Color oldLace { get { return HexCode(0xfdf5e6); } }
    public static Color olive { get { return HexCode(0x808000); } }
    public static Color oliveDrab { get { return HexCode(0x6b8e23); } }
    public static Color orange { get { return HexCode(0xffa500); } }
    public static Color orangeRed { get { return HexCode(0xff4500); } }
    public static Color orchid { get { return HexCode(0xda70d6); } }
    public static Color paleGoldenrod { get { return HexCode(0xeee8aa); } }
    public static Color paleGreen { get { return HexCode(0x98fb98); } }
    public static Color paleTurquoise { get { return HexCode(0xafeeee); } }
    public static Color paleVioletRed { get { return HexCode(0xdb7093); } }
    public static Color papayaWhip { get { return HexCode(0xffefd5); } }
    public static Color peachPuff { get { return HexCode(0xffdab9); } }
    public static Color peru { get { return HexCode(0xcd853f); } }
    public static Color pink { get { return HexCode(0xffc0cb); } }
    public static Color plum { get { return HexCode(0xdda0dd); } }
    public static Color powderBlue { get { return HexCode(0xb0e0e6); } }
    public static Color purple { get { return HexCode(0x800080); } }
    public static Color red { get { return HexCode(0xff0000); } }
    public static Color rosyBrown { get { return HexCode(0xbc8f8f); } }
    public static Color royalBlue { get { return HexCode(0x4169e1); } }
    public static Color saddleBrown { get { return HexCode(0x8b4513); } }
    public static Color salmon { get { return HexCode(0xfa8072); } }
    public static Color sandyBrown { get { return HexCode(0xf4a460); } }
    public static Color seaGreen { get { return HexCode(0x2e8b57); } }
    public static Color seaShell { get { return HexCode(0xfff5ee); } }
    public static Color sienna { get { return HexCode(0xa0522d); } }
    public static Color silver { get { return HexCode(0xc0c0c0); } }
    public static Color skyBlue { get { return HexCode(0x87ceeb); } }
    public static Color slateBlue { get { return HexCode(0x6a5acd); } }
    public static Color slateGray { get { return HexCode(0x708090); } }
    public static Color slateGrey { get { return HexCode(0x708090); } }
    public static Color snow { get { return HexCode(0xfffafa); } }
    public static Color springGreen { get { return HexCode(0x00ff7f); } }
    public static Color steelBlue { get { return HexCode(0x4682b4); } }
    public static Color tan { get { return HexCode(0xd2b48c); } }
    public static Color teal { get { return HexCode(0x008080); } }
    public static Color thistle { get { return HexCode(0xd8bfd8); } }
    public static Color tomato { get { return HexCode(0xff6347); } }
    public static Color turquoise { get { return HexCode(0x40e0d0); } }
    public static Color violet { get { return HexCode(0xee82ee); } }
    public static Color wheat { get { return HexCode(0xf5deb3); } }
    public static Color white { get { return HexCode(0xffffff); } }
    public static Color whiteSmoke { get { return HexCode(0xf5f5f5); } }
    public static Color yellow { get { return HexCode(0xffff00); } }
    public static Color yellowGreen { get { return HexCode(0x9acd32); } }
}


static public class WebColor32
{
    static Color32 HexCode(int h)
    {
        return new Color32(
            ((byte) ((h >> 16) & 0xFF)),
            ((byte) ((h >> 8) & 0xFF)),
            ((byte) (h & 0xFF)),
            255);
    }
    
    public static Color32 aliceBlue { get { return HexCode(0xf0f8ff); } }
    public static Color32 antiqueWhite { get { return HexCode(0xfaebd7); } }
    public static Color32 aqua { get { return HexCode(0x00ffff); } }
    public static Color32 aquamarine { get { return HexCode(0x7fffd4); } }
    public static Color32 azure { get { return HexCode(0xf0ffff); } }
    public static Color32 beige { get { return HexCode(0xf5f5dc); } }
    public static Color32 bisque { get { return HexCode(0xffe4c4); } }
    public static Color32 black { get { return HexCode(0x000000); } }
    public static Color32 blanchedAlmond { get { return HexCode(0xffebcd); } }
    public static Color32 blue { get { return HexCode(0x0000ff); } }
    public static Color32 blueViolet { get { return HexCode(0x8a2be2); } }
    public static Color32 brown { get { return HexCode(0xa52a2a); } }
    public static Color32 burlywood { get { return HexCode(0xdeb887); } }
    public static Color32 cadetBlue { get { return HexCode(0x5f9ea0); } }
    public static Color32 chartreuse { get { return HexCode(0x7fff00); } }
    public static Color32 chocolate { get { return HexCode(0xd2691e); } }
    public static Color32 coral { get { return HexCode(0xff7f50); } }
    public static Color32 cornflowerBlue { get { return HexCode(0x6495ed); } }
    public static Color32 cornsilk { get { return HexCode(0xfff8dc); } }
    public static Color32 crimson { get { return HexCode(0xdc143c); } }
    public static Color32 cyan { get { return HexCode(0x00ffff); } }
    public static Color32 darkBlue { get { return HexCode(0x00008b); } }
    public static Color32 darkCyan { get { return HexCode(0x008b8b); } }
    public static Color32 darkGoldenrod { get { return HexCode(0xb8860b); } }
    public static Color32 darkGray { get { return HexCode(0xa9a9a9); } }
    public static Color32 darkGreen { get { return HexCode(0x006400); } }
    public static Color32 darkGrey { get { return HexCode(0xa9a9a9); } }
    public static Color32 darkKhaki { get { return HexCode(0xbdb76b); } }
    public static Color32 darkMagenta { get { return HexCode(0x8b008b); } }
    public static Color32 darkOlivegreen { get { return HexCode(0x556b2f); } }
    public static Color32 darkOrange { get { return HexCode(0xff8c00); } }
    public static Color32 darkOrchid { get { return HexCode(0x9932cc); } }
    public static Color32 darkRed { get { return HexCode(0x8b0000); } }
    public static Color32 darkSalmon { get { return HexCode(0xe9967a); } }
    public static Color32 darkSeagreen { get { return HexCode(0x8fbc8f); } }
    public static Color32 darkSlateblue { get { return HexCode(0x483d8b); } }
    public static Color32 darkSlategray { get { return HexCode(0x2f4f4f); } }
    public static Color32 darkSlategrey { get { return HexCode(0x2f4f4f); } }
    public static Color32 darkTurquoise { get { return HexCode(0x00ced1); } }
    public static Color32 darkViolet { get { return HexCode(0x9400d3); } }
    public static Color32 deepPink { get { return HexCode(0xff1493); } }
    public static Color32 deepSkyblue { get { return HexCode(0x00bfff); } }
    public static Color32 dimGray { get { return HexCode(0x696969); } }
    public static Color32 dimGrey { get { return HexCode(0x696969); } }
    public static Color32 dodgerBlue { get { return HexCode(0x1e90ff); } }
    public static Color32 fireBrick { get { return HexCode(0xb22222); } }
    public static Color32 floralWhite { get { return HexCode(0xfffaf0); } }
    public static Color32 forestGreen { get { return HexCode(0x228b22); } }
    public static Color32 fuchsia { get { return HexCode(0xff00ff); } }
    public static Color32 gainsboro { get { return HexCode(0xdcdcdc); } }
    public static Color32 ghostWhite { get { return HexCode(0xf8f8ff); } }
    public static Color32 gold { get { return HexCode(0xffd700); } }
    public static Color32 goldenrod { get { return HexCode(0xdaa520); } }
    public static Color32 gray { get { return HexCode(0x808080); } }
    public static Color32 green { get { return HexCode(0x008000); } }
    public static Color32 greenYellow { get { return HexCode(0xadff2f); } }
    public static Color32 grey { get { return HexCode(0x808080); } }
    public static Color32 honeydew { get { return HexCode(0xf0fff0); } }
    public static Color32 hotPink { get { return HexCode(0xff69b4); } }
    public static Color32 indianRed { get { return HexCode(0xcd5c5c); } }
    public static Color32 indigo { get { return HexCode(0x4b0082); } }
    public static Color32 ivory { get { return HexCode(0xfffff0); } }
    public static Color32 khaki { get { return HexCode(0xf0e68c); } }
    public static Color32 lavender { get { return HexCode(0xe6e6fa); } }
    public static Color32 lavenderBlush { get { return HexCode(0xfff0f5); } }
    public static Color32 lawnGreen { get { return HexCode(0x7cfc00); } }
    public static Color32 lemonChiffon { get { return HexCode(0xfffacd); } }
    public static Color32 lightBlue { get { return HexCode(0xadd8e6); } }
    public static Color32 lightCoral { get { return HexCode(0xf08080); } }
    public static Color32 lightCyan { get { return HexCode(0xe0ffff); } }
    public static Color32 lightGoldenrodyellow { get { return HexCode(0xfafad2); } }
    public static Color32 lightGray { get { return HexCode(0xd3d3d3); } }
    public static Color32 lightGreen { get { return HexCode(0x90ee90); } }
    public static Color32 lightGrey { get { return HexCode(0xd3d3d3); } }
    public static Color32 lightPink { get { return HexCode(0xffb6c1); } }
    public static Color32 lightSalmon { get { return HexCode(0xffa07a); } }
    public static Color32 lightSeagreen { get { return HexCode(0x20b2aa); } }
    public static Color32 lightSkyblue { get { return HexCode(0x87cefa); } }
    public static Color32 lightSlategray { get { return HexCode(0x778899); } }
    public static Color32 lightSlategrey { get { return HexCode(0x778899); } }
    public static Color32 lightSteelblue { get { return HexCode(0xb0c4de); } }
    public static Color32 lightYellow { get { return HexCode(0xffffe0); } }
    public static Color32 lime { get { return HexCode(0x00ff00); } }
    public static Color32 limeGreen { get { return HexCode(0x32cd32); } }
    public static Color32 linen { get { return HexCode(0xfaf0e6); } }
    public static Color32 magenta { get { return HexCode(0xff00ff); } }
    public static Color32 maroon { get { return HexCode(0x800000); } }
    public static Color32 mediumAquamarine { get { return HexCode(0x66cdaa); } }
    public static Color32 mediumBioletRed { get { return HexCode(0xc71585); } }
    public static Color32 mediumBlue { get { return HexCode(0x0000cd); } }
    public static Color32 mediumOrchid { get { return HexCode(0xba55d3); } }
    public static Color32 mediumPurple { get { return HexCode(0x9370db); } }
    public static Color32 mediumSeaGreen { get { return HexCode(0x3cb371); } }
    public static Color32 mediumSlateBlue { get { return HexCode(0x7b68ee); } }
    public static Color32 mediumSpringGreen { get { return HexCode(0x00fa9a); } }
    public static Color32 mediumTurquoise { get { return HexCode(0x48d1cc); } }
    public static Color32 midnightBlue { get { return HexCode(0x191970); } }
    public static Color32 mintCream { get { return HexCode(0xf5fffa); } }
    public static Color32 mistyRose { get { return HexCode(0xffe4e1); } }
    public static Color32 moccasin { get { return HexCode(0xffe4b5); } }
    public static Color32 navajoWhite { get { return HexCode(0xffdead); } }
    public static Color32 navy { get { return HexCode(0x000080); } }
    public static Color32 oldLace { get { return HexCode(0xfdf5e6); } }
    public static Color32 olive { get { return HexCode(0x808000); } }
    public static Color32 oliveDrab { get { return HexCode(0x6b8e23); } }
    public static Color32 orange { get { return HexCode(0xffa500); } }
    public static Color32 orangeRed { get { return HexCode(0xff4500); } }
    public static Color32 orchid { get { return HexCode(0xda70d6); } }
    public static Color32 paleGoldenrod { get { return HexCode(0xeee8aa); } }
    public static Color32 paleGreen { get { return HexCode(0x98fb98); } }
    public static Color32 paleTurquoise { get { return HexCode(0xafeeee); } }
    public static Color32 paleVioletRed { get { return HexCode(0xdb7093); } }
    public static Color32 papayaWhip { get { return HexCode(0xffefd5); } }
    public static Color32 peachPuff { get { return HexCode(0xffdab9); } }
    public static Color32 peru { get { return HexCode(0xcd853f); } }
    public static Color32 pink { get { return HexCode(0xffc0cb); } }
    public static Color32 plum { get { return HexCode(0xdda0dd); } }
    public static Color32 powderBlue { get { return HexCode(0xb0e0e6); } }
    public static Color32 purple { get { return HexCode(0x800080); } }
    public static Color32 red { get { return HexCode(0xff0000); } }
    public static Color32 rosyBrown { get { return HexCode(0xbc8f8f); } }
    public static Color32 royalBlue { get { return HexCode(0x4169e1); } }
    public static Color32 saddleBrown { get { return HexCode(0x8b4513); } }
    public static Color32 salmon { get { return HexCode(0xfa8072); } }
    public static Color32 sandyBrown { get { return HexCode(0xf4a460); } }
    public static Color32 seaGreen { get { return HexCode(0x2e8b57); } }
    public static Color32 seaShell { get { return HexCode(0xfff5ee); } }
    public static Color32 sienna { get { return HexCode(0xa0522d); } }
    public static Color32 silver { get { return HexCode(0xc0c0c0); } }
    public static Color32 skyBlue { get { return HexCode(0x87ceeb); } }
    public static Color32 slateBlue { get { return HexCode(0x6a5acd); } }
    public static Color32 slateGray { get { return HexCode(0x708090); } }
    public static Color32 slateGrey { get { return HexCode(0x708090); } }
    public static Color32 snow { get { return HexCode(0xfffafa); } }
    public static Color32 springGreen { get { return HexCode(0x00ff7f); } }
    public static Color32 steelBlue { get { return HexCode(0x4682b4); } }
    public static Color32 tan { get { return HexCode(0xd2b48c); } }
    public static Color32 teal { get { return HexCode(0x008080); } }
    public static Color32 thistle { get { return HexCode(0xd8bfd8); } }
    public static Color32 tomato { get { return HexCode(0xff6347); } }
    public static Color32 turquoise { get { return HexCode(0x40e0d0); } }
    public static Color32 violet { get { return HexCode(0xee82ee); } }
    public static Color32 wheat { get { return HexCode(0xf5deb3); } }
    public static Color32 white { get { return HexCode(0xffffff); } }
    public static Color32 whiteSmoke { get { return HexCode(0xf5f5f5); } }
    public static Color32 yellow { get { return HexCode(0xffff00); } }
    public static Color32 yellowGreen { get { return HexCode(0x9acd32); } }
}