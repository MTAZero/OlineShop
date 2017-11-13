using OnlineShop_Data.Interface;
using OnlineShop_Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop_Data.Service
{
    class MatHangService : IService<MATHANG>
    {
        private OnlineShop_DbContext dataContext = new OnlineShop_DbContext();

        public MATHANG Add(MATHANG entity, ref string err)
        {
            try
            {
                dataContext.MATHANGs.Add(entity);
                dataContext.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return new MATHANG();
            }
        }

        public bool Delete(int id, ref string err)
        {
            try
            {
                MATHANG entity = dataContext.MATHANGs.Find(id);
                dataContext.MATHANGs.Remove(entity);
                dataContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool Delete(MATHANG entity, ref string err)
        {
            try
            {
                dataContext.MATHANGs.Remove(entity);
                dataContext.SaveChanges();
                return true;    
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public MATHANG Find(int id, ref string err)
        {
            MATHANG entity = dataContext.MATHANGs.Find(id);
            if (entity == null)
            {
                err = "Không tìm thấy";
                return null;
            }

            return entity;
        }

        public IList<MATHANG> getAll()
        {
            return dataContext.MATHANGs.ToList();
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

        public bool Update(MATHANG entity, ref string err)
        {
            try
            {
                MATHANG tgz = dataContext.MATHANGs.Find(entity.ID);
                tgz.ANH = entity.ANH;
                tgz.GIABAN = entity.GIABAN;
                tgz.KHUYENMAI = entity.KHUYENMAI;
                tgz.LOAI = entity.LOAI;
                tgz.TEN = entity.TEN;
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
