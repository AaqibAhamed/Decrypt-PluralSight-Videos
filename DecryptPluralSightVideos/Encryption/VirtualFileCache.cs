using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace DecryptPluralSightVideos.Encryption
{
    class VirtualFileCache : IDisposable
    {
        private readonly IPsStream encryptedVideoFile;
 
        public long Length
        {
            get
            {
                return this.encryptedVideoFile.Length;
            }
        }

        public VirtualFileCache(string encryptedVideoFilePath)
        {
            this.encryptedVideoFile = (IPsStream)new PsStream(encryptedVideoFilePath);
        }

        public VirtualFileCache(IPsStream stream)
        {
            this.encryptedVideoFile = stream;
        }

        public void Read(byte[] pv, int offset, int count, IntPtr pcbRead)
        {
            if (this.Length == 0L)
                return;
            this.encryptedVideoFile.Seek(offset, SeekOrigin.Begin);
            int length = this.encryptedVideoFile.Read(pv, 0, count);
            VideoEncryption.XorBuffer(pv, length, (long)offset);
            if (!(IntPtr.Zero != pcbRead))
                return;
            Marshal.WriteIntPtr(pcbRead, new IntPtr(length));
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
