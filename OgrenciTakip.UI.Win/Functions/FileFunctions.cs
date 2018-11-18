
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using OgrenciTakip.Common.Message;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace OgrenciTakip.UI.Win.Functions
{
    public static class FileFunctions
    {
        public static void FormSablonKaydet(this string sablonAdi, int left, int top, int width, int height, FormWindowState windowState)
        {
            try
            {
                if (!Directory.Exists(Application.StartupPath + @"\Sablon Dosyalari"))
                    Directory.CreateDirectory(Application.StartupPath + @"\Sablon Dosyalari");

                //Xml dosyalarında girinti oluşturulmaını aktif hale getirdik.Yani xml dosyasi basamak basamak olucak
                var settings = new XmlWriterSettings { Indent = true };
                //Bu kod ile bir tane xml dosyasi oluşturmuş olduk.
                var writer = XmlWriter.Create(Application.StartupPath + $@"\Sablon Dosyalari\{ sablonAdi}_location.xml", settings);
                writer.WriteStartDocument();
                writer.WriteComment("Xml Benim Tarafımdan Oluşturuldu.Tahmin et Ben Kimim?");
                writer.WriteStartElement("Tablo");
                writer.WriteStartElement("Location");
                writer.WriteAttributeString("Left", left.ToString());
                writer.WriteAttributeString("Top", top.ToString());

                writer.WriteEndElement();
                writer.WriteStartElement("FormSize");
                if (windowState == FormWindowState.Maximized)
                {
                    writer.WriteAttributeString("Width", "-1");
                    writer.WriteAttributeString("Height", "-1");
                }
                else
                {
                    writer.WriteAttributeString("Width", width.ToString());
                    writer.WriteAttributeString("Height", height.ToString());
                }
                writer.WriteEndElement();
                writer.WriteEndElement();
                //Tabloyuda kapatmış olduk son endelementte
                writer.WriteEndDocument();
                //xml dosyasını oluşturmuş olduk.
                writer.Flush();
                writer.Close();

            }
            catch (Exception ex)
            {
                Messages.HataMesaji(ex.Message);
            }
        }
        public static void FormSablonYukle(this string sablonAdi, XtraForm frm)
        {
            var list = new List<string>();
            try
            {
                if (File.Exists(Application.StartupPath + $@"\Sablon Dosyalari\{sablonAdi}_location.xml"))
                {
                    var reader = XmlReader.Create(Application.StartupPath + $@"\Sablon Dosyalari\{sablonAdi}_location.xml");
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Location")
                        {
                            //0 ve 1 diyerek Location'ın Left ve top attributelarını eklemiş olduk
                            list.Add(reader.GetAttribute(0));
                            list.Add(reader.GetAttribute(1));
                        }
                        else if (reader.NodeType == XmlNodeType.Element && reader.Name == "FormSize")
                        {
                            //0 ve 1 diyerek Formsize'ın Height ve Width attributlarını eklemiş olduk
                            list.Add(reader.GetAttribute(0));
                            list.Add(reader.GetAttribute(1));
                        }

                    }
                    reader.Close();
                    reader.Dispose();
                }
            }
            catch (Exception ex)
            {

                Messages.HataMesaji(ex.Message);
            }
            if (list.Count <= 0) return;
            frm.Location = new Point(int.Parse(list[0]), int.Parse(list[1]));
            if (list[2] == "-1" && list[3] == "-1")
                frm.WindowState = FormWindowState.Maximized;
            else
                frm.Size = new Size(int.Parse(list[2]), int.Parse(list[3]));
        }
        public static void TabloSablonKaydet(this GridView tablo, string sablonAdi)
        {
            try
            {
                //Bu kodu yazmaksak filtrelenmiş olarak kaydeder. Buda istenmeyen durumdur.Bu yüzden filteleri temizliyoruz.
                tablo.ClearColumnsFilter();
                if (!Directory.Exists(Application.StartupPath + @"\Sablon Dosyalari"))
                    Directory.CreateDirectory(Application.StartupPath + @"\Sablon Dosyalari");

                //DevXpress'in bir özelliği olarak layoutları bile xml olarak kayıt etmeye izin verir.
                tablo.SaveLayoutToXml(Application.StartupPath + $@"\Sablon Dosyalari\{sablonAdi}.xml");
            }
            catch (Exception ex)
            {
                Messages.HataMesaji(ex.Message);
            }
        }
        public static void TabloSablonYukle(this GridView tablo, string sablonAdi)
        {
            try
            {
                if (File.Exists(Application.StartupPath + $@"\Sablon Dosyalari\{sablonAdi}.xml"))
                    //Xml olarak kayıt ettiğimiz layout dosyasının restore edilerek tekrardan yuklenmesını saglıyor.Bude devexpress'in bir özellği.
                    tablo.RestoreLayoutFromXml(Application.StartupPath + $@"\Sablon Dosyalari\{sablonAdi}.xml");

            }
            catch (Exception ex)
            {
                Messages.HataMesaji(ex.Message);
            }
        }
    }
}
