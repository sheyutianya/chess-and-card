using tsf4g_tdr_csharp;
using System;
/// <summary>
/// ResConv导出的资源的头文件解析，需要tbase2.4以上版本配合使用
/// </summary>
/// 
namespace tsf4g_tdr_csharp
{
    public class TResHeadAll
    {

        public const int TRES_TRANSLATE_METALIB_HASH_LEN = 36;

        public const int TRES_ENCORDING_LEN = 32;


        public class TResHead
        {

            public int iMagic;

            public int iVersion;

            public int iUint;

            public int iCount;

            public byte[] szMetalibHash = new byte[TRES_TRANSLATE_METALIB_HASH_LEN];

            public int iResVersion;

            public UInt64 ullCreateTime;

            public byte[] szResEncording = new byte[TRES_ENCORDING_LEN];

            public byte[] szContentHash = new byte[TRES_TRANSLATE_METALIB_HASH_LEN];

        };


        public class resHeadExt
        {
            public int iDataOffset;
            public int iBuff; 
        }


        public TResHeadAll()
        {
            mHead = new TResHead();
            mResHeadExt = new resHeadExt();
        }


        public void load(ref tsf4g_tdr_csharp.TdrReadBuf srcBuf)
        {

            srcBuf.disableEndian();

            srcBuf.readInt32(ref mHead.iMagic);

            srcBuf.readInt32(ref mHead.iVersion);

            srcBuf.readInt32(ref mHead.iUint);

            srcBuf.readInt32(ref mHead.iCount);

            srcBuf.readCString(ref mHead.szMetalibHash, mHead.szMetalibHash.Length);

            srcBuf.readInt32(ref mHead.iResVersion);

            srcBuf.readUInt64(ref mHead.ullCreateTime);

            srcBuf.readCString(ref mHead.szResEncording, mHead.szResEncording.Length);

            srcBuf.readCString(ref mHead.szContentHash, mHead.szContentHash.Length);

            srcBuf.readInt32(ref mResHeadExt.iDataOffset);
            srcBuf.readInt32(ref mResHeadExt.iBuff);

        }


        public TResHead mHead;

        public resHeadExt mResHeadExt;

    }


}