using System.IO;

namespace DecryptPluralSightVideos.Encryption
{
    public class PsStream : IPsStream
    {
        private readonly Stream fileStream;
        private long _length;

        public long Length {
            get
            {
                return this._length;
            }
        }
        public int BlockSize {
            get
            {
                return 262144;
            }
        }
        public PsStream(string filenamePath)
        {
            this.fileStream = (Stream)File.Open(filenamePath, FileMode.Open, FileAccess.Read, FileShare.Read);
            this._length = new FileInfo(filenamePath).Length;
        }

        public void Seek(int offset, SeekOrigin begin)
        {
            if (this._length <= 0L)
                return;
            this.fileStream.Seek((long)offset, begin);
        }

        public int Read(byte[] pv, int i, int count)
        {
            if (this._length <= 0L)
                return 0;
            return this.fileStream.Read(pv, i, count);
        }

        public void Dispose()
        {
            this._length = 0L;
            this.fileStream.Dispose();
        }
    }
}
