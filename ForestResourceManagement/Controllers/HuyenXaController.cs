using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForestResourceManagement.Models;

namespace ForestResourceManagement.Controllers
{
    public class HuyenController
    {
        private readonly FrdbContext _context;

        public HuyenController(FrdbContext context)
        {
            _context = context;
        }

        // Thêm huyện
        public void AddHuyen(string tenHuyen, string? info = null)
        {
            var huyen = new HuyenTable { TenHuyen = tenHuyen, Info = info };
            _context.HuyenTables.Add(huyen);
            _context.SaveChanges();
        }

        // Sửa huyện
        public void UpdateHuyen(int id, string tenHuyen, string? info = null)
        {
            var huyen = _context.HuyenTables.Find(id);
            if (huyen == null) throw new Exception("Huyện không tồn tại.");

            huyen.TenHuyen = tenHuyen;
            huyen.Info = info;
            _context.SaveChanges();
        }

        // Xóa huyện
        public void DeleteHuyen(int id)
        {
            var huyen = _context.HuyenTables.Find(id);
            if (huyen == null) throw new Exception("Huyện không tồn tại.");

            // Xóa các xã liên quan
            var xas = _context.XaTables.Where(x => x.HuyenId == id).ToList();
            _context.XaTables.RemoveRange(xas);

            _context.HuyenTables.Remove(huyen);
            _context.SaveChanges();
        }

        // Lấy danh sách huyện
        public List<HuyenTable> GetAllHuyens()
        {
            return _context.HuyenTables.ToList();
        }
    }

    public class XaController
    {
        private readonly FrdbContext _context;

        public XaController(FrdbContext context)
        {
            _context = context;
        }

        // Thêm xã
        public void AddXa(string tenXa, int huyenId, string? info = null)
        {
            var xa = new XaTable { TenXa = tenXa, HuyenId = huyenId, Info = info };
            _context.XaTables.Add(xa);
            _context.SaveChanges();
        }

        // Sửa xã
        public void UpdateXa(int id, string tenXa, int huyenId, string? info = null)
        {
            var xa = _context.XaTables.Find(id);
            if (xa == null) throw new Exception("Xã không tồn tại.");

            xa.TenXa = tenXa;
            xa.HuyenId = huyenId;
            xa.Info = info;
            _context.SaveChanges();
        }

        // Xóa xã
        public void DeleteXa(int id)
        {
            var xa = _context.XaTables.Find(id);
            if (xa == null) throw new Exception("Xã không tồn tại.");

            _context.XaTables.Remove(xa);
            _context.SaveChanges();
        }

        // Lấy danh sách xã
        public List<XaTable> GetAllXas()
        {
            return _context.XaTables.ToList();
        }
    }
}
