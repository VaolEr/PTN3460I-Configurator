using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTN3460I_Configurator
{



//#define REVERSE_CRC
    //#define NORMAL_CRC
    class CRC
    {
        //Normal direction CRC polynoms
        static ulong N_CRC8_POLY        = 0xD5; // ETSI EN 302 307[16], 5.1.4
        public static ulong N_CRC8_DM_POLY     = 0x31; // Dallas/Maxim (1-Wire bus)
        static ulong N_CRC8_CCITT_POLY  = 0x07;

        static ulong N_CRC16_IBM        = 0x8005; // (Bisync, Modbus, USB, ANSI X3.28[20], also known as CRC-16 и CRC-16-ANSI)
        static ulong N_CRC16_CCITT_POLY = 0x1021; // (X.25, HDLC, XMODEM, Bluetooth, SD & others)
        static ulong N_CRC16_DNP_POLY   = 0x3D65; // (DNP, IEC 870, M-Bus)

        public static ulong N_CRC32_POLY       = 0x04C11DB7; // (V.42, MPEG-2, PNG[22], POSIX cksum)
        static ulong N_CRC32Q_POLY      = 0x814141AB; // (aviation; AIXM[23])

        static ulong N_CRC64_ISO_POLY	= 0x000000000000001B; // (HDLC — ISO 3309)

        //Reverse direction CRC polynoms
        static ulong R_CRC8_POLY        = 0xAB; // ETSI EN 302 307[16], 5.1.4
        public static ulong R_CRC8_DM_POLY     = 0x8C; // Dallas/Maxim (1-Wire bus)
        static ulong R_CRC8_CCITT_POLY  = 0xE0 ;

        static ulong R_CRC16_IBM		= 0xA001; // (Bisync, Modbus, USB, ANSI X3.28[20], also known as CRC-16 и CRC-16-ANSI)
        static ulong R_CRC16_CCITT_POLY = 0x8408; // (X.25, HDLC, XMODEM, Bluetooth, SD & others)
        static ulong R_CRC16_DNP_POLY   = 0xA6BC; // (DNP, IEC 870, M-Bus)

        public static ulong R_CRC32_POLY       = 0xEDB88320; // (V.42, MPEG-2, PNG[22], POSIX cksum)
        static ulong R_CRC32Q_POLY      = 0xD5828281; // (aviation; AIXM[23])

        static ulong R_CRC64_ISO_POLY	= 0xD800000000000000; // (HDLC — ISO 3309)

        static bool NORMAL_CRC = false;
        static bool REVERSE_CRC = true;

        static ulong CRCINIT = 0xFF;
        static ulong CRC8_INIT = 0x00;

        public static ulong[] CRC_table = new ulong[256]; // table for count the CRC
        public static void CRC_Init(ulong CRCPOLY) //reversed algortm
        {
            if (NORMAL_CRC) 
            { 
                for (int i = 0; i <= 0xFF; i++) // for each element T
                {
                    CRC_table[i] = (ulong) (i << 24);
                    for (int j = 8; j > 0; j--)         // for each bit in byte
                        if ((CRC_table[i] & 0x80000000) == 1)  // if higher bit
                            CRC_table[i] = (CRC_table[i] << 1) ^ CRCPOLY;
                        else
                            CRC_table[i] <<= 1;
                }
            }

            if (REVERSE_CRC)
            {
                for (int i = 0; i <= 0xFF; i++) // for each element T
                {
                    CRC_table[i] = (ulong) i;
                    for (int j = 8; j > 0; j--)         // for each bit in byte
                        if ((CRC_table[i] & 1) == 1)           // if lower bit
                            CRC_table[i] = (CRC_table[i] >> 1) ^ CRCPOLY;
                        else
                            CRC_table[i] >>= 1;
                }
            }
        }

        public static ulong CRC8_Count(byte[] buff, int bufflen)
        {
            ulong crc = CRC8_INIT;
            int i = 0;
            if (NORMAL_CRC)
            {
                for (i = 0; i < bufflen; i++)
                    crc = CRC_table[crc ^ buff[i]];
            }

            if (REVERSE_CRC)
            {
                for (i = 0; i < bufflen; i++)
                    crc = CRC_table[crc ^ buff[i]];
            }

            return crc; // Вернуть инвертированный crc - см. ниже
        }

        public static ulong CRC_Count(byte[] buff, int bufflen)
        {
            ulong crc = CRCINIT;
            int i = 0;
            if (NORMAL_CRC)
            {
                while (bufflen-- > 0)
                    crc = CRC_table[(crc >> 24 ^ buff[i++]) & 0xFF] ^ (crc << 8);
            }

            if (REVERSE_CRC)
            {
                while (bufflen-- > 0)
                    crc = CRC_table[(crc ^ buff[i++]) & 0xFF] ^ (crc >> 8);
                crc = ~crc;
            }

            return crc; // Вернуть инвертированный crc - см. ниже
        }
    }
}
