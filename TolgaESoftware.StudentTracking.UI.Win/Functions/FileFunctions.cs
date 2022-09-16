using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using DevExpress.Export;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Message;

namespace TolgaESoftware.StudentTracking.UI.Win.Functions
{
    public static class FileFunctions
    {
        public static void SaveFormTemplate(this string templateName, int left, int top, int width, int height, FormWindowState windowState)
        {
            try
            {
                if (!Directory.Exists(Application.StartupPath + @"\Template Files"))
                    Directory.CreateDirectory(Application.StartupPath + @"\Template Files");

                var settings = new XmlWriterSettings { Indent = true };
                var writer = XmlWriter.Create(Application.StartupPath + $@"\Template Files\{templateName}_location.xml", settings);
                writer.WriteStartDocument();
                writer.WriteComment("Created by TolgaESoftware");
                writer.WriteStartElement("Table");
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
                writer.WriteEndDocument();
                writer.Flush();
                writer.Close();

            }
            catch (Exception exc)
            {
                Messages.ErrorMessage(exc.Message);
            }
        }

        public static void LoadFormTemplate(this string templateName, XtraForm form)
        {
            var list = new List<string>();

            try
            {
                if (File.Exists(Application.StartupPath + $@"\Template Files\{templateName}_location.xml"))
                {
                    var reader = XmlReader.Create(Application.StartupPath + $@"\Template Files\{templateName}_location.xml");

                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Location")
                        {
                            list.Add(reader.GetAttribute(0));
                            list.Add(reader.GetAttribute(1));
                        }
                        else if (reader.NodeType == XmlNodeType.Element && reader.Name == "FormSize")
                        {
                            list.Add(reader.GetAttribute(0));
                            list.Add(reader.GetAttribute(1));
                        }
                    }

                    reader.Close();
                    reader.Dispose();
                }
            }
            catch (Exception exc)
            {
                Messages.ErrorMessage(exc.Message);
            }

            if (list.Count <= 0) return;

            form.Location = new Point(int.Parse(list[0]), int.Parse(list[1])); // (int) value = int.Parse(value)

            if (list[2] == "-1" && list[3] == "-1") form.WindowState = FormWindowState.Maximized;
            else form.Size = new Size(int.Parse(list[2]), int.Parse(list[3]));
        }

        public static void SaveTableTemplate(this GridView table,string templateName)
        {
            try
            {
                table.ClearColumnsFilter();

                if (!Directory.Exists(Application.StartupPath + @"\Template Files"))
                    Directory.CreateDirectory(Application.StartupPath + @"\Template Files");

                table.SaveLayoutToXml(Application.StartupPath + $@"\Template Files\{templateName}.xml");
            }
            catch (Exception exc)
            {
                Messages.ErrorMessage(exc.Message);
            }
        }

        public static void LoadTableTemplate(this GridView table,string templateName)
        {
            try
            {
                if (File.Exists(Application.StartupPath + $@"\Template Files\{templateName}.xml"))
                    table.RestoreLayoutFromXml(Application.StartupPath + $@"\Template Files\{templateName}.xml");
            }
            catch (Exception exc)
            {
                Messages.ErrorMessage(exc.Message);
            }
        }

        public static void ExportTable(this GridView table, FileType fileType,string fileFormat,string excelPageName=null)
        {
            if (Messages.TableExportMessage(fileFormat) != DialogResult.Yes) return;
            
            if (!Directory.Exists(Application.StartupPath + @"\Temp"))
                Directory.CreateDirectory(Application.StartupPath + @"\Temp");

            var fileName = Guid.NewGuid().ToString();
            var filePath = $@"{Application.StartupPath}\Temp\{fileName}";

            switch (fileType)
            {
                case FileType.ExcelStandard:
                {
                    var options = new XlsxExportOptionsEx
                    {
                        ExportType = ExportType.Default,
                        SheetName = excelPageName,
                        TextExportMode = TextExportMode.Text,
                    };

                    filePath = filePath + ".Xlsx";
                    table.ExportToXlsx(filePath,options);
                }
                    break;
                case FileType.FormattedExcel:
                {
                    var options = new XlsxExportOptionsEx
                    {
                        ExportType = ExportType.WYSIWYG,
                        SheetName = excelPageName,
                        TextExportMode = TextExportMode.Text
                    };

                    filePath = filePath + ".Xlsx";
                    table.ExportToXlsx(filePath,options);
                }
                    break;
                case FileType.UnformattedExcel:
                {
                    var options = new CsvExportOptionsEx
                    {
                        ExportType = ExportType.WYSIWYG,
                        TextExportMode = TextExportMode.Text
                    };

                    filePath = filePath + ".Csv";
                    table.ExportToCsv(filePath,options);
                }
                    break;
                case FileType.Word:
                {
                    filePath = filePath + ".Docx";
                    table.ExportToDocx(filePath);
                    //table.ExportToRtf(filePath);
                }
                    break;
                case FileType.Pdf:
                {
                    filePath = filePath + ".Pdf";
                    table.ExportToPdf(filePath);
                }
                    break;
                case FileType.Txt:
                {
                    var options = new TextExportOptions {TextExportMode = TextExportMode.Text};
                    filePath = filePath + ".Txt";
                    table.ExportToText(filePath,options);
                }
                    break;
            }

            if (!File.Exists(filePath))
            {
                Messages.ErrorMessage("Tablo Verileri Dosyaya Aktarılamadı.");
                return;
            }

            Process.Start(filePath);
        }
    }
}