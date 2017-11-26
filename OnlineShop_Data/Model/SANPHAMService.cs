using OnlineShop_Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop_Data.Service
{
    public class SANPHAMService : IService<SANPHAM>
    {
        private OnlineShop_DbContext dataContext = new OnlineShop_DbContext();

        public SANPHAM Add(SANPHAM entity, ref string err)
        {
            try
            {
                dataContext.SANPHAMs.Add(entity);
                dataContext.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return new SANPHAM();
            }
        }

        public bool Delete(int id, ref string err)
        {
            try
            {
                SANPHAM entity = dataContext.SANPHAMs.Find(id);
                dataContext.SANPHAMs.Remove(entity);
                dataContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool Delete(SANPHAM entity, ref string err)
        {
            try
            {
                dataContext.SANPHAMs.Remove(entity);
                dataContext.SaveChanges();
                return true;    
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public SANPHAM Find(int id, ref string err)
        {
            SANPHAM entity = dataContext.SANPHAMs.Find(id);
            if (entity == null)
            {
                err = "Không tìm thấy";
                return null;
            }

            return entity;
        }

        public IList<SANPHAM> getAll()
        {
            return dataContext.SANPHAMs.ToList();
        }

        public bool Save(ref string err)
        {
            try
            {
                dataContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool Update(SANPHAM entity, ref string err)
        {
            try
            {
                SANPHAM tgz = dataContext.SANPHAMs.Find(entity.ID);
       
                tgz.TEN = entity.TEN;
                tgz.GIASANPHAM = entity.GIASANPHAM;
                tgz.KHUYENMAI = entity.KHUYENMAI;
                tgz.MOTA = entity.MOTA;
                tgz.THONGTIN = entity.THONGTIN;
                tgz.LOAISP = entity.LOAISP;
                tgz.DOITUONG = entity.DOITUONG;
                tgz.TRANGTHAI = entity.TRANGTHAI;

                dataContext.SaveChanges();
                                
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
    }
}
