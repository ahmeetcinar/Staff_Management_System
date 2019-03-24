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

namespace Staff_Management_System
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            
            using (var reader = new StreamReader(@"C:\Users\ahmet\Desktop\staff.csv", Encoding.GetEncoding("iso-8859-9"), false))
            {
                List<string> listID = new List<string>();
                List<string> listName = new List<string>();
                List<string> listSur = new List<string>();
                List<string> listAddress = new List<string>();
                List<string> listSalary = new List<string>();
                


                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    lstbPersonelGoster.Items.Add(line.ToString());
                    var values = line.Split(',');

                    //listID.Add(values[0]);
                    //listName.Add(values[1]);
                    //listSur.Add(values[2]);
                    //listAddress.Add(values[3]);
                    //listSalary.Add(values[4]);

                }
            }
        }
        staff_information personel = new staff_information();
        private void cmbDil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDil.SelectedItem.ToString() == "Var")
            {
                grpbDil.Visible = true;
            }
            else
            {
                grpbDil.Visible = false;
            }
        }

        private void cmbAile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAile.SelectedItem.ToString() == "Evli")
            {
                grpbCocukSayisi.Visible = true;
                grpbYasAraligi.Visible = true;

            }
            else
            {
                grpbCocukSayisi.Visible = false;
                grpbYasAraligi.Visible = false;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            double bmoResult = 0;
            personel.Id = txtbId.Text;
            personel.Name = txtbName.Text;
            personel.Surname = txtbSurname.Text;
            personel.Addres = txtbAddres.Text;
            personel.BmoDeneyim = cmbDeneyim.SelectedIndex;
            personel.BmoSehir = cmbSehir.SelectedIndex;
            personel.BmoAkademikDerece = cmbAkademik.SelectedIndex;
            personel.BmoYoneticilikGorevi = cmbYönetici.SelectedIndex;

            Ekle();
            bmoResult = personel.calculateBmo();
            lstbPersonelGoster.Items.Add(personel.getStaff());

            StreamWriter myOutputStream = new StreamWriter(@"C:\Users\ahmet\Desktop\staff.csv");

            foreach (var item in lstbPersonelGoster.Items)
            {
                
                myOutputStream.WriteLine(item.ToString());
            }

            myOutputStream.Close();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            lstbPersonelGoster.Items.Remove(lstbPersonelGoster.SelectedItem);
            StreamWriter myOutputStream = new StreamWriter(@"C:\Users\ahmet\Desktop\staff.csv");

            foreach (var item in lstbPersonelGoster.Items)
            {
                myOutputStream.WriteLine(item.ToString());
            }

            myOutputStream.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            personel.Id = txtbId.Text;
            personel.Name = txtbName.Text;
            personel.Surname = txtbSurname.Text;
            personel.Addres = txtbAddres.Text;
            personel.BmoDeneyim = cmbDeneyim.SelectedIndex;
            personel.BmoSehir = cmbSehir.SelectedIndex;
            personel.BmoAkademikDerece = cmbAkademik.SelectedIndex;
            personel.BmoYoneticilikGorevi = cmbYönetici.SelectedIndex;

            Ekle();
            personel.calculateBmo();
            int x = lstbPersonelGoster.SelectedIndex;
            lstbPersonelGoster.Items.Remove(lstbPersonelGoster.SelectedItem);
            lstbPersonelGoster.Items.Insert(x, personel.getStaff());

            StreamWriter myOutputStream = new StreamWriter(@"C:\Users\ahmet\Desktop\staff.csv");

            foreach (var item in lstbPersonelGoster.Items)
            {
                
                myOutputStream.WriteLine(item.ToString());
            }

            myOutputStream.Close();
        }
        private void Ekle()
        {
            double bmoResult = 0;
            if (cmbDil.Text == "Var")
            {
                if (chkbDil1.Checked || chkbDil2.Checked)
                {
                    bmoResult += 0.2;
                }
                if (chkbDil3.Checked)
                {

                    bmoResult += (Convert.ToDouble(txtbDilSayisi.Text) * 0.05);
                }
                personel.BmoDil = bmoResult;
            }
            else if (cmbDil.Text == "Yok")
            {
                bmoResult = 0;
                personel.BmoDil = bmoResult;
            }
            bmoResult = 0;
            if (cmbAile.Text == "Evli")
            {
                if (chkbCocukYok.Checked || chkbEvli.Checked)
                {
                    bmoResult = +0.2;
                }
                if (chkb1cocuk.Checked)
                {
                    if (chkb06.Checked)
                    {
                        bmoResult += 0.2;
                    }
                    if (chkb718.Checked)
                    {
                        bmoResult += 0.3;
                    }
                    if (chkb18.Checked)
                    {
                        bmoResult += 0.4;
                    }
                }
                else if (chkb2veFazla.Checked)
                {
                    if (chkb06.Checked)
                    {
                        if (Convert.ToInt32(txtb06CocukSayisi.Text) > 2 || Convert.ToInt32(txtb06CocukSayisi.Text) < 0)
                        {
                            bmoResult += 0;
                        }
                        else
                        {
                            bmoResult += (Convert.ToInt32(txtb06CocukSayisi.Text) * 0.2);
                        }

                    }
                    if (chkb718.Checked)
                    {
                        if (Convert.ToInt32(txtb718CocukSayisi.Text) > 2 || Convert.ToInt32(txtb718CocukSayisi.Text) < 0)
                        {
                            bmoResult = +0;
                        }
                        else
                        {
                            bmoResult += (Convert.ToInt32(txtb718CocukSayisi.Text) * 0.3);
                        }

                    }
                    if (chkb18.Checked)
                    {
                        if (Convert.ToInt32(txtb18CocukSayisi.Text) > 2 || Convert.ToInt32(txtb18CocukSayisi.Text) < 0)
                        {
                            bmoResult = 0;
                        }
                        else
                        {
                            bmoResult += (Convert.ToInt32(txtb18CocukSayisi.Text) * 0.4);
                        }

                    }
                }
                personel.BmoAile = bmoResult;

            }
            if (cmbAile.Text == "Bekar")
            {
                bmoResult = 0;
                personel.BmoAile = bmoResult;
            }
        }
    }
}
