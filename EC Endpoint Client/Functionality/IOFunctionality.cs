using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using EC_Endpoint_Client.Classes.Shipments.Intermediary;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.BrokerService;

namespace EC_Endpoint_Client.Functionality
{
    class IoFunctionality
    {
        private const string Filter = "Text File|*.txt|XML file|*.xml|All Files|*.*";

        public static void GeneralizedSaveFile(object obj)
        {
            SaveFileDialog sfd = new SaveFileDialog { Filter = Filter };

            DialogResult result = sfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                System.Xml.Serialization.XmlSerializer write = new System.Xml.Serialization.XmlSerializer(obj.GetType());
                StreamWriter file = new StreamWriter(sfd.FileName);
                write.Serialize(file, obj);
                file.Close();
            }
        }

        public static void GeneralizedSaveFileWithPathSupplied(object obj, string path)
        {            
            System.Xml.Serialization.XmlSerializer write = new System.Xml.Serialization.XmlSerializer(obj.GetType());
            StreamWriter file = new StreamWriter(path);
            write.Serialize(file, obj);
            file.Close();
        }

        public static string WriteStreamToFile(Stream input)
        {
            SaveFileDialog sfd = new SaveFileDialog { Filter = Filter };

            DialogResult result = sfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                using (Stream file = File.OpenWrite(sfd.FileName))
                {
                    CopyStream(input, file);
                }
            }

            return sfd.FileName;
        }

        private static void CopyStream(Stream input, Stream output)
        {
            byte[] buffer = new byte[8 * 1024];
            int len;
            while ((len = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, len);
            }
        }

        public static void GetStreamedattachmentFromFile(IntermediaryStreamedSubmitAttachmentShipment streamedAttachment)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                streamedAttachment.FileName = Path.GetFileName(ofd.FileName);
                streamedAttachment.Name = Path.GetFileNameWithoutExtension(ofd.FileName);
                streamedAttachment.FilePath = Path.GetFullPath(ofd.FileName);
                FileInfo fi = new FileInfo(ofd.FileName);
                double a = fi.Length;
                string mark = " MB";
                if (a > 1000000)
                    a = a / 1000000;
                else
                {
                    a = a / 1000;
                    mark = " KB";
                }
                 
                streamedAttachment.FileSize = string.Format("{0:0.00}", a) + mark ;
            }
        }

        public static void GetStreamedPayloadFromFile(UploadFileStreamedShipment streamedShipment)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                streamedShipment.FileName = Path.GetFileName(ofd.FileName);
                streamedShipment.FilePath = Path.GetFullPath(ofd.FileName);
            }
        }

        public static string WriteBytesToFile(byte[] bytes)
        {
            if (bytes.Length <= 0)
            {
                return string.Empty;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = @"ZIP files (*.zip)|*.zip|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return string.Empty;
            }

            Stream myStream = saveFileDialog.OpenFile();

            myStream.Write(bytes, 0, bytes.Length);
            myStream.Close();

            return saveFileDialog.FileName;
            
        }

        public static T GeneralizedLoadFile<T>()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            T obj = default(T);
            if (result == DialogResult.OK)
            {
                using (StreamReader file = new StreamReader(ofd.FileName))
                {
                    System.Xml.Serialization.XmlSerializer read = new System.Xml.Serialization.XmlSerializer(typeof(T));
                    XmlTextReader xmlreader = new XmlTextReader(file);
                    obj = (T)read.Deserialize(xmlreader);
                }

                return obj;
            }

            return obj;
        }

        public static T GeneralizedLoadFile<T>(T obj)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                DialogResult result = ofd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    using (StreamReader file = new StreamReader(ofd.FileName))
                    {
                        System.Xml.Serialization.XmlSerializer read =
                            new System.Xml.Serialization.XmlSerializer(typeof(T));
                        XmlTextReader xmlreader = new XmlTextReader(file);
                        obj = (T) read.Deserialize(xmlreader);
                    }
                    return obj;
                }
            }
            catch (Exception)
            {
                // ignored
            }

            return obj;
        }

        public static byte[] GeneralizedLoadAttachment(out string filename)
        {
            filename = string.Empty;
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                filename = ofd.SafeFileName;
                return File.ReadAllBytes(ofd.FileName);
            }

            return null;
        }

        public static byte[] GeneralizedLoadAttachment()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                return File.ReadAllBytes(ofd.FileName);
            }

            return null;
        }
    }
}
