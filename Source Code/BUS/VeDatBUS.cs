using System;
using System.Collections.Generic;
using System.Text;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class VeDatBUS
    {
        public static bool DatVe(VeDatDTO vd)
        {
            bool kq = VeDatDAO.DatVe(vd);
            return kq;
        }
    }
}
