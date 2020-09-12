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
    public class BarCode
    {
        public Bitmap GerarBarCode(string texto , Color color)
        {
            // Variáveis
            BarcodeWriter barcodeWrite = new BarcodeWriter();
            EncodingOptions encodingOptions = new EncodingOptions() { Width = 300, Height = 300, Margin = 0, PureBarcode = false };
            //

            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            //Config BarCode
            barcodeWrite.Renderer = new BitmapRenderer();

            barcodeWrite.Options = encodingOptions;

            barcodeWrite.Format = BarcodeFormat.CODABAR;
            //
            // BarCode Original.
            Bitmap bitmap = barcodeWrite.Write(texto);

            #region Modificar a cor Original.
            //Fonte : https://stackoverflow.com/questions/17208254/how-to-change-pixel-color-of-an-image-in-c-net
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

    }

}
