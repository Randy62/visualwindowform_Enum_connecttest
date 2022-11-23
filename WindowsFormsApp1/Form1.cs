using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Capture cap = null;
        public Form1()
        {
            InitializeComponent();
            cap = new Capture(0);
            Image<Bgr, Byte> frame = cap.QueryFrame();
            IntPtr mes = cap.Ptr;
            //pictureBox1.Image = frame.Bitmap;
            Console.WriteLine(mes);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            axAxAltairU1.Width = 30;//設定相機寬
            axAxAltairU1.Height = 30;//設定相機高
            axAxAltairU2.Width = 30;
            axAxAltairU2.Height = 30;
            axAxAltairU1.SerialNumber = 1022040001;//設定通道代號
            axAxAltairU2.SerialNumber = 1022040003;
            axAxAltairU1.CreateChannel();//設定通道
            axAxAltairU2.CreateChannel();

            axAxCanvas1.CanvasWidth = axAxAltairU1.ImageWidth;
            axAxCanvas1.CanvasHeight = axAxAltairU1.ImageHeight;
            axAxObject1.ObjectClass = AxOvkBlob.TxAxObjClass.AX_OBJECT_DETECT_LIGHTER_CLASS;
        }
        private void axAxAltairU1_OnSurfaceFilled(object sender, AxAxAltairUDrv.IAxAltairUEvents_OnSurfaceFilledEvent e)
        {
            axAxBlobROIBW81.ParentHandle = e.surfaceHandle;
            axAxBlobROIBW81.Reset();
            axAxObject1.SrcImageHandle = e.surfaceHandle;
            axAxObject1.ThresholdMethod = AxOvkBlob.TxAxObjThresholdMethod.AX_OBJECT_DISANA_THRESHOLD_METHOD;//最佳門檻值計算法則 = 
            axAxObject1.HighThreshold = axAxObject1.OptimalThreshold;
            axAxObject1.BlobAnalyze(false);
            axAxObject1.CalculateFeatures(1, -1);
            axAxObject1.SortObjects(AxOvkBlob.TxAxObjFeatureSortOrder.AX_OBJECT_SORT_ORDER_LARGE_TO_SMALL, AxOvkBlob.TxAxObjFeature.AX_OBJECT_FEATURE_AREA, -1, -1);
            axAxObject1.BlobIndex = 0;
            axAxBlobROIBW81.AddBlob(axAxObject1.BlobVegaHandle);
            axAxObject1.BlobIndex = 1;
            axAxBlobROIBW81.AddBlob(axAxObject1.BlobVegaHandle);
            axAxObject1.SrcImageHandle = axAxBlobROIBW81.VegaHandle;
            axAxObject1.ThresholdMethod = AxOvkBlob.TxAxObjThresholdMethod.AX_OBJECT_MAX_ENTROPY_THRESHOLD_METHOD;
            axAxObject1.HighThreshold = axAxObject1.OptimalThreshold;
            axAxObject1.BlobAnalyze(false);
            
        }
        private void axAxAltairU1_OnSurfaceDraw(object sender, AxAxAltairUDrv.IAxAltairUEvents_OnSurfaceDrawEvent e)
        {
            axAxCanvas1.DrawSurface(e.surfaceHandle, 1, 1, 0, 0);
            if (checkBox1.Checked)
            {
                if (checkBox2.Checked)
                    axAxBlobROIBW81.DrawRuns(axAxCanvas1.hDC, 1, 1, 0, 0, 0xFFFF);
                else
                    axAxObject1.DrawBlobs(axAxCanvas1.hDC, -1, 1, 1, 0, 0, true, 255);
            }
            axAxCanvas1.RefreshCanvas();
        }
        private void axAxObject1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            axAxAltairU1.Live();
        }

        private void axAxCanvas1_Enter(object sender, EventArgs e)
        {

        }
        private void axAxBlobROIBW81_OnBlobPlaceChange(object sender, EventArgs e)
        {

        }

        private void snap_Click(object sender, EventArgs e)
        {
            axAxAltairU1.Snap(1);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
