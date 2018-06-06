using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Recommented
{
    public partial class Form1 : Form
    {
        private float[,] item;
        private float[,] itemNormalized;
        private float[,] cosine;
        private float[,] pearson;
        private float[,] itemNorOld;
        private float[] P;
        private float[,] itemOld;

        public Form1()
        {
            InitializeComponent();
            btnNext1.Hide(); // ẩn button
            btnNext2.Hide();
            btnNext3.Hide();
            //btnNext4.Hide();
            btnNext5.Hide();
            label5.Hide();
            label3.Hide();
            label4.Hide();
            label6.Hide();
        }
        
        private void CreateTextBox(FlowLayoutPanel flp,  int i, int j, int h, int c)
        {
            TextBox bt = new TextBox();
            bt.Name = "txt" + i.ToString() + j.ToString(); // đặt tên button
            bt.AutoSize = false;
            bt.Size = new Size(flp.Size.Width / c - 6, flp.Size.Height / h - 6); // kích thức button //-6 để muốn giảm đi những khoảng trống ở giữa bt
            flp.Controls.Add(bt); //dùng flowlayout nên không cần phải sắp xếp
        }

        public void CreateMatrix(FlowLayoutPanel flp, int h, int c)
        {
            for (int i = 0; i < h; i++) //h
            {
                for (int j = 0; j < c; j++)//w
                {
                    CreateTextBox(flp,i, j, h, c);
                }
            }
        }

        private void docfile_Click(object sender, EventArgs e)
        {
            flowLayoutPanelMatrixX.Controls.Clear();
            int hang = int.Parse(txtHang.Text);
            int cot = int.Parse(txtCot.Text);
            //tạo Matrix X
            CreateMatrix(flowLayoutPanelMatrixX, hang, cot);

            //sau khi bấn nút tạo sẽ hiện Next
            btnNext1.Show();
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            flowLayoutPanelNormalized.Controls.Clear();
            int hang = int.Parse(txtHang.Text);
            int cot = int.Parse(txtCot.Text);
            CreateMatrix(flowLayoutPanelNormalized, hang, cot);

            // lưu vào mảng 2 chiều
            item = new float[hang, cot];
            itemOld = new float[hang, cot];
            for (int i = 0; i < hang; i++) //h
            {
                for (int j = 0; j < cot; j++)//w
                {
                    TextBox bt = new TextBox();
                    bt = flowLayoutPanelMatrixX.Controls.Find("txt" + i.ToString() + j.ToString(), true).FirstOrDefault() as TextBox;
                    if (bt.Text.Equals(""))
                    {
                        item[i, j] = -1;
                        itemOld[i, j] = -1;
                    }
                    else
                    {
                        item[i, j] = Int32.Parse(bt.Text);
                        itemOld[i, j] = Int32.Parse(bt.Text);
                    }
                }
            }
            Normalized(item, hang, cot);
            btnNext2.Show();
            label5.Show();
        }

        private void Normalized(float[,] item,  int h, int c)
        {
            P = new float[h];
            itemNormalized = new float[h, c];
            itemNorOld = new float[h, c];
            for (int i = 0; i < h; i++) //h
            {
                float S = 0;
                int dem = 0;
                for (int j = 0; j < c; j++)//w
                {
                        if (item[i,j] != -1)
                        {
                            dem++;
                            S += item[i,j];
                        }
                }

                P[i] = (float)Math.Round(S / dem, 2);
               
                for (int j = 0; j < c; j++)//w
                {
                    TextBox bt1 = new TextBox();
                    bt1 = flowLayoutPanelNormalized.Controls.Find("txt" + i.ToString() + j.ToString(), true).FirstOrDefault() as TextBox;

                    if (item[i,j] != -1)
                    {
                            itemNormalized[i,j] = ((float)Math.Round((item[i,j] - P[i]) * 100) / 100);
                            itemNorOld[i, j] = ((float)Math.Round((item[i, j] - P[i]) * 100) / 100);
                            bt1.Text = itemNormalized[i,j].ToString();
                    }
                    else
                    {
                            itemNormalized[i,j] = -10;
                            itemNorOld[i, j] = -10;
                            bt1.Text = itemNormalized[i,j].ToString();
                    }
                }
            }
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            int h = int.Parse(txtHang.Text);
            int c = int.Parse(txtCot.Text);
            flowLayoutPanelCosine.Controls.Clear();
            CreateMatrix(flowLayoutPanelCosine, h, h);
            //flowLayoutPanelPearson.Controls.Clear();
            //CreateMatrix(flowLayoutPanelPearson, h, h);
            cosine = new float[h,h];
            pearson = new float[h, h];
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    //ma tran cosine
                    TextBox bt1 = new TextBox();
                    bt1 = flowLayoutPanelCosine.Controls.Find("txt" + i.ToString() + j.ToString(), true).FirstOrDefault() as TextBox;
                    //ma tran pearson
                    TextBox bt2 = new TextBox();
                    //bt2 = flowLayoutPanelPearson.Controls.Find("txt" + i.ToString() + j.ToString(), true).FirstOrDefault() as TextBox;
                    float[] a = new float[c];
                    float[] b = new float[c];
                    float[] d = new float[c];
                    float[] g = new float[c];

                    for (int k = 0; k < c; k++)
                    {
                        a[k] = itemNormalized[i, k];
                        b[k] = itemNormalized[j, k];
                        d[k] = itemOld[i, k];
                        g[k] = itemOld[j, k];
                    }
                    //tính cosine
                    cosine[i, j] = CosineSimilarity(a, b, c);
                    bt1.Text = cosine[i, j].ToString();
                    //tính pearson
                    pearson[i, j] = PearsonSimilarity(d, g, c);
                    bt2.Text = pearson[i, j].ToString();
                    btnNext3.Show();
                    //btnNext4.Show();
                    label3.Show();
                }
            }
        }

        private float CosineSimilarity(float[] a, float[] b, int cot)
        {
            float kq = 0;
            float ab = 0, a2 = 0, b2 = 0;
            for (int i = 0; i < cot; i++)
            {
                if (a[i] == -10)
                {
                    a[i] = 0;
                }
                if (b[i] == -10)
                {
                    b[i] = 0;
                }
                ab += a[i] * b[i];
                a2 += a[i] * a[i];
                b2 += b[i] * b[i];
            }
            kq = (float)Math.Round((ab / (Math.Sqrt(a2) * Math.Sqrt(b2))),2);
            return kq;
        }
        public float PearsonSimilarity(float[] a, float[] b, int cot)
        {
            float kq = 0;
            float ab = 0, a2 = 0, b2 = 0;
            float ta = 0;
            float tb = 0;
            int ca = 0;
            int cb = 0;
            for (int i = 0; i < cot; i++)
            {
                if (a[i] == -1)
                {
                    a[i] = 0;
                }
                else
                {
                    ca++;
                }
                if (b[i] == -1)
                {
                    b[i] = 0;
                }
                else
                {
                    cb++;
                }
                ta += a[i];
                tb += b[i];
            }

            float tba = (float)ta / ca;
            float tbb = (float) tb / cb;
            for (int i = 0; i < cot; i++)
            {
                ab += (a[i] - tba) * (b[i] - tbb);
                a2 += (a[i] - tba) * (a[i] - tba);
                b2 += (b[i] - tbb) * (b[i] - tbb);
            }
            kq = (float)Math.Round((ab / (Math.Sqrt(a2) * Math.Sqrt(b2))),2);
            return kq;
        }
        private void btnDocFile_Click(object sender, EventArgs e)
        {
            int h = 0;
            int c = 0;
            item = new float[1000, 1000];
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt;*.rtf)|*.txt;*.rtf|All files (*.*)|*.*";
            ofd.Title = "Open a file...";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(ofd.FileName);
                foreach (string s in lines)
                {
                    int cot = 0;
                    string[] b = s.Split(' ');
                    foreach (string ca in b)
                    {
                        item[h, cot] = float.Parse(ca.ToString());
                        cot++;
                        c = cot;
                    }
                    h++;
                }
                txtHang.Text = h.ToString();
                txtCot.Text = c.ToString();
                CreateMatrix(flowLayoutPanelMatrixX, h, c);
                for (int m = 0; m < h; m++)
                {
                    for (int k = 0; k < c; k++)
                    {
                        TextBox bt1 = new TextBox();
                        bt1 = flowLayoutPanelMatrixX.Controls.Find("txt" + m.ToString() + k.ToString(), true).FirstOrDefault() as TextBox;
                        if (item[m, k] == -1)
                        {
                            bt1.Text.Equals("");
                        }
                        else
                        {
                            bt1.Text = item[m, k].ToString();
                        }

                    }
                }
                btnNext1.Show();
            }
        }

        private void btnNext3_Click(object sender, EventArgs e)
        {
            
            int hang = int.Parse(txtHang.Text);
            int cot = int.Parse(txtCot.Text);
            
            for (int h = 0; h < hang; h++) {
			    for (int j = 0; j < cot; j++) {
                    if (itemNorOld[h, j] == -10)
                    {
                        List<Similarity> listsimilarity = new List<Similarity>();
                        for (int k = 0; k < hang; k++)
                        {
                            if (itemNorOld[k, j] != -10 && h != k)
                            {
                                listsimilarity.Add(new Similarity(k, cosine[h, k]));
                            }
                        }
                        //listsimilarity.Sort();
                        listsimilarity.Sort(delegate(Similarity dt1, Similarity dt2)
                        {
                            return dt2.similarity.CompareTo(dt1.similarity);
                        });
                        float T = 0;
                        float M = 0;
                        int knei = 0;
                        if (listsimilarity.Count < 2)
                        {
                            knei = listsimilarity.Count;
                        }
                        else
                        {
                            knei = 2;
                        }
                        for (int i = 0; i < knei; i++)
                        {
                            T += (float)(listsimilarity[i].similarity * itemNorOld[listsimilarity[i].item, j]);
                            M += Math.Abs(listsimilarity[i].similarity);
                        }
                        float DuDoan = (float)Math.Round((T / M),2);
                        itemNormalized[h,j] = DuDoan;
                    }
			    }
		    }
            flowLayoutPanelPredictionCosine.Controls.Clear();
            CreateMatrix(flowLayoutPanelPredictionCosine, hang, cot);
            for (int i = 0; i < hang; i++)
            {
                for (int n = 0; n < cot; n++)
                {
                    //ma tran cosine
                    TextBox bt1 = new TextBox();
                    bt1 = flowLayoutPanelPredictionCosine.Controls.Find("txt" + i.ToString() + n.ToString(), true).FirstOrDefault() as TextBox;
                    bt1.Text = itemNormalized[i, n].ToString();
                }
            }
            label4.Show();
            btnNext5.Show();
        }

        //private void btnNext4_Click(object sender, EventArgs e)
        //{
        //    int hang = int.Parse(txtHang.Text);
        //    int cot = int.Parse(txtCot.Text);

        //    for (int h = 0; h < hang; h++)
        //    {
        //        for (int j = 0; j < cot; j++)
        //        {
        //            if (itemOld[h, j] == -1)
        //            {
        //                List<Similarity> listsimilarity = new List<Similarity>();
        //                for (int k = 0; k < hang; k++)
        //                {
        //                    if (item[k, j] != -1 && h != k)
        //                    {
        //                        listsimilarity.Add(new Similarity(k, pearson[h, k]));
        //                    }
        //                }
        //                //listsimilarity.Sort();
        //                listsimilarity.Sort(delegate(Similarity dt1, Similarity dt2)
        //                {
        //                    return dt2.similarity.CompareTo(dt1.similarity);
        //                });
        //                float T = 0;
        //                float M = 0;
        //                int knei = 0;
        //                if (listsimilarity.Count < 2)
        //                {
        //                    knei = listsimilarity.Count;
        //                }
        //                else
        //                {
        //                    knei = 2;
        //                }
        //                for (int i = 0; i < knei; i++)
        //                {
        //                    T += (float)(listsimilarity[i].similarity * itemOld[listsimilarity[i].item, j]);
        //                    M += Math.Abs(listsimilarity[i].similarity);
        //                }
        //                float DuDoan = (float)Math.Round((T / M), 2);
        //                item[h, j] = DuDoan;
        //            }
        //        }
        //    }
        //    flowLayoutPanelPredictionPearson.Controls.Clear();
        //    CreateMatrix(flowLayoutPanelPredictionPearson, hang, cot);
        //    for (int i = 0; i < hang; i++)
        //    {
        //        for (int n = 0; n < cot; n++)
        //        {
        //            //ma tran cosine
        //            TextBox bt1 = new TextBox();
        //            bt1 = flowLayoutPanelPredictionPearson.Controls.Find("txt" + i.ToString() + n.ToString(), true).FirstOrDefault() as TextBox;
        //            bt1.Text = item[i, n].ToString();
        //        }
        //    }
        //}

        private void btnNext5_Click(object sender, EventArgs e)
        {
            int hang = int.Parse(txtHang.Text);
            int cot = int.Parse(txtCot.Text);
            flowLayoutPanel1MTY.Controls.Clear();
            CreateMatrix(flowLayoutPanel1MTY, hang, cot);
            for (int i = 0; i < hang; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    //ma tran cosine
                    TextBox bt1 = new TextBox();
                    bt1 = flowLayoutPanel1MTY.Controls.Find("txt" + i.ToString() + j.ToString(), true).FirstOrDefault() as TextBox;
                    if (itemNorOld[i, j] == -10)
                    {
                        bt1.ForeColor = Color.Red;
                        bt1.BackColor = Color.Aqua;
                    }
                    bt1.Text = Math.Round((itemNormalized[i, j] + P[i]), 2).ToString();
                }
            }
            label6.Show();
        }
    }
}
