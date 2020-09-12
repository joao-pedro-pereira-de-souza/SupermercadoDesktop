using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using ZXing;
using ZXing.Rendering;
using ZXing.QrCode.Internal;
using ZXing.Common;


namespace GeradorCode
{
    public class QRCode
    {

        public Bitmap GerarQRCode(string texto , Color color)
        {
          
            BarcodeWriter barcodeWrite = new BarcodeWriter();

            
            EncodingOptions encodingOptions = new EncodingOptions() { Width = 300, Height = 300, Margin = 0, PureBarcode = false };
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);

           

            barcodeWrite.Renderer = new BitmapRenderer();

            barcodeWrite.Options = encodingOptions;

            barcodeWrite.Format = BarcodeFormat.QR_CODE;

            Bitmap bitmap = barcodeWrite.Write(texto);

            #region Modificar a cor Original.

            Bitmap newBitmap = new Bitmap(bitmap.Width, bitmap.Height);

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {

                    // Modificar as cores do bit da imagem.
                    var originalColor = bitmap.GetPixel(i, j);
                    if (originalColor.R == 0 && originalColor.G == 0 && originalColor.B == 0)
                        newBitmap.SetPixel(i, j, Color.FromArgb(originalColor.A, color));
                   
                }
            }

            #endregion

            return newBitmap;

        }

        #region ColorBitMap
        //Fonte : https://stackoverflow.com/questions/17208254/how-to-change-pixel-color-of-an-image-in-c-net
        public Bitmap ChangeColor(Bitmap scrBitmap, Color color)
        {
            
            //You can change your new color here. Red,Green,LawnGreen any..  
            Color newColor = color;
            Color actualColor;
            //make an empty bitmap the same size as scrBitmap  
            Bitmap newBitmap = new Bitmap(scrBitmap.Width, scrBitmap.Height);
            for (int i = 0; i < scrBitmap.Width; i++)
            {
                for (int j = 0; j < scrBitmap.Height; j++)
                {
                    //get the pixel from the scrBitmap image  
                    actualColor = scrBitmap.GetPixel(i, j);
                    // > 150 because.. Images edges can be of low pixel colr. if we set all pixel color to new then there will be no smoothness left.  
                    if (actualColor.A > 150)
                        newBitmap.SetPixel(i, j, newColor);
                    else
                        newBitmap.SetPixel(i, j, actualColor);
                }
            }
            return newBitmap;
        }

        #endregion

    }
}
