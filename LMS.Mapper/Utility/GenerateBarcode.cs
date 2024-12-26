using System.Drawing;

namespace LMS.Mapper.Utility
{
    public static class GenerateBarcode
    {
        private static string[,] code39Pattern =
        {
            {"0", "nnnwwnwnn"}, {"1", "wnnwnnnnw"}, {"2", "nnwwnnnnw"},
            {"3", "wnwwnnnnn"}, {"4", "nnnwwnnnw"}, {"5", "wnnwwnnnn"},
            {"6", "nnwwwnnnn"}, {"7", "nnnwnnwnw"}, {"8", "wnnwnnwnn"},
            {"9", "nnwwnnwnn"}, {"A", "wnnnnwnnw"}, {"B", "nnwnnwnnw"},
            {"C", "wnwnnwnnn"}, {"D", "nnnnwwnnw"}, {"E", "wnnnwwnnn"},
            {"F", "nnwnwwnnn"}, {"G", "nnnnnwwnw"}, {"H", "wnnnnwwnn"},
            {"I", "nnwnnwwnn"}, {"J", "nnnnwwwnn"}, {"K", "wnnnnnnww"},
            {"L", "nnwnnnnww"}, {"M", "wnwnnnnwn"}, {"N", "nnnnwnnww"},
            {"O", "wnnnwnnwn"}, {"P", "nnwnwnnwn"}, {"Q", "nnnnnnwww"},
            {"R", "wnnnnnwwn"}, {"S", "nnwnnnwwn"}, {"T", "nnnnwnwwn"},
            {"U", "wwnnnnnnw"}, {"V", "nwwnnnnnw"}, {"W", "wwwnnnnnn"},
            {"X", "nwnnwnnnw"}, {"Y", "wwnnwnnnn"}, {"Z", "nwwnwnnnn"},
            {"-", "nwnnnnwnw"}, {".", "wwnnnnwnn"}, {" ", "nwwnnnwnn"},
            {"*", "nwnnwnwnn"}, {"$", "nwnwnwnnn"}, {"/", "nwnwnnnwn"},
            {"+", "nwnnnwnwn"}, {"%", "nnnwnwnwn"}
        };
        private static string code39Alpha = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ-. *$/+%";
        public static Bitmap GetBarcode(string strBarcode)
        {
            int intwidth;
            int intBarcodeLen;
            int indexCode39;
            strBarcode = "*" + strBarcode + "*";

            strBarcode = strBarcode.Replace("'", "").Replace(",", "").ToUpper();
            intwidth = (strBarcode.Length * 15) + (strBarcode.Length - 1);
            Bitmap bitmap = new Bitmap(intwidth, 40);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);
                float xCurrPos = 0;
                float xNextPos = 1;

                for (intBarcodeLen = 0; intBarcodeLen < strBarcode.Length; intBarcodeLen++)
                {
                    indexCode39 = code39Alpha.IndexOf(strBarcode[intBarcodeLen]);
                    string strPattern = code39Pattern[indexCode39, 1];
                    Brush brush = Brushes.Black;
                    Pen pen = Pens.Black;

                    for (int i = 0; i < strPattern.Length; i++)
                    {
                        if (strPattern[i] == 'n')
                        {
                            xNextPos = xCurrPos + 1;
                            g.DrawRectangle(pen, xCurrPos, 0, xNextPos, 40);
                            g.FillRectangle(brush, xCurrPos, 0, xNextPos, 40);
                        }
                        else
                        {
                            xNextPos = xCurrPos + 3;
                            g.DrawRectangle(pen, xCurrPos, 0, xNextPos, 40);
                            g.FillRectangle(brush, xCurrPos, 0, xNextPos, 40);
                        }
                        xCurrPos = xNextPos;
                        if (pen == Pens.White)
                        {
                            pen = Pens.Black;
                            brush = Brushes.Black;
                        }
                        else
                        {
                            pen = Pens.White;
                            brush = Brushes.White;
                        }
                    }
                    xNextPos = xCurrPos + 1;
                    g.DrawRectangle(Pens.White, xCurrPos, 0, xNextPos, 40);
                    g.FillRectangle(Brushes.White, xCurrPos, 0, xNextPos, 40);
                    xCurrPos = xNextPos;
                }
            }
            return bitmap;
        }
    }
}
