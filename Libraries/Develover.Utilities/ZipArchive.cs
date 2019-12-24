using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Compression;

namespace Develover.Utilities
{
    public class ZipArchive
    {
        public void ArchiveDirectory(string pathZip,string pathOUT) {
            using (ZipArchive archive = new ZipArchive()) {
                archive.AddDirectory(path);
                archive.Save(pathOUT);
            }
        }
         public void ArchiveFiles(string[] pathFileAdd, string pathFileZip) {
            string[] sourcefiles = pathFileAdd;
            using (ZipArchive archive = new ZipArchive()) {
                foreach (string file in sourcefiles) {
                    archive.AddFile(file, "/");
                }
                archive.Save(pathFileZip);
            }
        }
        public void AddFileToArchive(string[] pathFileAdd, string pathFileZip) {
    MemoryStream stream = new MemoryStream();
    string[] sourcefiles = pathFileAdd;
    string pathToZipArchive = pathFileZip;

    using (FileStream fs = File.Open(pathToZipArchive, FileMode.Open)) {
        fs.CopyTo(stream);
        fs.Close();
    }
    stream.Seek(0, SeekOrigin.Begin);
    using (ZipArchive archive = ZipArchive.Read(stream, System.Text.Encoding.Default, false)) {
        foreach (string sfile in sourcefiles) {
            archive.AddFile(sfile, "/");
        }
        archive.Save(pathToZipArchive);
    }
}
 volatile bool stopArchiving = false;
        public void FilterArchiveFiles(string[] pathFileAdd, string pathFileZip) {
            string[] sourcefiles = pathFileAdd;
            using (ZipArchive archive = new ZipArchive()) {
                archive.ItemAdding += archive_ItemAdding;
                foreach (string file in sourceFiles) {
                    archive.AddFile(file, "/");
                }
                archive.Save(pathFileZip);
            }
        }

        private void archive_ItemAdding(object sender, ZipItemAddingEventArgs args) {
            if (args.Item.CreationTime.Date != DateTime.Today)
                args.Action = ZipItemAddingAction.Cancel;
            if (stopArchiving) args.Action = ZipItemAddingAction.Stop;
        }
        volatile bool stopProgress = false;

        public void CancelArchiveProgress() {
            string[] sourcefiles = this.sourceFiles;
            using (ZipArchive archive = new ZipArchive()) {
                archive.Progress += archive_Progress;
                foreach (string file in sourceFiles) {
                    archive.AddFile(file, "/");
                }
                archive.Save("Documents\\CancelArchiveProgress.zip");
            }
        }

        private void archive_Progress(object sender, ProgressEventArgs args) {
            args.CanContinue = !this.stopProgress;
        }
        public void ProtectPassword(string[] pathFileAdd, string pathFileZip,string password,string Comment) {
            string[] sourcefiles = pathFileAdd;
            using (ZipArchive archive = new ZipArchive()) {
                foreach (string file in sourceFiles) {
                    ZipFileItem zipFI = archive.AddFile(file, "/");
                    zipFI.EncryptionType = EncryptionType.Aes128;
                    zipFI.Password = password;
                    zipFI.Comment = Comment;
                }
                archive.Save(pathFileZip);
            }
        }
        public void ArchiveByteArray(byte[] arrByte, string pathFileZip) {
            byte[] myByteArray = arrByte;
            using (Stream myZippedStream = new FileStream(pathFileZip, FileMode.Create)) {
                using (ZipArchive archive = new ZipArchive()) {
                    archive.AddByteArray("myByteArray", myByteArray);
                    archive.Save(myZippedStream);
                }
            }
        }
        public void UnzipArchive(string[] pathExtract , string pathFileZip) {
            string pathToZipArchive = pathFileZip;
            string pathToExtract = pathExtract;
            using (ZipArchive archive = ZipArchive.Read(pathToZipArchive)) {
                foreach (ZipItem item in archive) {
                    item.Extract(pathToExtract);
                }
            }
        }
        public void UnzipArchiveConflict(string[] pathExtract , string pathFileZip) {
            string pathToZipArchive = pathFileZip;
            string pathToExtract = pathExtract;
            using (ZipArchive archive = ZipArchive.Read(pathToZipArchive)) {
                archive.OptionsBehavior.AllowFileOverwrite = AllowFileOverwriteMode.Custom;
                archive.AllowFileOverwrite += archive_AllowFileOverwrite;
                foreach (ZipItem item in archive) {
                    item.Extract(pathToExtract);
                }
            }
        }

        private void archive_AllowFileOverwrite(object sender, AllowFileOverwriteEventArgs e) {
            FileInfo fi = new FileInfo(e.TargetFilePath);
            if (e.ZipItem.LastWriteTime < fi.LastWriteTime) e.Cancel = true;
        }
    }
}
