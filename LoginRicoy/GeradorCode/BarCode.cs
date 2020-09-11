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
        public Bitmap GerarBarCode(string texto)
        {
            BarcodeWriter barcodeWrite = new BarcodeWriter();
            EncodingOptions encodingOptions = new EncodingOptions() { Width = 300, Height = 300, Margin = 0, PureBarcode = false };
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);

            barcodeWrite.Renderer = new BitmapRenderer();

            barcodeWrite.Options = encodingOptions;

            barcodeWrite.Format = BarcodeFormat.CODABAR;

            Bitmap bitmap = barcodeWrite.Write(texto);

            return bitmap;
        }

    }

}
