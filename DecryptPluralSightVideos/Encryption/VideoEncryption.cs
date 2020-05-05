namespace DecryptPluralSightVideos.Encryption
{
    public class VideoEncryption
    {
        public static void XorBuffer(byte[] buff, int length, long position)
        {
            string str1 = "pluralsight";
            string str2 = "\x0006?zY¢\x00B2\x0085\x009FL\x00BEî0Ö.ì\x0017#©>Å£Q\x0005¤°\x00018Þ^\x008Eú\x0019Lqß'\x009D\x0003ßE\x009EM\x0080'x:\0~\x00B9\x0001ÿ 4\x00B3õ\x0003Ã§Ê\x000EAË\x00BC\x0090è\x009Eî~\x008B\x009Aâ\x001B¸UD<\x007FKç*\x001Döæ7H\v\x0015Arý*v÷%Âþ\x00BEä;pü";
            for (int index = 0; index < length; ++index)
            {
                byte num = (byte)((ulong)((int)str1[(int)((position + (long)index) % (long)str1.Length)] ^ (int)str2[(int)((position + (long)index) % (long)str2.Length)]) ^ (ulong)((position + (long)index) % 251L));
                buff[index] = (byte)((uint)buff[index] ^ (uint)num);
            }
        }
    }
}
